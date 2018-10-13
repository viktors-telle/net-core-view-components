﻿using Microsoft.AspNetCore.Mvc;

namespace ViewComponents.Pages.Components.RadioButtonList
{
    public class RadioButtonListViewComponent : ViewComponent
    {
        public RadioButtonListViewComponent() { }

        public IViewComponentResult Invoke(string value)
        {
            return View("Default", value);
        }
    }
}