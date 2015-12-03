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
using XLabs.Forms.Controls;


[assembly: ExportRenderer (typeof(AsisprinPicker), typeof(PaZos.Droid.AsisprinPickerRenderer))]
namespace PaZos.Droid
{
	public class AsisprinDatePickerRenderer : DatePickerRenderer
	{
		
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.DatePicker> e)
		{
			base.OnElementChanged (e);

			if (Control != null) {
				Control.SetBackgroundColor (global::Android.Graphics.Color.Black);
			}
		}
	}
}

