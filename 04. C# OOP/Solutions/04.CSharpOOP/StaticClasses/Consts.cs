namespace StaticClasses
{
    using System;

    public static class Consts // Something that wouldn't change its information and don't have to be any copies of it.
    {
        public const decimal PI = (decimal)Math.PI; // For example, there is no need to create an instance of this field.

        public const double G = 9.81;
    }
}
