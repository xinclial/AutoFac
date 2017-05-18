using Dao.Dao;
using Dao.IDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbatisConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserDao user = new UserDao();

            var list = user.GetUsers();

        }
    }
}
