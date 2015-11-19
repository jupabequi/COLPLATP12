using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


[assembly: ExportRenderer (typeof(AsisprinPicker), typeof(PaZos.Droid.AsisprinPickerRenderer))]
namespace PaZos.Droid
{
	public class AsisprinPickerRenderer : PickerRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged (e);

			if (Control != null) {
				Control.SetBackgroundColor (global::Android.Graphics.Color.LightGreen);
			}
		}
	}
}

