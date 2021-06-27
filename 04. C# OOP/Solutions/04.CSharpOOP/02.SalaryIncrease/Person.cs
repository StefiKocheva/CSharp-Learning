namespace _02.SalaryIncrease
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Age { get; private set; }

        public decimal Salary { get; private set; }

        public void IncreaseSalary(decimal percentage)
        {
            var increase = this.Salary * percentage / 100;

            this.Salary += this.Age < 30 ? increase / 2 : increase;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives  {this.Salary:f2} leva.";
        }
    }
}