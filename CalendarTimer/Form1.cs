using Microsoft.Toolkit.Uwp.Notifications;
using System.Diagnostics;
using System.Timers;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
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
        private int aHour;
        private int aMinute;
        private string meridiem;
        private string dt;
        private string aDescription;
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
            for (int i = 0; i < 60; i++)
            {
                if (i >= 1 && i <= 12)
                {
                    HourBox.Items.Add(i.ToString().PadLeft(2, '0'));
                }
                MinuteBox.Items.Add(i.ToString().PadLeft(2, '0'));
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_tick(object sender, EventArgs e)
        {
            //Set Time as Current Time
            //Timer is necessary to display digital clock
            CurTime.Text = DateTime.Now.ToString("hh:mm:ss tt \n yyyy-MM-dd dddd");
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


        private void CreateBtn_Click(object sender, EventArgs e)
        {
            aHour = Int32.Parse(HourBox.Text);
            aMinute = Int32.Parse(MinuteBox.Text);
            meridiem = MeridiemBox.Text;
            aDescription = DescriptionBox.Text;
            dt = DateTimePicker1.Text;
            string dYear = DateTimePicker1.Value.Year.ToString();
            string dMonth = DateTimePicker1.Value.Month.ToString();
            string dDay = DateTimePicker1.Value.Day.ToString();

            string aTime = dMonth + "/" + dDay + "/" + dYear + " " +
                aHour.ToString().PadLeft(2, '0') + ":" + 
                aMinute.ToString().PadLeft(2, '0') + " "
                + meridiem;
            string alarmEvent = aTime + "(" + aDescription + ")";

            if(DateTime.Parse(aTime) > DateTime.Now) { 
                AlarmListBox.Items.Add(alarmEvent);

                //ToastContentBuilder : Used to notify clock alarm
                //You must set Properties First 
                //NET Framework version must be >= 7.0
                //OS version must support >= 10.0.17763.0
                //It is used to alert the event
                new ToastContentBuilder()
                    .SetToastScenario(ToastScenario.Alarm)
                    .AddText(aDescription)
                    .Schedule(DateTime.Parse(aTime));
            } else {
                MessageBox.Show("You input an invalid time!", "Error!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            AlarmListBox.Items.RemoveAt(AlarmListBox.SelectedIndex);
        }


        private void ClearBtn_Click(object sender, EventArgs e)
        {
            AlarmListBox.Items.Clear();
        }

        private void MeridiemBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}