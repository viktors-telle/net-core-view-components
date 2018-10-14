using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ViewComponents.Models;
using ViewComponents.Services;

namespace ViewComponents.Pages.Components.RadioButtonList
{
    public class CheckBoxListViewComponent : ViewComponent
    {
        private readonly IViewComponentDataRetrievalService<List<CheckBox>> _viewComponentDataRetrievalService;

        public CheckBoxListViewModel ViewModel { get; set; }

        public CheckBoxListViewComponent(IViewComponentDataRetrievalService<List<CheckBox>> viewComponentDataRetrievalService)
        {
            _viewComponentDataRetrievalService = viewComponentDataRetrievalService;
        }

        public IViewComponentResult Invoke(Guid id)
        {
            // TODO: Inject service and call it to fetch data.
            var items = _viewComponentDataRetrievalService.GetData(id);
            ViewModel = new CheckBoxListViewModel
            {
                Id = id,
                Items = items
            };
            
            return View("Default", ViewModel);
        }
    }   
}