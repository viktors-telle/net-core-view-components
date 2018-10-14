using System;
using System.Collections.Generic;

namespace ViewComponents.Models
{
    public class RadioButtonListViewModel
    {
        public Guid Id { get; set; }

        public List<RadioButton> Items { get; set; }

        public string SelectedItem { set; get; }
    }

    public class RadioButton
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
