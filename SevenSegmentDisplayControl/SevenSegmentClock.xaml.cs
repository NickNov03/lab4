using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SevenSegmentDisplayControl
{
    /// <summary>
    /// Логика взаимодействия для SevenSegmentClock.xaml
    /// </summary>
    public partial class SevenSegmentClock : UserControl
    {
        private DispatcherTimer mTimer;
        public SevenSegmentClock()
        {
            mTimer = new DispatcherTimer();
            mTimer.Interval = TimeSpan.FromSeconds(1);
            mTimer.Tick += TimerTick;
            mTimer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            InvalidateVisual();
        }

        public int DigitWidth { get; set; } = 45; 
        public int Thickness { get; set; } = 5; 

        bool[] activeSegments = {
            true, true, true, true, true, true, false,
            false, true, true, false, false, false, false,
            true, true, false, true, true, false, true,
            true, true, true, true, false, false, true,
            false, true, true, false, false, true, true,
            true, false, true, true, false, true, true,
            true, false, true, true, true, true, true,
            true, true, true, false, false, false, false,
            true, true, true, true, true, true, true,
            true, true, true, false, false, true, true,
        };

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            DateTime currentTime = DateTime.Now;

            int x = 0, y = 0;
            int offset = 10;

            DrawDigit(currentTime.Hour / 10, x, y, drawingContext);
            x += DigitWidth + Thickness + offset;
            DrawDigit(currentTime.Hour % 10, x, y, drawingContext);
            x += DigitWidth + DigitWidth / 2 + offset;
            DrawDigit(currentTime.Minute / 10, x, y, drawingContext);
            x += DigitWidth + Thickness + offset;
            DrawDigit(currentTime.Minute % 10, x, y, drawingContext);
            x += DigitWidth + DigitWidth / 2 + offset;
            DrawDigit(currentTime.Second / 10, x, y, drawingContext);
            x += DigitWidth + Thickness + offset;
            DrawDigit(currentTime.Second % 10, x, y, drawingContext);
        }


        void DrawVertical(int x, int y, bool active, DrawingContext drawingContext)
        {
            Brush brush = (active ? Brushes.Red : Brushes.LightGray);
            drawingContext.DrawRectangle(brush, null, new Rect(x, y, Thickness, DigitWidth));
        }

        void DrawHorizontal(int x, int y, bool active, DrawingContext drawingContext)
        {
            Brush brush = (active ? Brushes.Red : Brushes.LightGray);
            drawingContext.DrawRectangle(brush, null, new Rect(x, y, DigitWidth, Thickness));
        }

        void DrawDigit(int digit, int x, int y, DrawingContext drawingContext)
        {

            DrawHorizontal(x + Thickness, y, activeSegments[7 * digit + 0], drawingContext);

            DrawVertical(x + Thickness + DigitWidth, y + Thickness, activeSegments[7 * digit + 1], drawingContext);

            DrawVertical(x + Thickness + DigitWidth, y + 2 * Thickness + DigitWidth, activeSegments[7 * digit + 2], drawingContext);

            DrawHorizontal(x + Thickness, y + 2 * DigitWidth + 2 * Thickness, activeSegments[7 * digit + 3], drawingContext);

            DrawVertical(x, y + 2 * Thickness + DigitWidth, activeSegments[7 * digit + 4], drawingContext);

            DrawVertical(x, y + Thickness, activeSegments[7 * digit + 5], drawingContext);

            DrawHorizontal(x + Thickness, y + Thickness + DigitWidth, activeSegments[7 * digit + 6], drawingContext);
        }
    }
}
