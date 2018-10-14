using System;
using System.Collections.Generic;

namespace ViewComponents.Models
{
    public class CheckBoxListViewModel
    {
        public CheckBoxListViewModel()
        {
            Items = new List<CheckBox>();
        }

        public List<CheckBox> Items { get; set; }

        public Guid Id { get; set; }
    }

    public class CheckBox
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Selected { get; set; }
    }
}
