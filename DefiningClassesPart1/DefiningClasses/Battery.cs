namespace DefiningClasses
{
    using System;
    using System.Text;

    class Battery
    {
        private BatteryType model;
        private int? hoursIdle;
        private int? hoursTalk;

        public Battery( BatteryType model, int hoursIdle, int hoursTalk)
        {
            
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        public BatteryType Model 
        { 
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public int? HoursIdle 
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (this.hoursIdle <= 0)
                {
                    throw new ArgumentException("Hours Idle should be always positive number!");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public int? HoursTalk 
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (this.hoursTalk <= 0)
                {
                    throw new ArgumentException("Hours Talk should be always positive number!");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            //TODO: write the format

            return output.ToString();
        }
    }
}
