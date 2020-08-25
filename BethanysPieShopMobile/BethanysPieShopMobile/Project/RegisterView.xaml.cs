using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile.Project
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterView : ContentPage
    {
        public RegisterView()
        {
            InitializeComponent();
            BirthDayDatePicker.Date = DateTime.Now.Date;
            RegisterButton.IsEnabled = false;
        }

        private async void RegisterButton_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(UserNameEntry.Text) && !String.IsNullOrEmpty(Password.Text))
            {
                await DisplayAlert("Alert", "You have registered successfully", "OK");
            }
        }

        private async void BirthDayDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            if (BirthDayDatePicker.Date.Day == DateTime.Now.Day)
            {
                await DisplayAlert("Alert", "You weren't born today I guess", "OK");
            }
        }

        private void UserNameEntry_Completed(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(UserNameEntry.Text) && !String.IsNullOrEmpty(Password.Text))
            {
                RegisterButton.IsEnabled = true;
            }
        }

        private void Password_Completed(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(UserNameEntry.Text) && !String.IsNullOrEmpty(Password.Text))
            {
                RegisterButton.IsEnabled = true;
            }
        }
    }
}