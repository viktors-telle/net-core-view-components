using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ViewComponents.Models;

namespace ViewComponents.Pages.Components.RadioButtonList
{
    public class RadioButtonListViewComponent : ViewComponent
    {
        public RadioButtonListViewModel ViewModel { get; set; }

        public RadioButtonListViewComponent() { }        

        public IViewComponentResult Invoke(Guid id)
        {
            ViewModel = new RadioButtonListViewModel
            {
                Id = id,
                Items = new List<RadioButton>()
            };

            ViewModel.Items.Add(new RadioButton
            {
                Id = "First",
                Name = "First choice"
            });

            ViewModel.Items.Add(new RadioButton
            {
                Id = "Second",
                Name = "Second choice"
            });

            ViewModel.Items.Add(new RadioButton
            {
                Id = "Third",
                Name = "Third choice"
            });

            return View("Default", ViewModel);
        }
    }
}