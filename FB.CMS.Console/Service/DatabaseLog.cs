using FB.CMS.Console.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FB.CMS.Console.Service
{
    public class DatabaseLog : ILog
    {
        #region ILog 成员

        public int Id { get; set; }

        public void Write()
        {
            System.Console.WriteLine("Id:" + Id + "    Log to database...");
        }

        #endregion
    }
}
