using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PaZos
{
	public partial class acciones : ContentPage
	{

		MasterDetailPage master;
		private NavigationPage NPdias;

		Usuario usuario;

		public acciones (MasterDetailPage masterDetail,Usuario tusuario)
		{
			usuario = tusuario;

			ToolbarItems.Add(new ToolbarItem(){Icon="pazosicon.png"});
			this.Title = "Acciones ahorradoras";

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
			var imgDias = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.AccionesDias.png"),
				Aspect = Aspect.AspectFill
			};

			layout.Children.Add (imgDias,
				Constraint.Constant (0),
				Constraint.Constant (-20),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Height;
				}));

			//End Dias

			Label lblTitle = new Label () {
				Text = "¿Cuánto debes ahorrar para cumplir tus metas?",
				FontSize = 20,
				FontFamily = "MyriadPro-Bold",
				HorizontalOptions=LayoutOptions.Center,
				XAlign= TextAlignment.Center
			};

			layout.Children.Add (lblTitle,
				Constraint.Constant (20),
				Constraint.Constant (5),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-40;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 50;
				}));

			Label lbtexto = new Label ();
			lbtexto.HorizontalOptions = LayoutOptions.CenterAndExpand;
			lbtexto.XAlign = TextAlignment.Center;

			var fs = new FormattedString ();


			Span sp1 = new Span () {
				Text = "Ingresa en este calendario las ",
				FontFamily = "MyriadPro-Regular",
				FontSize=13
			};
			fs.Spans.Add (sp1);
			Span sp2 = new Span () {
				Text = "acciones ahorradoras",
				FontFamily = "MyriadPro-Bold",
				FontSize=13
			};
			fs.Spans.Add (sp2);
			Span sp3 = new Span () {
				Text = " que puedes hacer cada día de la semana.",
				FontFamily = "MyriadPro-Regular",
				FontSize=13
			};
			fs.Spans.Add (sp3);
			lbtexto.FormattedText = fs;

			layout.Children.Add (lbtexto,
				Constraint.Constant (20),
				Constraint.Constant (52),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-40;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 80;
				}));	



			int x = 118;
			int y = 152;
			int gap = 62;
			int factor = 375;



			var lblunes = new Button () {
				Text = "",
				TextColor = Color.White,
				//BackgroundColor = Color.Blue
			};
			lblunes.Clicked += (sender, args) => {
				Selected(1);
			};

			layout.Children.Add (lblunes,
				Constraint.Constant (x),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width*y/factor;	
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));

			//martes
			var lbmartes = new Button () {
				Text = "",
				TextColor = Color.White,
				//BackgroundColor = Color.Blue
			};
			lbmartes.Clicked += (sender, args) => {
				Selected(2);
			};

			layout.Children.Add (lbmartes,
				Constraint.Constant (x),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width*(y+gap)/factor;	
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));

			//miercoles
			var lbmiercoles = new Button () {
				Text = "",
				TextColor = Color.White,
				//BackgroundColor = Color.Blue
			};
			lbmiercoles.Clicked += (sender, args) => {
				Selected(3);
			};

			layout.Children.Add (lbmiercoles,
				Constraint.Constant (x),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width*(y+gap*2)/factor;	
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));

			//jueves
			var lbjueves = new Button () {
				Text = "",
				TextColor = Color.White,
				//BackgroundColor = Color.Blue
			};
			lbjueves.Clicked += (sender, args) => {
				Selected(4);
			};

			layout.Children.Add (lbjueves,
				Constraint.Constant (x),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width*(y+gap*3)/factor;	
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));

			//viernes
			var lbviernes = new Button () {
				Text = "",
				TextColor = Color.White,
				//BackgroundColor = Color.Blue
			};
			lbviernes.Clicked += (sender, args) => {
				Selected(5);
			};

			layout.Children.Add (lbviernes,
				Constraint.Constant (x),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width*(y+gap*4)/factor;	
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));

			//sabado
			var lbsabado = new Button () {
				Text = "",
				TextColor = Color.White,
				//BackgroundColor = Color.Blue
			};
			lbsabado.Clicked += (sender, args) => {
				Selected(6);
			};

			layout.Children.Add (lbsabado,
				Constraint.Constant (x),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width*(y+gap*5)/factor;	
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));

			//domingo
			var lbdomingo = new Button () {
				Text = "",
				TextColor = Color.White,
				//BackgroundColor = Color.Blue
			};
			lbdomingo.Clicked += (sender, args) => {
				Selected(7);
			};

			layout.Children.Add (lbdomingo,
				Constraint.Constant (x),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width*(y+gap*6)/factor;	
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));




			Content = layout;




		}

		public void Selected(int dia)
		{


			((NavigationPage)master.Detail).PushAsync(new PaZos.AccionesDia(master, dia, usuario));
			/*(NPdias = new NavigationPage (
				new AccionesDia (master, dia)
			);

			master.Detail = NPdias;*/
			
		}


	}
}

