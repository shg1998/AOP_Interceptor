using System;
using System.Collections.Generic;
using System.Text;
using AOP_Example.Interceptors;
using Castle.Core;
using Castle.MicroKernel;
using Castle.MicroKernel.Registration;

namespace AOP_Example
{
    class ClockRegistration : IRegistration
    {
        public void Register(IKernelInternal kernel)
        {
            kernel.Register(
                Component.For<LogginInterceptor>()
                    .ImplementedBy<LogginInterceptor>());

            kernel.Register(
                Component.For<IClock>()
                         .ImplementedBy<Clock>()
                         .Interceptors(InterceptorReference.ForType<LogginInterceptor>()).Anywhere);
        }
    }
}
