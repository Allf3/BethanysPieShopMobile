using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile.Helpers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LargeImagePageView : ContentPage
    {
        public LargeImagePageView()
        {
            InitializeComponent();
        }

        private async void BtnCloseImg_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}