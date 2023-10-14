using System.Diagnostics;
using System.Timers;
using static System.Timers.Timer;

namespace CalendarTimer
{
    public partial class Form1 : Form
    {
        //Stopwatch Class is used to measure performance time, not pure stopwatch
        //PC Win Form only needs Hour, minute, and Second
        private int hour;
        private int minute;
        private int second;
        private System.Timers.Timer swTimer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            swTimer = new System.Timers.Timer();
            //Interval : If you want to make stopwatch for people like runner
            //swTimer.Interval = 1 : Set Stopwatch Interval as 1 miliseconds
            //swTimer.Interval = 1000 : Set Stopwatch Interval as 1 seconds
            swTimer.Interval = 1000;
            swTimer.Enabled = true;
            swTimer.Elapsed += SwEvent;
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_tick(object sender, EventArgs e)
        {
            //Set Time as Current Time
            //Timer is necessary to display digital clock
            CurTime.Text = DateTime.Now.ToString("HH:mm:ss \n yyyy-MM-dd dddd");
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            swTimer.Start();
        }

        //Subscribe the Event(Stopwatch Timer Elapse)
        private void SwEvent(object sender, ElapsedEventArgs e)
        {
            //Invoke : Apporaching method from Other Threads
            Invoke(new Action(() =>
            {
                second++;

                if (second == 60)
                {
                    second = 0;
                    minute++;
                }
                if (minute == 60)
                {
                    minute = 0;
                    hour++;
                }

                //Show the Elapsed Time
                ShowSwTime(hour, minute, second);
            }));
        }


        private void StopBtn_Click(object sender, EventArgs e)
        {
            swTimer.Stop();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            swTimer.Stop();
            ShowSwTime(hour = 0, minute = 0, second = 0);
        }

        private void ShowSwTime(int hour, int minute, int second)
        {
            StopWatchLabel.Text = String.Format("{0}:{1}:{2}",
                    hour.ToString().PadLeft(2, '0'),
                    minute.ToString().PadLeft(2, '0'),
                    second.ToString().PadLeft(2, '0'));
        }

        private void StopWatchLabel_Click(object sender, EventArgs e)
        {

        }
    }
}