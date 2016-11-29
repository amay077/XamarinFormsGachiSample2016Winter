using System.Threading;
using Reactive.Bindings;
using Xamarin.Forms.GoogleMaps;

namespace XamarinFormsGachiSample2016Winter.ViewModels
{
    public class SecondPageViewModel
    {
        public ReactiveProperty<Position> Position { get; } = new ReactiveProperty<Position>();

        public SecondPageViewModel()
        {
            Position.Value = new Position(35d, 136d);
        }
    }
}