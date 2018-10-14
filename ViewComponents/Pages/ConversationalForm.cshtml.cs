using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ViewComponents.Pages
{
    public class ConversationalFormModel : PageModel
    {
        public string ViewComponentName { get; set; }

        public Guid Id { get; set; }

        public void OnGet(Guid id)
        {
            if (id == Guid.Empty)
            {
                Id = Guid.NewGuid();
            }

            // TODO: Fetch next component from service.
            ViewComponentName = "CheckBoxList";
        }
    }
}