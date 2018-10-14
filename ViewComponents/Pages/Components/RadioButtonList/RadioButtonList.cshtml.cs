using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViewComponents.Models;

namespace ViewComponents.Pages
{
    public class RadioButtonListModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPost(RadioButtonListViewModel viewModel)
        {
            // TODO: Call service that will validate the input and save it somewhere.
            return RedirectToPage("../../ConversationalForm", new { id = viewModel.Id });
        }
    }
}