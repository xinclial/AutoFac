using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.IBatisConfig
{
    public class TestInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            invocation.Proceed();
            if (invocation.Method.Name == "GetI")
                invocation.ReturnValue = 1 + (int)invocation.ReturnValue;
        }
    }
}
