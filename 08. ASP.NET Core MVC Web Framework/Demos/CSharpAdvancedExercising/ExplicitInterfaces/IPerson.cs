﻿namespace ExplicitInterfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IPerson
    {
        string Name
        {
            get;
            set;
        }
        string Age
        {
            get;
            set;
        }

        public string GetName();
    }
}
