﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BethanysPieShopMobile.Navigations;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile.Navigations
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPageView : MasterDetailPage
    {
        public MasterDetailPageView()
        {
            InitializeComponent();
        }
    }
}