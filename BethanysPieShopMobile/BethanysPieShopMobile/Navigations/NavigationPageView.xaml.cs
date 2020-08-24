using BethanysPieShopMobile.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile.Navigations
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPageView : ContentPage
    {
        public NavigationPageView()
        {
            InitializeComponent();
        }

        private async void btnBasket_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BasketView());
        }

        private async void btnContactUs_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactusView());
        }

        private async void btnHomePage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePageView());
        }

        private async void btnPieOverview_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PieOverviewView());
        }
    }
}