using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;


[assembly: ExportRenderer (typeof(AsisprinPicker), typeof(PaZos.iOS.AsisprinPickerRenderer))]
namespace PaZos.iOS
{
	public class AsisprinPickerRenderer : PickerRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Picker> e)
		{
			base.OnElementChanged (e);

			if (Control != null) {
				// do whatever you want to the UITextField here!
				//Control.BackgroundColor = UIColor.FromRGB (204, 153, 255);
				//Control.BorderStyle = UITextBorderStyle.Line;
				Control.Font = UIFont.FromName ("TwCenMT-Condensed", 18);


			}
		}
	}
}

