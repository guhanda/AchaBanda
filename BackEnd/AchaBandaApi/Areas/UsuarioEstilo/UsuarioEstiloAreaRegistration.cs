using System.Web.Mvc;

namespace AchaBandaApi.Areas.UsuarioEstilo
{
    public class UsuarioEstiloAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "UsuarioEstilo";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "UsuarioEstilo_default",
                "UsuarioEstilo/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}