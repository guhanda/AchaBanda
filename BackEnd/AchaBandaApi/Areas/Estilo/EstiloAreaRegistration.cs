using System.Web.Mvc;

namespace AchaBandaApi.Areas.Estilo
{
    public class EstiloAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Estilo";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Estilo_default",
                "Estilo/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}