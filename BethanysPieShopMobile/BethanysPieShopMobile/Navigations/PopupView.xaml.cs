using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile.Navigations
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupView : ContentPage
    {
        public PopupView()
        {
            InitializeComponent();
        }

        private async void btnSimpleA_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "You have been alerted", "OK");
        }

        private async void btnQAlert_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
            Debug.WriteLine("Users Answer: " + answer);
        }

        private async void btnMultiAlert_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Send With: ", "Cancel", null, "Email", "Twitter", "Facebook");
            Debug.WriteLine(action); //Could use a switch case
        }

        private async void btnInputAlert_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 1","You want to play?");
        }
    }
}