using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViewComponents.Extensions;

namespace ViewComponents.Pages
{
    public class ConversationalFormModel : PageModel
    {
        private readonly List<string> _componentNames = new List<string>()
        {
            "CheckBoxList",
            "RadioButtonList"
        };

        public string ViewComponentName { get; set; }

        public Guid Id { get; set; }

        public void OnGet(Guid id)
        {
            if (id == Guid.Empty)
            {
                Id = Guid.NewGuid();
            }

            // TODO: Fetch next component from service.
            ViewComponentName = GetNextComponent();
        }

        private string GetNextComponent()
        {
            return _componentNames.RandomElement();
        }
    }
}