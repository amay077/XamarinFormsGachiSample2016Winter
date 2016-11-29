using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using XamarinFormsGachiSample2016Winter.Primitives;

namespace XamarinFormsGachiSample2016Winter.Behaviors
{
    public static class MapBehavior
    {
        public static readonly BindableProperty PositionProperty =
            BindableProperty.CreateAttached(
                "Position",
                typeof(LatLong),
                typeof(MapBehavior),
                new LatLong(30, 135),
                propertyChanged: OnPositionChanged);

        public static LatLong GetPosition(BindableObject view)
        {
            return (LatLong) view.GetValue(PositionProperty);
        }

        public static void SetPosition(BindableObject view, LatLong value)
        {
            view.SetValue(PositionProperty, value);
        }

        static void OnPositionChanged(BindableObject view, object oldValue, object newValue)
        {
            var map = view as Map;
            if (map == null)
            {
                return;
            }

            var latlng = newValue as LatLong;
            if (latlng == null)
            {
                return;
            }

            map.MoveToRegion(MapSpan.FromCenterAndRadius(
                    new Position(latlng.Latitude, latlng.Longitude),
                    Distance.FromMeters(500)));
        }

        static void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            double result;
            bool isValid = double.TryParse(args.NewTextValue, out result);
            ((Entry) sender).TextColor = isValid ? Color.Default : Color.Red;
        }
    }
}