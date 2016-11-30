using System;
using System.Threading;
using Prism.Navigation;
using Reactive.Bindings;
using XamarinFormsGachiSample2016Winter.Primitives;

namespace XamarinFormsGachiSample2016Winter.ViewModels
{
    public class SecondPageViewModel : INavigationAware
    {
        public ReactiveProperty<LatLong> Position { get; } = new ReactiveProperty<LatLong>();

        public void OnNavigatedTo(NavigationParameters parameters)
		{
			var lat = Convert.ToDouble(parameters["lat"]);
			var lng = Convert.ToDouble(parameters["lng"]);
   			var title = Convert.ToDouble(parameters["title"]);
         	Position.Value = new LatLong(lat, lng);
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

    }
}