namespace Encapsulation
{
    using System;

    public class Person
    {
        private int age;

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Age 
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 18)
                {
                    throw new ArgumentException("You should be above 18.");
                }

                this.age = value;
            }
        }

        // It's not okay if you can change the value of the salary.
        public decimal Salary { get; private set; }
    }
}
