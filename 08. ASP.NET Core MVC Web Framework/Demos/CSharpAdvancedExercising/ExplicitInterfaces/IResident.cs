﻿namespace ExplicitInterfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IResident
    {
        string Name
        {
            get;
            set;
        }
        string Country
        {
            get;
            set;
        }
        public string GetName();
    }
}
