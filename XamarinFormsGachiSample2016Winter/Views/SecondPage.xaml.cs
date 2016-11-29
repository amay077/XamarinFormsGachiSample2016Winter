using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace XamarinFormsGachiSample2016Winter.Views
{
	public partial class SecondPage : ContentPage
	{
		public SecondPage()
		{
			InitializeComponent();

		    var jgsLayer = TileLayer.FromTileUri((int x, int y, int zoom) =>
		            new Uri($"https://cyberjapandata.gsi.go.jp/xyz/std/{zoom}/{x}/{y}.png") );
		    jgsLayer.Tag = "JGSITILE"; // Can set any object

		    map.TileLayers.Add(jgsLayer);
		    map.MapType = MapType.None;
		}
	}
}
