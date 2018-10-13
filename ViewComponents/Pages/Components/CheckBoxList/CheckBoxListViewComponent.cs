using Microsoft.AspNetCore.Mvc;

namespace ViewComponents.Pages.Components.RadioButtonList
{
    public class CheckBoxListViewComponent : ViewComponent
    {
        public CheckBoxListViewComponent() { }

        public IViewComponentResult Invoke(string value)
        {
            return View("Default", value);
        }
    }
}