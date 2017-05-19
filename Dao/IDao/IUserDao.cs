using Autofac.Extras.DynamicProxy;
using Dao.IBatisConfig;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.IDao
{
    [Intercept(typeof(TestInterceptor))]
    public interface IUserDao
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        int AddUser(HR_User user);



        /// <summary>
        /// 获取用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        HR_User GetUser(int id);

        List<HR_User> GetUsers();
    }
}
