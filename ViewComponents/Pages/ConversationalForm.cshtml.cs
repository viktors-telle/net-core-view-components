using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ViewComponents.Pages
{
    public class ConversationalFormModel : PageModel
    {
        static Random rnd = new Random();
        private List<string> _componentNames = new List<string>()
        {
            "RadioButtonList",
            "CheckBoxList"
        };


        public string ViewComponentName { get; set; }

        public Guid Id { get; set; }

        public void OnGet()
        {
            ViewComponentName = "RadioButtonList";
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Id = Guid.NewGuid();
            int r = rnd.Next(_componentNames.Count);
            ViewComponentName = _componentNames[r];
            return Page();
        }
    }
}