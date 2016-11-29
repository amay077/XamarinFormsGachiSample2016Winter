using System;
using System.Reactive.Linq;
using Prism.Mvvm;
using Prism.Navigation;
using Reactive.Bindings;

namespace XamarinFormsGachiSample2016Winter.ViewModels
{
    public class FirstPageViewModel
    {
        public ReactiveProperty<string> Address { get; } = new ReactiveProperty<string>();

		public ReactiveCommand NextCommand { get; }

        public FirstPageViewModel(INavigationService navigationService)
        {
            Address.Value = "hogehoge";
			NextCommand = Address.Select(x => !string.IsNullOrEmpty(x)).ToReactiveCommand();

            NextCommand.Subscribe(async _ =>
            {
                await navigationService.NavigateAsync("SecondPage");
            });
        }
    }
}