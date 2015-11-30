using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PaZos
{
	public partial class OlvidasteContrasena : ContentPage
	{
		public OlvidasteContrasena ()
		{
			this.Title = "Registro";

			RelativeLayout layout = new RelativeLayout ();

			//Colocar background
			var imgBackground = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.FondoLogin.png"),
				Aspect = Aspect.AspectFill
			};

			layout.Children.Add (imgBackground,
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Height;
				}));


			BoxView bv = new BoxView () {
				BackgroundColor = Color.FromRgb(232,78,27)
			};
			layout.Children.Add (bv,
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 60;
				}));

			Content = layout;
		}
	}
}

