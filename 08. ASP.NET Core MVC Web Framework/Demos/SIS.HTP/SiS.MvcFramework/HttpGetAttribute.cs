using SIS.HTTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.MvcFramework
{
    public class HttpGetAttribute : HttpMethodAttribute
    {
        public HttpGetAttribute()
        {
        }

        public HttpGetAttribute(string url)
            : base(url)
        {
        }

        public override HttpMethodType Type => HttpMethodType.Get;
    }
}
