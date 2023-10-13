using System.Diagnostics;

namespace CalendarTimer
{
    public partial class Form1 : Form
    {
        private Stopwatch stopwatch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Set Time as Current Time
            //Timer is necessary to display digital clock
            label1.Text = DateTime.Now.ToString("HH:mm:ss \n yyyy-MM-dd dddd");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}