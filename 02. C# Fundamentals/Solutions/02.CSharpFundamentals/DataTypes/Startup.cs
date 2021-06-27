namespace DataTypes
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            // Text type
            string text = "Hello";

            //Character type
            char character = 'a';

            //Boolean type
            bool isTrue = false;

            // Integer types
            sbyte integer1 = 1; // -128 to 127 (8 bit)

            byte integer2 = 1; // 0 to 255 (8 bit)
            
            short integer3 = 1; // -32768 to 32767 (16 bit)
            
            ushort integer4 = 1; // 0 to 65535 (16 bit)
            
            int integer5 = 1; // -2147483648 to 2147483647 (32 bit)

            uint integer6 = 1; // 0 to 4294967295 (32 bit)

            long integer7 = 1; // -9223372036854775808 to 9223372036854775807 (64 bit)

            ulong integer8 = 1; // 0 to 18446744073709551615 (64 bit)

            // Real numbet types
            float number1 = 1.0f; // Suffix - f, precision of 7 digits

            double number2 = 1.0d; // Suffix - d (no need), precision of 15-16 digits

            decimal number = 1.0m; // Suffix - m, precision of 28-29 digits

            // Implicit type conversion
            float height = 1.74f;

            double maxHeight = height;

            // Explicit type conversion

            double size = 3.64;

            int intSize = (int) size; // Using a cast (3)

        }
    }
}
