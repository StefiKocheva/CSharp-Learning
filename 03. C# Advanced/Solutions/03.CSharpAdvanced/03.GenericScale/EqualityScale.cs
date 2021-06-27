﻿namespace _03.GenericScale
{
    public class EqualityScale<T>
    {
        private readonly T left;
        private readonly T right;

        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public bool AreEqual()
        {
            return this.left.Equals(this.right);
        }
    }
}
