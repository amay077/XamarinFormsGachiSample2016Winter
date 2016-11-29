using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace XamarinFormsGachiSample2016Winter.Behaviors
{
    public static class MapBehavior
    {
        public static readonly BindableProperty PositionProperty =
            BindableProperty.CreateAttached(
                "Position",
                typeof(Position),
                typeof(MapBehavior),
                new Position(30, 135),
                propertyChanged: OnPositionChanged);

        public static Position GetPosition(BindableObject view)
        {
            return (Position) view.GetValue(PositionProperty);
        }

        public static void SetPosition(BindableObject view, Position value)
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

            var position = newValue as Position?;
            if (!position.HasValue)
            {
                return;
            }

            map.MoveToRegion(MapSpan.FromCenterAndRadius(position.Value, Distance.FromMeters(500)));
        }

        static void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            double result;
            bool isValid = double.TryParse(args.NewTextValue, out result);
            ((Entry) sender).TextColor = isValid ? Color.Default : Color.Red;
        }
    }
}