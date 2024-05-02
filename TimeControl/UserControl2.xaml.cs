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

namespace TimeControl
{
    /// <summary>
    /// Логика взаимодействия для UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        private DispatcherTimer timer;

        public UserControl2()
        {
            InitializeComponent();
            StartClock();
        }

        private void StartClock()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMinutes(1);
            timer.Tick += Timer_Tick;
            timer.Start();

            UpdateClock();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }

        private void UpdateClock()
        {
            DateTime currentTime = DateTime.Now;

            double hourAngle = 360 * ((currentTime.Hour % 12) / 12.0) + (360 / 12.0) * (currentTime.Minute / 60.0);
            double minuteAngle = 360 * (currentTime.Minute / 60.0);

            hourHand.RenderTransform = new RotateTransform(hourAngle, 150, 150);
            minuteHand.RenderTransform = new RotateTransform(minuteAngle, 150, 150);
        }
    }
}
