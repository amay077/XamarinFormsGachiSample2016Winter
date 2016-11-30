using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using XamarinFormsGachiSample2016Winter.Models;
using XamarinFormsGachiSample2016Winter.Primitives;

namespace XamarinFormsGachiSample2016Winter.Behaviors
{
    public static class MapBehavior
    {
        public static readonly BindableProperty PinProperty =
            BindableProperty.CreateAttached(
                "Pin",
                typeof(Location),
                typeof(MapBehavior),
                (Location)null,
                propertyChanged: OnPinChanged);

        public static Location GetPin(BindableObject view)
        {
            return (Location) view.GetValue(PinProperty);
        }
        public static void SetPin(BindableObject view, Location value)
        {
            view.SetValue(PinProperty, value);
        }

        static void OnPinChanged(BindableObject view, object oldValue, object newValue)
        {
            var map = view as Map;
            if (map == null)
            {
                return;
            }

            var location = newValue as Location;
            if (location == null)
            {
                return;
            }

            var pin = new Pin
            {
                Label = location.DisplayName,
                Position = new Position(location.Latitude, location.Longitude)
            };

            map.Pins.Clear();
            map.Pins.Add(pin);
            map.SelectedPin = pin;
        }
    }
}