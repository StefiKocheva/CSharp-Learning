namespace SIS.MvcFramework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IServiceCollection // Container interface
    {
        void Add<TSorce, TDestination>();
            // where TDestination : TSorce;

        object CreateInstance(Type type);

        T CreateInstance<T>();
    }
}
