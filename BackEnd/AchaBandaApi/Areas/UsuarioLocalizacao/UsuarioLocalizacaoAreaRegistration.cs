using System.Web.Mvc;

namespace AchaBandaApi.Areas.UsuarioLocalizacao
{
    public class UsuarioLocalizacaoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "UsuarioLocalizacao";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "UsuarioLocalizacao_default",
                "UsuarioLocalizacao/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}