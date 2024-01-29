using System;

namespace Classes
{
    public class Stopwatch
    {
        private bool run = false;

        TimeSpan duration;
        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }

        public string Run(string res)
        {
            run = !run;
            if (res.ToLower() == "start" && run)
            {
                Start = DateTime.Now;
                return "Stop watch started running!";
            }
            else if(res.ToLower() == "stop" && !run)
            {
                Stop = DateTime.Now;
                duration = Stop - Start;
                return "Stop watch has now been stopped!\nThe Duration is : "+duration.Hours.ToString()+" Hours "+ duration.Minutes.ToString() + " Minutes "+ duration.Seconds.ToString() + " Seconds";
            }
            else
            {
                throw new InvalidOperationException();
            }
        }



    }
}
