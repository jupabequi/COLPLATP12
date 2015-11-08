using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PaZos
{
	public partial class evaluacion : ContentPage
	{

		MasterDetailPage master;
		private NavigationPage NPdias;

		public evaluacion (MasterDetailPage masterDetail)
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




			double y = 132;
			int gap = 62;


			var imglunes = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.Dias.lunes.png"),
			};

			layout.Children.Add (imglunes,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2 - 125;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));
			
			var lblunes = new Button () {
				Text = "",
				TextColor = Color.White,
				//BackgroundColor = Color.Blue
			};
			lblunes.Clicked += (sender, args) => {
				Selected(1);
			};

			layout.Children.Add (lblunes,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2 - 125;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));





			//martes

			var imgmartes = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.Dias.martes.png"),
			};

			layout.Children.Add (imgmartes,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2 - 125;
				}),
				Constraint.Constant (y+gap),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));

			var lbmartes = new Button () {
				Text = "",
				TextColor = Color.White,
				//BackgroundColor = Color.Blue
			};
			lbmartes.Clicked += (sender, args) => {
				Selected(2);
			};

			layout.Children.Add (lbmartes,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2 - 125;
				}),
				Constraint.Constant (y+gap),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));

			//miercoles

			var imgmiercoles = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.Dias.miercoles.png"),
			};


			layout.Children.Add (imgmiercoles,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2 - 125;
				}),
				Constraint.Constant (y+gap*2),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));


			var lbmiercoles = new Button () {
				Text = "",
				TextColor = Color.White,
				//BackgroundColor = Color.Blue
			};
			lbmiercoles.Clicked += (sender, args) => {
				Selected(3);
			};

			layout.Children.Add (lbmiercoles,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2 - 125;
				}),
				Constraint.Constant (y+gap*2),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));

			//jueves

			var imgjueves = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.Dias.Jueves.png"),
			};

			layout.Children.Add (imgjueves,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2 - 125;
				}),
				Constraint.Constant (y+gap*3),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));
			
			var lbjueves = new Button () {
				Text = "",
				TextColor = Color.White,
				//BackgroundColor = Color.Blue
			};
			lbjueves.Clicked += (sender, args) => {
				Selected(4);
			};

			layout.Children.Add (lbjueves,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2 - 125;
				}),
				Constraint.Constant (y+gap*3),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));

			//viernes
			var imgviernes = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.Dias.Viernes.png")
			};


			layout.Children.Add (imgviernes,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2 - 125;
				}),
				Constraint.Constant (y+gap*4),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));

			var lbviernes = new Button () {
				Text = "",
				TextColor = Color.White,
				//BackgroundColor = Color.Blue
			};
			lbviernes.Clicked += (sender, args) => {
				Selected(5);
			};

			layout.Children.Add (lbviernes,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2 - 125;
				}),
				Constraint.Constant (y+gap*4),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));

			//sabado
			var imgsabado = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.Dias.Sabado.png")
			};


			layout.Children.Add (imgsabado,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2 - 125;
				}),
				Constraint.Constant (y+gap*5),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));
			
			var lbsabado = new Button () {
				Text = "",
				TextColor = Color.White,
				//BackgroundColor = Color.Blue
			};
			lbsabado.Clicked += (sender, args) => {
				Selected(6);
			};

			layout.Children.Add (lbsabado,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2 - 125;
				}),
				Constraint.Constant (y+gap*5),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));


			//domingo
			var imgdomingo = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.Dias.Domingo.png")
			};


			layout.Children.Add (imgdomingo,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2 - 125;
				}),
				Constraint.Constant (y+gap*6),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));

			var lbdomingo = new Button () {
				Text = "",
				TextColor = Color.White,
				//BackgroundColor = Color.Blue
			};
			lbdomingo.Clicked += (sender, args) => {
				Selected(7);
			};

			layout.Children.Add (lbdomingo,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2 - 125;
				}),
				Constraint.Constant (y+gap*6),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));





			Content = layout;
		}


		public void Selected(int dia)
		{

			NPdias = new NavigationPage (
				new evaluacionDia (master, dia)
			);

			master.Detail = NPdias;

		}
	}
}

