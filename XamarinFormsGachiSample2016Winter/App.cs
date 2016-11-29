using System;
using Microsoft.Practices.Unity;
using Prism.Mvvm;
using Prism.Unity;
using Xamarin.Forms;
using XamarinFormsGachiSample2016Winter.Models;
using XamarinFormsGachiSample2016Winter.Views;

namespace XamarinFormsGachiSample2016Winter
{
	public class App : PrismApplication
	{
		protected override void RegisterTypes()
		{
		    Container.RegisterType<IGeoCoder, GeoCoder>(new ContainerControlledLifetimeManager());

		    Container.RegisterTypeForNavigation<NavigationPage>();
		    Container.RegisterTypeForNavigation<FirstPage>();
		    Container.RegisterTypeForNavigation<SecondPage>();
		}

	    protected override void OnInitialized()
	    {
	        NavigationService.NavigateAsync("NavigationPage/FirstPage");
	    }

	    protected override void ConfigureViewModelLocator()
	    {
	        base.ConfigureViewModelLocator();
	        ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver(ViewTypeToViewModelTypeResolver.Resolve);
	    }
	}
}
