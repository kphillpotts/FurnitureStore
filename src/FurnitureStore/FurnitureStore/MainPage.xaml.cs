using FurnitureStore.Models;
using FurnitureStore.ViewModels;
using Plugin.SharedTransitions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
            MyCarousel.PositionChanged += MyCarousel_PositionChanged;
            MyCarousel.CurrentItemChanged += MyCarousel_CurrentItemChanged;
        }

        private void MyCarousel_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            Debug.WriteLine($"Current Item Changed {e.CurrentItem}");
        }

        private void MyCarousel_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            Debug.WriteLine($"Position Changed {e.CurrentPosition}");
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            // get the position
            //var position = MyCarousel.Position;
            var selectedItem = MyCarousel.CurrentItem as ItemsViewModel;
            if (selectedItem == null)
                System.Diagnostics.Debug.WriteLine("Can't get current item");
            else
            {
                SharedTransitionNavigationPage.SetTransitionSelectedGroup(this, selectedItem.Name);
                Navigation.PushAsync(new ProductDetailsPage(selectedItem));
            }

        }
    }
}
