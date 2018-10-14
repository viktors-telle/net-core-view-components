using System;
using System.Collections.Generic;
using ViewComponents.Models;

namespace ViewComponents.Services
{
    public class RadioButtonListViewComponentDataRetrievalService : IViewComponentDataRetrievalService<List<RadioButton>, Guid>
    {
        public List<RadioButton> GetData(Guid id)
        {
            var items = new List<RadioButton>
            {
                new RadioButton
                {
                    Id = "First",
                    Name = "First choice"
                },

                new RadioButton
                {
                    Id = "Second",
                    Name = "Second choice"
                },

                new RadioButton
                {
                    Id = "Third",
                    Name = "Third choice"
                }
            };

            return items;
        }
    }
}
