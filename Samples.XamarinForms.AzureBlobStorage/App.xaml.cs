﻿using Prism.Events;
using Samples.XamarinForms.AzureBlobStorage.AzureStorage;
using Xamarin.Forms;

namespace Samples.XamarinForms.AzureBlobStorage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<ITakePictureCommand, TakePictureCommand>();
            DependencyService.Register<IChoosePictureCommand, ChoosePictureCommand>();
            DependencyService.Register<IGenerateInvoiceCommand, GenerateInvoiceCommand>();
            DependencyService.Register<INavigationService, HackedNavigationService>();
            DependencyService.Register<ICloudBlobStorageService, AzureBlobStorageService>();
            DependencyService.Register<IEventAggregator, EventAggregator>();

#if DEBUG
            DependencyService.Register<ICloudBlobStorageSettingsProvider, LocalBlobStorageSettingsProvider>();
            //DependencyService.Register<ICloudBlobStorageSettingsProvider, CloudTestStorageSettingsProvider>();
#else
            DependencyService.Register<ICloudBlobStorageSettingsProvider, ZCloudBlobStorageSettings>();
#endif

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }
    }
}