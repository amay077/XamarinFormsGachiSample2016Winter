using System;
using Android.App;
using Android.Runtime;

namespace XamarinFormsGachiSample2016Winter.Droid
{
	[Application]
	[MetaData("com.google.android.maps.v2.API_KEY",
		  Value = "dummy_api_key")]
	public class DroidApp : Application
	{
		public DroidApp(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
		}
	}
}
