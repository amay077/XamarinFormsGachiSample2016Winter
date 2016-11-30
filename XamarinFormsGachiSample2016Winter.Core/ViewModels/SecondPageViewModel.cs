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
        public ReactiveProperty<LatLong> Position { get; } = new ReactiveProperty<LatLong>();

        public ReactiveCommand SpotCommand { get; } = new ReactiveCommand();
        public ReactiveCommand CurrentCommand { get; } = new ReactiveCommand();

        public SecondPageViewModel()
        {
            SpotCommand.Subscribe(_ =>
            {
                Position.Value = new LatLong(Pin.Value.Latitude, Pin.Value.Longitude);
            });

            CurrentCommand.Subscribe(_ =>
            {

            });
        }

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

		    Position.Value = new LatLong(lat, lng);
		}

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

    }
}