namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
   
    class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;

        private static string IPhone4S;

        public GSM (string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = null;
            this.Display = null;

        }

        public string Model 
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The phone should have valid model name. Cannot be null or empty!");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Manufacturer 
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The phone must have valid manufacturer. Cannot be null or empty!");
                }
                else
                {
                    this.manufacturer = value;
                }
               
            }
        }

        public decimal? Price 
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price of the phone must be possitive number!");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner { get; set; }

        public List<Call> CallHistory { get; private set; }

        public Battery Battery { get; private set; }
                                       
        public Display Display { get; private set; }
                                       
        public string IPhone4S { get; private set; }

        public void AddCall(Call currentCall)
        {
            CallHistory.Add(currentCall); // this.callHistory.Add(currentCall);
        }

        public void DeleteCall(Call currentCall)
        {
            CallHistory.Remove(currentCall);
        }

        public void ClearCall(Call currentCall)
        {
            CallHistory.Clear();
        }

        public decimal CalculateTotalPrice(decimal price)
        {
            decimal allCallsInSecs = (decimal)(this.CallHistory.Select(x => x.Duration).Sum());
            return price * (allCallsInSecs / 60.0m);
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            output.AppendLine("Model: " + this.Model);
            output.AppendLine("Manufacture: " + this.Manufacturer);
            output.AppendLine("Price: " + this.Price);
            output.AppendLine("Owner: " + this.Owner);
            output.AppendLine("Battery: " + this.Battery);
            output.AppendLine("Display: " + this.Display);
 
            return output.ToString();
        }
    }
}
