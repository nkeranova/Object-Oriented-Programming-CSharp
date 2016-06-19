
using System;

namespace DefiningClasses
{
    public class Display
    {
        private double size;
        private int numberOfColors;

        public Display(double size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (this.size < 0)
                {
                    throw new ArgumentException("The display size must be bigger than 0!");
                }

                this.size = value;
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (this.numberOfColors < 0)
                {
                    throw new ArgumentException("The number of colors should be more than 0!");
                }

                this.numberOfColors = value;
            }
        }

    }
}
