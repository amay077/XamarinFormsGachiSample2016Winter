using System;
using Prism.Unity;
using XamarinFormsGachiSample2016Winter.Views;

namespace XamarinFormsGachiSample2016Winter
{
	public class App : PrismApplication
	{
		protected override void RegisterTypes()
		{
		    Container.RegisterTypeForNavigation<FirstPage>();
		    Container.RegisterTypeForNavigation<SecondPage>();
		}

	    protected override void OnInitialized()
	    {
	        NavigationService.NavigateAsync("FirstPage");
	    }
	}
}
