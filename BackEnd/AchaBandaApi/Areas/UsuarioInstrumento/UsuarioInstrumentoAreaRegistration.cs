using System.Web.Mvc;

namespace AchaBandaApi.Areas.UsuarioInstrumento
{
    public class UsuarioInstrumentoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "UsuarioInstrumento";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "UsuarioInstrumento_default",
                "UsuarioInstrumento/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}