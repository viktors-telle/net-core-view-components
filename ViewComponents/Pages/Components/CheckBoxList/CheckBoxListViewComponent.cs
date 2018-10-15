using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ViewComponents.Models;
using ViewComponents.Services;

namespace ViewComponents.Pages.Components.CheckBoxList
{
    public class CheckBoxListViewComponent : ViewComponent
    {
        private readonly IViewComponentDataRetrievalService<List<CheckBox>, Guid> _viewComponentDataRetrievalService;

        public CheckBoxListViewModel ViewModel { get; set; }

        public CheckBoxListViewComponent(IViewComponentDataRetrievalService<List<CheckBox>, Guid> viewComponentDataRetrievalService)
        {
            _viewComponentDataRetrievalService = viewComponentDataRetrievalService;
        }

        public IViewComponentResult Invoke(Guid id)
        {
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