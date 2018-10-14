using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViewComponents.Models;

namespace ViewComponents.Pages
{
    public class CheckBoxListModel : PageModel
    {
        // TODO: Inject configuration via IOptions<> interface.
        public void OnGet()
        {           
        }

        public IActionResult OnPost(CheckBoxListViewModel viewModel)
        {
            // TODO: Call service that will validate the input and save it somewhere.
            return RedirectToPage("../../ConversationalForm", new { id = viewModel.Id });
        }
    }
}