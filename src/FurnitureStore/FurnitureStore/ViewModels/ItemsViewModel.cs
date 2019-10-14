using FurnitureStore.Models;
using MvvmHelpers;
using MvvmHelpers.Commands;
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
        private bool _inStock;

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
        
        public bool InStock
        {
            get { return _inStock; }
            set { SetProperty(ref _inStock, value); }
        }


        public IList<VariationViewModel> Variations { get; set; }

        public Command VariationSelectedCommand { get; set; }

        public ItemsViewModel(Item item)
        {
            Name = item.Name;
            Image = item.Variations.FirstOrDefault()?.Image;
            Price = item.Price;
            Code = item.ItemNumber;
            InStock = item.InStock;
            Description = item.Description;

            // instantiate our collection of Variations
            Variations = new ObservableRangeCollection<VariationViewModel>();
            foreach (var variation in item.Variations)
            {
                Variations.Add(new VariationViewModel(variation));
            }

            // set the first variation as the selected one
            var firstVariation = Variations.FirstOrDefault();
            firstVariation.IsSelected = true;

            VariationSelectedCommand = new Command<VariationViewModel>(VariationSelectedExecute);
        }

        private void VariationSelectedExecute(VariationViewModel obj)
        {
            foreach (var item in Variations)
            {
                item.IsSelected = false;
            }
            obj.IsSelected = true;
            this.Image = obj.Image;
        }
    }

}
