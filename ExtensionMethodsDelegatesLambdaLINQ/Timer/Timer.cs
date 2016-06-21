
namespace Timer
{
    using System;
    using System.Threading;

    public delegate void TimerDelegate();

    public class Timer
    {
        private TimerDelegate timer;
        private int seconds;

        public Timer(int seconds)
        {
            this.Seconds = seconds;
        }

        public int Seconds
        {
            get
            {
                return this.seconds;
            }
            set
            {
                if (this.seconds <= 0)
                {
                    throw new ArgumentException("The time in seconds must be more than 0!");
                }

                this.seconds = value;
            }
        }

        public void RunTimer()
        {
            while (this.seconds > 0)
            {
                Thread.Sleep(this.seconds);
                this.Seconds++;
                timer();
            }
        }

    }
}
/*
 public void RunTimer()
        {
            TimerDelegate t = delegate(int time)
            {
                while (true)
                {
                    Thread.Sleep(time);
                    Console.WriteLine(DateTime.Now);
                }
            };

            t(1000);
        }
*/