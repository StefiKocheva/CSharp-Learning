using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.MvcFramework
{
    public class HttpPostAttribute : HttpMethodAttribute
    {
        public HttpPostAttribute()
        {

        }

        public HttpPostAttribute(string url)
            : base(url)
        {
        }

        public override HttpMethodType Type => HttpMethodType.post;
    }
}
