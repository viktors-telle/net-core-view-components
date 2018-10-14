using Microsoft.AspNetCore.Mvc;
using System;

namespace ViewComponents.Pages.Components.RadioButtonList
{
    public class RadioButtonListViewComponent : ViewComponent
    {
        public RadioButtonListViewComponent() { }

        public IViewComponentResult Invoke(Guid id)
        {
            return View("Default");
        }
    }
}