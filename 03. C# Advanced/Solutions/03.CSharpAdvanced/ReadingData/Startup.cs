namespace ReadingData
{
    using System;
    using System.IO;
    using System.Threading.Tasks;

    public static class Startup
    {
        public static void Main()
        {
            var person = new Person();

            using var reader = new StreamReader("test.txt"); // Open a reader and start using it.

            person.FirstName = reader.ReadLine(); // Gets line from the file.
            person.LastName = reader.ReadLine();
            person.Age = int.Parse(reader.ReadLine());

            //var text = reader.ReadToEnd(); - Get all the text in the file.

            //Console.WriteLine(text);
            Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} yo.");
        }
    }
}
