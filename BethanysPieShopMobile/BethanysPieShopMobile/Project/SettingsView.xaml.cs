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
    public partial class SettingsView : ContentPage
    {
        public SettingsView()
        {
            InitializeComponent();
            LanguagePickerData(); //ItemSourceinit
        }

        private void LanguagePickerData()
        {
            LanguagePickerFromCode.ItemsSource = new List<string> { "English","Dutch","French","German" };
        }

        private void PieBudgetSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            PieBudgetSlider.Value = value;
            PieBudgetLabel.Text = String.Format("${0}", value);
        }

        private async void SaveSettingsButton_Clicked(object sender, EventArgs e)
        {
            ActivityPie.IsRunning = true;
            await Task.Delay(2000); //2SEK
            ActivityPie.IsRunning = false;

            await DisplayAlert("Success", "Your settings have been saved!", "Done");
        }
    }
}