namespace SIS.HTTP
{
    public class Cookie // Attributes of the cookie.
    {
        public Cookie(string name, string value) // There should be always set name and value of the cookie to be valid.
        {
            this.Name = name;
            this.Value = value;
        }

        public string Name { get; set; } // Name of the cookie.

        public string Value { get; set; } // Value that has the cookie.
    }
}