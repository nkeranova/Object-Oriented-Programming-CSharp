namespace DefiningClasses
{
    using System;
    using System.Text;

    class Battery
    {
        private BatteryType model;
        private int? hoursIdle;
        private int? hoursTalk;
        private BatteryType batteryType;

        public Battery( BatteryType model, int hoursIdle, int hoursTalk)
        {
            
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public BatteryType Model { get; set; }

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

        public BatteryType BatteryType { get; set; }

        public override string ToString()
        {
            var output = new StringBuilder();

            //TODO: write the format
            output.AppendLine("Model: " + this.Model);
            output.AppendLine("Hours Iddle: " + this.HoursIdle);
            output.AppendLine("Hours Talk: " + this.HoursTalk);
            output.AppendLine("Type: " + this.BatteryType);

            return output.ToString();
        }
    }
}
