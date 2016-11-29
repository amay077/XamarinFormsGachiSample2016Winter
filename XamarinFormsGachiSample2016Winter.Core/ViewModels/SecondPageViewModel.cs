using System.Threading;
using Reactive.Bindings;
using XamarinFormsGachiSample2016Winter.Primitives;

namespace XamarinFormsGachiSample2016Winter.ViewModels
{
    public class SecondPageViewModel
    {
        public ReactiveProperty<LatLong> Position { get; } = new ReactiveProperty<LatLong>();

        public SecondPageViewModel()
        {
            Position.Value = new LatLong(35d, 136d);
        }
    }
}