using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ViewComponents.Models;
using ViewComponents.Services;

namespace ViewComponents.Pages.Components.RadioButtonList
{
    public class RadioButtonListViewComponent : ViewComponent
    {
        private readonly IViewComponentDataRetrievalService<List<RadioButton>> _viewComponentDataRetrievalService;

        public RadioButtonListViewModel ViewModel { get; set; }

        public RadioButtonListViewComponent(IViewComponentDataRetrievalService<List<RadioButton>> viewComponentDataRetrievalService)
        {
            _viewComponentDataRetrievalService = viewComponentDataRetrievalService;
        }        

        public IViewComponentResult Invoke(Guid id)
        {
            var items = _viewComponentDataRetrievalService.GetData(id);
            ViewModel = new RadioButtonListViewModel
            {
                Id = id,
                Items = items
            };           

            return View("Default", ViewModel);
        }
    }
}