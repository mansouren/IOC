using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    public class Resolver //Asp.net Core Ioc Container
    {
        private Dictionary<Type, Type> dependencyMap = new Dictionary<Type, Type>();

        public T Resolve<T>()
        {
            return (T)Resolve(typeof(T));  
        }

        private object Resolve(Type typeToResolve) //typeToResolve is interface
        {
            Type resolvedType; //Implementation Class
            if(!dependencyMap.TryGetValue(typeToResolve,out resolvedType))
            {
                throw new Exception("Could not reolve type {0}" + typeToResolve.FullName);
            }

            var firstConstructor = resolvedType.GetConstructors().First(); //Get Constructors of implementation Class
            var constructorParameters = firstConstructor.GetParameters(); // Get Constructor's Parameters

            if (!constructorParameters.Any()) //If constructor does not have parameters, it will create an instance of resolvedType
                Activator.CreateInstance(resolvedType);

            var parameters = new List<object>();
            foreach (var parameter in constructorParameters)
            {
                parameters.Add(Resolve(parameter.ParameterType)); //Calling Resolve method  recursively
            }

            return firstConstructor.Invoke(parameters.ToArray());
        }

        public void Register<TFrom,TTo>()
        {
            dependencyMap.Add(typeof(TFrom), typeof(TTo));
        }
    }
}
