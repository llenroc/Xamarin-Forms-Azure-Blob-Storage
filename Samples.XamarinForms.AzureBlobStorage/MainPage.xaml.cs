﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples.XamarinForms.AzureBlobStorage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }
}