using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FB.CMS.IService;

namespace FB.CMS.MvcSite.Controllers
{
    
    public class HomeController : Controller
    {
        IsysFunctionServices dal;
        public HomeController(IsysFunctionServices dal) //依赖构造函数进行对象注入  
        {
            this.dal = dal; //在构造函数中初始化HomeController控制器类的dal属性 （这个dal属性的类型是IsysFunctionServices）  
        }

        public ActionResult Index()
        {
            var a = dal.QueryWhere(r => r.fID > 20).ToList(); //查询  
            return View();
        }
    }
}