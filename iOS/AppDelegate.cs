using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace PaZos.iOS
{

	//public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	[Register ("AppDelegate")]
	public partial class AppDelegate : XLabs.Forms.XFormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			// Code for starting up the Xamarin Test Cloud Agent
			#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
			#endif

			LoadApplication (new App ());

			UINavigationBar.Appearance.BarTintColor = UIColor.Orange;
			UINavigationBar.Appearance.SetTitleTextAttributes ( new UITextAttributes { TextColor = UIColor.White});

			return base.FinishedLaunching (app, options);
		}
	}
}

