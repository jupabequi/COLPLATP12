using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using XLabs.Forms.Controls;

[assembly: ExportRenderer (typeof(AsisprinDatePicker), typeof(PaZos.iOS.AsisprinDatePickerRenderer))]
namespace PaZos.iOS
{
	public class AsisprinDatePickerRenderer : ExtendedDatePickerRenderer
	{

		protected override void OnElementChanged (ElementChangedEventArgs<ExtendedDatePicker> e)
		{
			base.OnElementChanged (e);

			if (Control != null) {
				// do whatever you want to the UITextField here!
				//Control.BackgroundColor = UIColor.FromRGB (204, 153, 255);
				//Control.BorderStyle = UITextBorderStyle.Line;
				Control.Font = UIFont.FromName ("TwCenMT-Condensed", 16);


			}
		}
	}
}


