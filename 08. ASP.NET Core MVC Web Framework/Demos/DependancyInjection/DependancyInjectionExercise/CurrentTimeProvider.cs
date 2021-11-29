using System;

namespace DependancyInjectionExercise
{
    class CurrentTimeProvider : ICurrentTimeProvider
    {
        public DateTime Now() => DateTime.Now;
    }
}
