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
            string c = string.Format("Calling method {0} with parameters {1}... ",
             invocation.Method.Name,
             string.Join(", ", invocation.Arguments.Select(a => (a ?? "").ToString()).ToArray()));

            invocation.Proceed();

            string b = string.Format("Done: result was {0}.", invocation.ReturnValue);


        }
    }
}
