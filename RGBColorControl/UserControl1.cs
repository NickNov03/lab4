using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGBColorControl
{

    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            myTextControl1.Mode = MyTextControl.InputMode.Decimal;
            myTextControl2.Mode = MyTextControl.InputMode.Decimal;
            myTextControl3.Mode = MyTextControl.InputMode.Decimal;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            myTextControl1.Mode = MyTextControl.InputMode.Hexadecimal;
            myTextControl2.Mode = MyTextControl.InputMode.Hexadecimal;
            myTextControl3.Mode = MyTextControl.InputMode.Hexadecimal;
        }

        private void myTextControl1_TextChanged(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(myTextControl1.ChannelColor, myTextControl2.ChannelColor, myTextControl3.ChannelColor);
            panel1.BackColor = color;
        }

        private void myTextControl2_TextChanged(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(myTextControl1.ChannelColor, myTextControl2.ChannelColor, myTextControl3.ChannelColor);
            panel1.BackColor = color;
        }

        private void myTextControl3_TextChanged(object sender, EventArgs e)
        {
           Color color = Color.FromArgb(myTextControl1.ChannelColor, myTextControl2.ChannelColor, myTextControl3.ChannelColor);
            panel1.BackColor = color;
        }
    }
}
