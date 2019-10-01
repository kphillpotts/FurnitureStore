using FurnitureStore.Models;
using FurnitureStore.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FurnitureStore
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            // get the position
            //var position = MyCarousel.Position;
            var selectedItem = MyCarousel.CurrentItem as ItemsViewModel;
            if (selectedItem == null)
                System.Diagnostics.Debug.WriteLine("Can't get current item");
            else
                Navigation.PushAsync(new ProductDetailsPage(selectedItem));

        }
    }
}
