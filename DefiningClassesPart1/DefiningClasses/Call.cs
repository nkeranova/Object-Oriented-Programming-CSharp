namespace DefiningClasses
{
    using System;

    class Call
    {
        private DateTime date;
        private DateTime time;
        private string dialledPhoneNumber;
        private int duration;

        public Call(DateTime date, DateTime time, string dialledPhoneNumber, int duration)
        {
            this.date = date;
            this.time = time;
            this.dialledPhoneNumber = dialledPhoneNumber;
            this.duration = duration;
        }

        public DateTime Date 
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public DateTime Time 
        { 
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }
        }

        public string DialledPhoneNumber 
        {
            get
            {
                return this.dialledPhoneNumber;
            }
            set
            {
                this.dialledPhoneNumber = value;
            }
        }

        public int Duration 
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }
    }
}
