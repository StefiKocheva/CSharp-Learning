using System.Text;

namespace Animals
{
    using System;

    public class Animal
    {

        private string name;
        private int age;
        private string gender;

        public string AnimalType { get; set; }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (char.IsDigit(this.name[0]) == true)
                {
                    throw new ArgumentException("Invalid input!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (this.age > 0)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException("Invalid input!");
                }
            }
        }
        public string Gender
        {
            get { return this.gender; }
            set
            {
                if (this.gender == "Male" || this.gender == "Female")
                {
                    this.gender = value;
                }
                else
                {
                    throw new ArgumentException("Invalid input!");
                }
            }
        }

        public virtual string ProduceSound()
        {
            return "";
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(this.GetType().Name);
            stringBuilder.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            stringBuilder.AppendLine($"{this.ProduceSound()}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
