using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureStore.Models
{
    public class Category
    {
        public string Name { get; set; }
        public List<Item> Items { get; set; }

    }
}
