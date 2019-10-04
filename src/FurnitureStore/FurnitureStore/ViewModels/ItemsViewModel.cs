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
        private string description;
        private string code;

        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        public string Description
        {
            get { return description; }
            set { SetProperty(ref description, value); }
        }

        public string Code
        {
            get { return code; }
            set { SetProperty(ref code, value); }
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
            Code = item.ItemNumber;
            Description = item.Description;
        }
    }

}
