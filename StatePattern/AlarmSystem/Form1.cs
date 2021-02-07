using System;
using System.Text;
using System.Windows.Forms;

namespace AlarmSystem
{
    public partial class Form1 : Form, Context
    {
        private State state = DayState.GetInstance();
        int hour = 0;
        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(Timer1_Tick);

            // Enable timer.  
            timer1.Enabled = true;
        }

        public void SetClock(int hour)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Current time: ");
            if (hour < 10)
            {
                sb.Append("0" + hour + ":00");
            }
            else
            {
                sb.Append(hour + ":00");
            }

            Console.WriteLine(sb.ToString());
            tbCurrentTime.Text = sb.ToString();
            state.DoClock(this, hour);

        }

        public void ChangeState(State state)
        {
            Console.WriteLine($"From {this.state.ToString()} to {state.ToString()}");
            this.state = state;
        }

        public void CallSecurityCenter(string msg)
        {
            tbContent.AppendText("Call! " + msg + Environment.NewLine);
        }

        public void RecordLog(string msg)
        {
            tbContent.AppendText("Record... " + msg + Environment.NewLine);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            SetClock(hour);
            UpdateHour();
        }

        private void UpdateHour()
        {
            hour++;
            if(hour >= 24)
            {
                hour = 0;
            }
        }

        private void btnUseCashbox_Click(object sender, EventArgs e)
        {
            state.DoUse(this);
        }

        private void btnUseAlarm_Click(object sender, EventArgs e)
        {
            state.DoAlarm(this);
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            state.DoPhone(this);
        }
    }
}
