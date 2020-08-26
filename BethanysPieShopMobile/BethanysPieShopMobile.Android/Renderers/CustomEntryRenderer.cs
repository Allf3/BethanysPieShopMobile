using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using BethanysPieShopMobile.Droid.Renderers;
using BethanysPieShopMobile.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

//CustomeEntry = Oppe i Shared Folder, Her definere vi den i det indeviuelle Nativ app
//Opgave 7 CustomeRenderer
[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace BethanysPieShopMobile.Droid.Renderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            Control?.SetBackgroundColor(Android.Graphics.Color.WhiteSmoke);
        }
    }
}