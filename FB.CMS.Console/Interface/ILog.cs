using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FB.CMS.Console.Interface
{
    public interface ILog
    {
        int Id { get; set; }
        void Write();
    }
}
