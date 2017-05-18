using Dao.IBatisConfig;
using Dao.IDao;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Dao
{
    public class UserDao : IUserDao
    {
        public int AddUser(HR_User user)
        {
            Object obj = Mapper.GetMaper.Insert("AddUser", user);
            return (int)obj;
        }

        
        public HR_User GetUser(int id)
        {
            return Mapper.GetMaper.QueryForObject<HR_User>("GetUserById", id);
        }

        public List<HR_User> GetUsers()
        {
            var list = Mapper.GetMaper.QueryForList<HR_User>("Dao.Mappers.ContentMapper.QueryAllUser", null) as List<HR_User>;
            return list;
        }
    }
}
