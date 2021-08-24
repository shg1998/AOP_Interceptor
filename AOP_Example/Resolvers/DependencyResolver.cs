using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOP_Example
{
    public class DependencyResolver
    {
        private static IWindsorContainer _container;

        //Initialize the container
        public static void Initialize()
        {
            _container = new WindsorContainer();
            _container.Register(new ClockRegistration());
        }

        //Resolve types
        public static T For<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
