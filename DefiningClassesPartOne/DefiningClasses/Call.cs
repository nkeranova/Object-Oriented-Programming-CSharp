namespace DefiningClasses
{
    using System;
    using System.Text;
    public class Call
    {
        public Call(DateTime date, TimeSpan time, string dialledPhoneNumber, int duration)
        {
            this.Date = date;
            this.Time = time;
            this.DialledPhoneNumber = dialledPhoneNumber;
            this.Duration = duration;
        }

        public DateTime Date { get; private set; }

        public TimeSpan Time { get; private set; }

        public string DialledPhoneNumber { get; private set; }

        public int Duration { get; private set; }

        public override string ToString()
        {
            var output = new StringBuilder();

            output.AppendLine("Date: " + this.Date);
            output.AppendLine("Time: " + this.Time);
            output.AppendLine("Dialed phone number: " + this.DialledPhoneNumber);
            output.AppendLine("Duration: " + this.Duration);

            return output.ToString();
        }
    }
}
