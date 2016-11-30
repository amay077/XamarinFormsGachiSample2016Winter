using System;
using System.Threading;
using Prism.Navigation;
using Reactive.Bindings;
using XamarinFormsGachiSample2016Winter.Models;
using XamarinFormsGachiSample2016Winter.Primitives;

namespace XamarinFormsGachiSample2016Winter.ViewModels
{
    public class SecondPageViewModel : INavigationAware
    {
        public ReactiveProperty<Location> Pin { get; } = new ReactiveProperty<Location>();

        public void OnNavigatedTo(NavigationParameters parameters)
		{
			var lat = Convert.ToDouble(parameters["lat"]);
			var lng = Convert.ToDouble(parameters["lng"]);
			var title = Convert.ToString(parameters["title"]);

		    Pin.Value = new Location
		    {
                Latitude = lat,
		        Longitude = lng,
		        DisplayName = title
		    };
		}

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

    }
}