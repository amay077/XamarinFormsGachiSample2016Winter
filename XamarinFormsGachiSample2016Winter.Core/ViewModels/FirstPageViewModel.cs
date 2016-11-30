using System;
using System.Reactive.Linq;
using Prism.Mvvm;
using Prism.Navigation;
using Reactive.Bindings;
using XamarinFormsGachiSample2016Winter.Models;

namespace XamarinFormsGachiSample2016Winter.ViewModels
{
    public class FirstPageViewModel
    {
        public ReactiveProperty<string> Address { get; } = new ReactiveProperty<string>();

		public ReactiveCommand NextCommand { get; }

        public FirstPageViewModel(INavigationService navigationService, IGeoCoder geoCoder)
        {
            Address.Value = "Tokyo station";
			NextCommand = Address.Select(x => !string.IsNullOrEmpty(x)).ToReactiveCommand();

            NextCommand.Subscribe(async _ =>
            {
                var res = await geoCoder.Forward(Address.Value);
				if (res != null)
				{
					await navigationService.NavigateAsync($"SecondPage?lat={res.Latitude}&lng={res.Longitude}&title={res.DisplayName}");
				}
            });
        }
    }
}