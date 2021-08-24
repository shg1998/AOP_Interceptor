using System;

namespace AOP_Example
{
    public class Clock: IClock
    {
        //[ExampleAspect]
        public void SayCurrentTime()
        {
            Console.WriteLine(DateTime.Now);
        }

        //[ExampleAspect]
        public void SayIfThisIsALeapYear()
        {
            Console.WriteLine("is this a leap year: " + DateTime.IsLeapYear(DateTime.Now.Year));
        }

    }
}
