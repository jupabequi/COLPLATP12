using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PaZos
{
	public partial class AccionesDia : ContentPage
	{

		MasterDetailPage master;
		private NavigationPage NPdias;

		public AccionesDia (MasterDetailPage masterDetail, int dia)
		{
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

			//Dias
			var imgDias = new Image ();


			switch (dia){

			case 1:
				imgDias.Source = ImageSource.FromResource ("PaZos.Resources.Dias.lunes.png");
				break;
			case 2:
				imgDias.Source = ImageSource.FromResource ("PaZos.Resources.Dias.martes.png");
				break;
			case 3:
				imgDias.Source = ImageSource.FromResource ("PaZos.Resources.Dias.miercoles.png");
				break;
			case 4:
				imgDias.Source = ImageSource.FromResource ("PaZos.Resources.Dias.Jueves.png");
				break;
			case 5:
				imgDias.Source = ImageSource.FromResource ("PaZos.Resources.Dias.Viernes.png");
				break;
			case 6:
				imgDias.Source = ImageSource.FromResource ("PaZos.Resources.Dias.Sabado.png");
				break;
			case 7:
				imgDias.Source = ImageSource.FromResource ("PaZos.Resources.Dias.Domingo.png");
				break;

			};
			


			layout.Children.Add (imgDias,
				Constraint.Constant (15),
				Constraint.Constant (15),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));


			var lbdia = new Button () {
				Text = "",
				TextColor = Color.White,
				//BackgroundColor = Color.Blue
			};
			lbdia.Clicked += (sender, args) => {
				Selected();
			};

			layout.Children.Add (lbdia,
				Constraint.Constant (15),
				Constraint.Constant (15),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));


			//End Dias

			Content = layout;
		}

		public void Selected()
		{

			NPdias = new NavigationPage (
				new acciones (master)
			);

			master.Detail = NPdias;

		}
	}
}

