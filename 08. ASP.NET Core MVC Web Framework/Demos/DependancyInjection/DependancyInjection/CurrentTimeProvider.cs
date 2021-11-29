namespace DependancyInjection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CurrentTimeProvider : ICurrentTimeProvider
    {
        public DateTime Now() => DateTime.Now;
    }
}
