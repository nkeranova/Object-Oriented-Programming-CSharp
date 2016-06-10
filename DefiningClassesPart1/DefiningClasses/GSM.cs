namespace DefiningClasses
{
    using System;
   
    class GSM
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;

        private static string IPhone4S;

        public GSM (string model, string manufacturer, decimal price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }

        public string Model 
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

        public string Manufacturer 
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }

        public decimal Price 
        { 
            get; 
            set; 
        }

        public string Owner 
        { 
            get; 
            set;
        }

        public string IPhone4S 
        { 
            get; 
            set;
        }

        public string CallHistory 
        { 
            get; 
            set; 
        }
    }
}
