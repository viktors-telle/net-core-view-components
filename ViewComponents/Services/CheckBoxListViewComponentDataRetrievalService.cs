using System;
using System.Collections.Generic;
using ViewComponents.Models;

namespace ViewComponents.Services
{
    public class CheckBoxListViewComponentDataRetrievalService : IViewComponentDataRetrievalService<List<CheckBox>>
    {
        public List<CheckBox> GetData(Guid id)
        {
            var items = new List<CheckBox>
            {
                new CheckBox()
                {
                    Id = "Glass",
                    Name = "Glass"
                },
                new CheckBox()
                {
                    Id = "Colision",
                    Name = "Colision"
                }
            };

            return items;
        }
    }
}
