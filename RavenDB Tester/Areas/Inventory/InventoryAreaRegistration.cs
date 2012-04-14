using System.Web.Mvc;

namespace RavenDB.Areas.Inventory
{
    public class InventoryAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Inventory";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
            "Inventory_default",
            "Inventory/{controller}/{action}/{id}",
            new { action = "Index", id = UrlParameter.Optional });

            context.MapRoute(
                "Inventory",
                "Inventory",
                new { controller = "Inventory", action = "Index" }, new[] { "RavenDB.Areas.Inventory.Controllers" });
        }
    }
}
