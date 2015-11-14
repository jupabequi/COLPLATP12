using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PaZos
{
	public partial class FinalInformate : ContentPage
	{
		MasterDetailPage master;

		public FinalInformate (MasterDetailPage masterDetail)
		{
			ToolbarItems.Add(new ToolbarItem(){Icon="pazosicon.png"});
			this.Title = "¿Qué vas a hacer con tus ahorros?";

			master = masterDetail;

			RelativeLayout layout = new RelativeLayout ();

			//Colocar background
			var imgBackground = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.FondoAcciones.png"),
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
			//Fin Colocar background 


			Content = layout;
		}
	}
}

