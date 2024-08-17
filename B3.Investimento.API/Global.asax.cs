using System;
using System.Web;
using System.Web.Http;

namespace B3.Investimento.API
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            UnityConfig.RegisterComponents();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            // Redirecionar para o Swagger se a URL for a raiz
            if (HttpContext.Current.Request.Url.AbsolutePath == "/")
            {
                HttpContext.Current.Response.Redirect("/swagger");
            }
        }
    }
}
