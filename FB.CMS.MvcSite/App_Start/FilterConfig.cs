using System.Web;
using System.Web.Mvc;

namespace FB.CMS.MvcSite
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
        
    }

    public class LoginFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var cookies = HttpContext.Current.Request.Cookies["__ppa__"];

            if (cookies != null)
            {
                //登录
            }
            else
            {
                //跳转到登录页面
            }
        }
    }

}
