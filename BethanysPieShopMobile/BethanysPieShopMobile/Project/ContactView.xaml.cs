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
    public partial class ContactView : ContentPage
    {
        private bool toggled = false;

        public ContactView()
        {
            InitializeComponent();
        }

        private void ContactMeSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            toggled = true;
        }

        private void SendMessageButton_Clicked(object sender, EventArgs e)
        {
            if (toggled)
            {
                DisplayAlert("Success", "Message sent successfully, you will recieve an message from us", "Done");
            }
            DisplayAlert("Success", "Message sent successfully", "Done");
        }
    }
}