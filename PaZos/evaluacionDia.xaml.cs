using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace PaZos
{
	public partial class evaluacionDia : ContentPage
	{
		MasterDetailPage master;
		private NavigationPage NPdias;

		public evaluacionDia (MasterDetailPage masterDetail, int dia)
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

			int y = 15;

			layout.Children.Add (imgDias,
				Constraint.Constant (15),
				Constraint.Constant (y),
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
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));


			//End Dias

			ExtendedEntry txtaccion, txtvalor;
			Label lbvalor;

			int i, j = 3;
			y = 52 + y + 10;

			for (i = 1; i < j; i++) {
				txtaccion = new ExtendedEntry () {
					Placeholder = "Acción " + i.ToString()
				};
				layout.Children.Add (txtaccion,
					Constraint.Constant (20),
					Constraint.Constant (y+90*(i-1)),
					Constraint.RelativeToParent ((Parent) => {
						return Parent.Width - 40;
					}),
					Constraint.RelativeToParent ((Parent) => {
						return 40;
					}));	

				lbvalor = new Label (){
					Text = "Valor",
					FontSize=22,
					FontFamily =  "MyriadPro-Regular"
				};
				layout.Children.Add (lbvalor,
					Constraint.RelativeToParent ((Parent) => {
						return Parent.Width - 20 - 150 - 60;
					}),
					Constraint.Constant (y+55+90*(i-1)),
					Constraint.RelativeToParent ((Parent) => {
						return 100;
					}),
					Constraint.RelativeToParent ((Parent) => {
						return 40;
					}));	

				txtvalor = new ExtendedEntry () {

				};
				layout.Children.Add (txtvalor,
					Constraint.RelativeToParent ((Parent) => {
						return Parent.Width - 20 - 150;
					}),
					Constraint.Constant (y+45+90*(i-1)),
					Constraint.RelativeToParent ((Parent) => {
						return 150;
					}),
					Constraint.RelativeToParent ((Parent) => {
						return 40;
					}));	


			}

			y = y + 90 * (i-1);

			lbvalor = new Label (){
				Text = "Valor total",
				FontSize=22,
				FontFamily =  "MyriadPro-Regular"
			};
			layout.Children.Add (lbvalor,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width - 20 - 200 - 110;
				}),
				Constraint.Constant (y+5),
				Constraint.RelativeToParent ((Parent) => {
					return 110;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));

			ExtendedEntry txttotal = new ExtendedEntry () {

			};
			layout.Children.Add (txttotal,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width - 20 - 200;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 200;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));	
			


			Content = layout;
		}

		public void Selected()
		{

			NPdias = new NavigationPage (
				new evaluacion (master)
			);

			master.Detail = NPdias;

		}
	}
}

