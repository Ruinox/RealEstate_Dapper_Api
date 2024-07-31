using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace RealEstate_Dapper_UI.ViewComponents.HomePage
{
    public class _DefaultBrandComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
            { return View(); }
    }
}
