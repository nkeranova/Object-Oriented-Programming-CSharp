namespace Students
{
    using System;

    public class Students
    {
        private string firstName;
        private string lastName;
        private int? age;


        public Students(string firstName, string lastName, int? age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (this.firstName.Length <= 0)
                {
                    throw new ArgumentException("First name of the student should be valid string! Cannot be null or empty!");
                }

                this.firstName = value;
            }
        }


        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (this.lastName.Length < 0)
                {
                    throw new ArgumentException("First name of the student should be valid string! Cannot be null or empty!");
                }

                this.lastName = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (this.age <= 0)
                {
                    throw new ArgumentException("The age of the student should be always positive number!");
                }

                this.age = value;
            }
        }
    }
}
