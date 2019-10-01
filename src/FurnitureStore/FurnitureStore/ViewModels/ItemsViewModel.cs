using FurnitureStore.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FurnitureStore.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        private string name;
        private string image;
        private decimal price;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        public string Image
        {
            get { return image; }
            set { SetProperty(ref image, value); }
        }

        public decimal Price
        {
            get { return price; }
            set { SetProperty(ref price, value); }
        }

        public ItemsViewModel(Item item)
        {
            Name = item.Name;
            Image = item.Variations.FirstOrDefault()?.Image;
            Price = item.Price;
        }
    }

}
