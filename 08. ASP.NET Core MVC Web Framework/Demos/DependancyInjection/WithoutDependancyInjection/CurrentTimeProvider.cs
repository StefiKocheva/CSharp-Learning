namespace WithoutDependancyInjection
{
    using System;

    class CurrentTimeProvider : ICurrentTimeProvider
    {
        public DateTime Now() => DateTime.Now;
    }
}
