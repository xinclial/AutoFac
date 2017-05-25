using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FB.CMS.IService;
using FB.CMS.Service.Service;
using FB.CMS.IService.IService;

namespace FB.CMS.MvcSite.Controllers
{
    [LoginFilter(Order = 10)]
    public class HomeController : Controller
    {
        I_t_Case_Main_Service dal;
        public HomeController(I_t_Case_Main_Service dal) //依赖构造函数进行对象注入  
        {
            this.dal = dal; //在构造函数中初始化HomeController控制器类的dal属性 （这个dal属性的类型是IsysFunctionServices）  
        }

        [LoginFilter(Order = 10)]
        public ActionResult Index()
        {
            var a = dal.GetIQueryable().Take(100).ToList();
            return View();
        }
    }
}