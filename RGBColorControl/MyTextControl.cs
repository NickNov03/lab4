using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGBColorControl
{
    public partial class MyTextControl : TextBox
    {

        public enum InputMode
        {
            Decimal,
            Hexadecimal
        }

        private InputMode _mode = InputMode.Decimal;
        private Color _color = Color.Black;
        private ColorChannel _channel;

        public InputMode Mode
        {
            get { return _mode; }
            set
            {
                _mode = value;
                UpdateText();
            }
        }

        public event EventHandler ColorChanged;

        public enum ColorChannel
        {
            Red,
            Green,
            Blue
        }

        public ColorChannel Channel
        {
            get { return _channel; }
            set
            {
                _channel = value;
                UpdateText();
            }
        }
        private int GetColor()
        {
            UpdateColor();
            switch (Channel)
            {
                case ColorChannel.Red:
                    return _color.R;
                case ColorChannel.Green:
                    return _color.G;
                case ColorChannel.Blue:
                    return _color.B;
            }
            return _color.R;
        }
        public int ChannelColor
        {
            get { return GetColor(); }
        }
        public Color Color
        {
            get { return _color; }
            set
            {
                _color = value;
                UpdateText();
            }
        }

        public MyTextControl()
        {
            InitializeComponent();
        }

        public void SetChannel(ColorChannel channel)
        {
            _channel = channel;
        }

        private void UpdateColor()
        {
            Color newColor;
            try
            {
                if (_mode == InputMode.Decimal)
                {
                    switch (_channel)
                    {
                        case ColorChannel.Red:
                            newColor = Color.FromArgb(int.Parse(this.Text), _color.G, _color.B);
                            break;
                        case ColorChannel.Green:
                            newColor = Color.FromArgb(_color.R, int.Parse(this.Text), _color.B);
                            break;
                        case ColorChannel.Blue:
                            newColor = Color.FromArgb(_color.R, _color.G, int.Parse(this.Text));
                            break;
                        default:
                            newColor = _color;
                            break;
                    }
                }
                else
                {
                    int value;
                    if (int.TryParse(this.Text, System.Globalization.NumberStyles.HexNumber, null, out value))
                    {
                        this.Text = Math.Min(255, Math.Max(0, value)).ToString("X2");
                        int.TryParse(this.Text, System.Globalization.NumberStyles.HexNumber, null, out value);
                        switch (_channel)
                        {
                            case ColorChannel.Red:
                                if (value >= 256) newColor = Color.FromArgb(value - 1, _color.G, _color.B);
                                else newColor = Color.FromArgb(value, _color.G, _color.B);
                                break;
                            case ColorChannel.Green:
                                if (value >= 256) newColor = Color.FromArgb(_color.R, value - 1, _color.B);
                                else newColor = Color.FromArgb(_color.R, value, _color.B);
                                break;
                            case ColorChannel.Blue:
                                if (value >= 256) newColor = Color.FromArgb(_color.R, _color.G, value - 1);
                                else newColor = Color.FromArgb(_color.R, _color.G, value);
                                break;
                            default:
                                newColor = _color;
                                break;
                        }
                    }
                    else
                    {
                        return;
                    }
                }

                if (newColor != _color)
                {
                    _color = newColor;
                    OnColorChanged();
                }
            }
            catch { }
            
        }

        private void UpdateText()
        {
            switch (_channel)
            {
                case ColorChannel.Red:
                    this.Text = _color.R.ToString();
                    break;
                case ColorChannel.Green:
                    this.Text = _color.G.ToString();
                    break;
                case ColorChannel.Blue:
                    this.Text = _color.B.ToString();
                    break;
                default:
                    this.Text = string.Empty;
                    break;
            }
        }

        protected virtual void OnColorChanged()
        {
            ColorChanged?.Invoke(this, EventArgs.Empty);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if (this.TextLength > 0)
            {
                UpdateColor();
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (_mode == InputMode.Decimal)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            else
            {
                e.Handled = !Regex.IsMatch(e.KeyChar.ToString(), "[0-9a-fA-F]") && !char.IsControl(e.KeyChar);
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (this.TextLength > 0)
            {
                int value;
                if (_mode == InputMode.Decimal && int.TryParse(this.Text, out value))
                {
                    this.Text = Math.Min(255, Math.Max(0, value)).ToString();
                }
                else if (_mode == InputMode.Hexadecimal && int.TryParse(this.Text, System.Globalization.NumberStyles.HexNumber, null, out value))
                {
                    this.Text = Math.Min(255, Math.Max(0, value)).ToString("X2");
                }
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Control && e.KeyCode == Keys.V)
            {
                string clipboardText = Clipboard.GetText();
                int value;
                if (int.TryParse(clipboardText, out value))
                {
                    if (_mode == InputMode.Decimal)
                    {
                        this.Text = Math.Min(255, Math.Max(0, value)).ToString();
                    }
                    else if (_mode == InputMode.Hexadecimal)
                    {
                        this.Text = Math.Min(255, Math.Max(0, value)).ToString("X2");
                    }
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}