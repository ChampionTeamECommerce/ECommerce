﻿

using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors
{
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; }//öncelik belirleme

        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}

