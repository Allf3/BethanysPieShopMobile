using BethanysPieShopMobile.Models;
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
    public partial class PieDetailView : ContentPage
    {
        public PieDetailView()
        {
            InitializeComponent();
            Pie pie = new Pie
            {
                Id = 1,
                Description =
                "Gingerbread jujubes donut. Gummies cake halvah. Jujubes candy canes pudding cupcake ice cream bonbon chocolate bar. Pudding apple pie carrot cake lollipop. Caramels sugar plum muffin croissant cake dragée carrot cake jelly-o cotton candy. Jelly beans chocolate pie bear claw donut sesame snaps. Carrot cake tart sweet gummies. Lollipop cotton candy muffin marshmallow chocolate bar danish. Tart donut fruitcake. Toffee candy danish chocolate danish toffee chocolate bar. Ice cream chocolate cake gingerbread. Brownie tootsie roll cotton candy cookie bear claw cheesecake cupcake lollipop apple pie.",
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                InStock = true,
                PieName = "Apple pie",
                Price = 20.95
            };

            BindData(pie);
        }

        private void BindData(Pie pie)
        {
            PieNameLabel.Text = pie.PieName;
            PieImage.Source = pie.ImageUrl;
            PriceLabel.Text = String.Format("${0}", pie.Price.ToString());
            InStockLabel.Text = (pie.InStock == true) ? "In stock" : "Not in stock";
            DescriptionLabel.Text = pie.Description;
        }

        private async void AddToBasketButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Success", "Pie added to basket!", "DONE");
        }
    }
}