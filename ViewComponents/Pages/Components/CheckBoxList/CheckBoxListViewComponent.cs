using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ViewComponents.Models;

namespace ViewComponents.Pages.Components.RadioButtonList
{
    public class CheckBoxListViewComponent : ViewComponent
    {
        public CheckBoxListViewModel ViewModel { get; set; }

        public CheckBoxListViewComponent() { }

        public IViewComponentResult Invoke(Guid id)
        {
            // TODO: Inject service and call it to fetch data.
            ViewModel = new CheckBoxListViewModel
            {
                Id = id,
                Items = new List<CheckBox>()
            };
            ViewModel.Items.Add(new CheckBox()
            {
                Id = "Glass",
                Name = "Glass"
            });
            ViewModel.Items.Add(new CheckBox()
            {
                Id = "Colision",
                Name = "Colision"
            });
            return View("Default", ViewModel);
        }
    }   
}