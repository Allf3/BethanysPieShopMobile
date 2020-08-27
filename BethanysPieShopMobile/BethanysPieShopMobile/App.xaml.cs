using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BethanysPieShopMobile.Navigations;
using BethanysPieShopMobile.Project;

namespace BethanysPieShopMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new NavigationPageView());
            //MainPage = new TabbedPageView();
            //MainPage = new MasterDetailPageView();
            //MainPage = new CarouselPageView();
            //MainPage = new ModalPageView();
            //MainPage = new LoginWithStackLayout();
            //MainPage = new LoginView();
            //MainPage = new RegisterView();
            //MainPage = new ContactView();
            //MainPage = new WebPageView();
            //MainPage = new WebPageView();
            //MainPage = new SettingsView();
            //MainPage = new PieDetailView();
            //MainPage = new PieDetailPage2();
            //MainPage = new NavigationPage(new PieOverviewView());
            var alreadyRegistered = false;
            if (alreadyRegistered)
                MainPage = new MainView();
            else
                MainPage = new NavigationPage(new LoginView()) { BarBackgroundColor = (Color)Application.Current.Resources["PageBackgroundColor"] };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
