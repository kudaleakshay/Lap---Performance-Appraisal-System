using System;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using System.Web.Routing;
using Performance_Appraisal_System.Models;

namespace Performance_Appraisal_System.Infrastructure
{
    public class CustomAuthenticationFilter : ActionFilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            User user = (User)filterContext.HttpContext.Session["User"];

            if (user != null)
            {
                var UserName = user.UserName;
                if (string.IsNullOrEmpty(Convert.ToString(UserName)))
                {
                    filterContext.Result = new HttpUnauthorizedResult();
                }
            }
            else
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            if (filterContext.Result == null || filterContext.Result is HttpUnauthorizedResult)
            {
                //Redirecting the user to the Login View of Account Controller  
                filterContext.Result = new RedirectToRouteResult(
                new RouteValueDictionary
                {
                     { "controller", "Account" },
                     { "action", "Login" }
                });
            }
        }
    }
}