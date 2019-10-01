using FurnitureStore.Models;
using FurnitureStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FurnitureStore
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetailsPage : ContentPage
    {
        private object selectedItem;

        public ProductDetailsPage()
        {
            InitializeComponent();
        }
        public ProductDetailsPage(ItemsViewModel selectedItem)
        {
            this.selectedItem = selectedItem;
            this.Title = selectedItem.Name;
        }
    }
}