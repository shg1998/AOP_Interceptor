using System;

namespace AOP_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            DependencyResolver.Initialize();

            var clock = DependencyResolver.For<IClock>();

            try
            {
                clock.SayCurrentTime();
            }
            catch (Exception ex)
            {

            }
            System.Console.ReadKey();

        }

    }

}
