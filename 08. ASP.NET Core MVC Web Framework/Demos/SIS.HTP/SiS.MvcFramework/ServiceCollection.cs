namespace SIS.MvcFramework
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class ServiceCollection : IServiceCollection // Dependency container - contains depandancies
    {
        private IDictionary<Type, Type> dependencyContainer =
            new ConcurrentDictionary<Type, Type>();

        public void Add<TSorce, TDestination>()
        {
            dependencyContainer[typeof(TSorce)] = typeof(TDestination);
        }

        public object CreateInstance(Type type)
        {
            if (dependencyContainer.ContainsKey(type))
            {
                type = dependencyContainer[type];
            }

            var constructor = 
                type.GetConstructors(BindingFlags.Public | BindingFlags.Instance)
                .OrderBy(x => x.GetParameters().Count()).FirstOrDefault();

            var parametersValues = new List<object>();

            foreach (var parameter in constructor.GetParameters())
            {
                var instance = CreateInstance(parameter.ParameterType);
                parametersValues.Add(instance);
            }

            return constructor.Invoke(parametersValues.ToArray());
        }

        public T CreateInstance<T>()
        {
            return (T)this.CreateInstance(typeof(T));
        }
    }
}