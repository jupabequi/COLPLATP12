using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace PaZos
{
	public partial class AccionesMensaje2 : ContentPage
	{
		MasterDetailPage master;
		Usuario usuario;

		ExtendedEntry valor;
		ExtendedEntry numero;
		ExtendedEntry meses;

		public AccionesMensaje2 (MasterDetailPage masterDetail, Usuario tusuario)
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
			var imgmensaje = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.Accionesmensaje2.png"),
				Aspect = Aspect.AspectFit
			};

			layout.Children.Add (imgmensaje,
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Height;
				}));

			Label lbtexto = new Label ();
			lbtexto.HorizontalOptions = LayoutOptions.CenterAndExpand;
			lbtexto.XAlign = TextAlignment.Center;

			var fs = new FormattedString ();

			int y = 45;

			Span sp2 = new Span () {
				Text = "Si haces todas tus acciones, esta semana ahorrarías",
				FontFamily = "MyriadPro-Bold",
				FontSize=16
			};
			fs.Spans.Add (sp2);
			lbtexto.FormattedText = fs;

			layout.Children.Add (lbtexto,
				Constraint.Constant (45),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-90;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));

			y = y + 38 + 5;
			valor = new ExtendedEntry () {
				Font = Font.OfSize("TwCenMT-Condensed",26),
				XAlign= TextAlignment.Center,
				IsEnabled=false
			};
			layout.Children.Add (valor,
				Constraint.Constant (75),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-150;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));

			y = y + 35;

			Label lbtextoB = new Label ();
			lbtextoB.HorizontalOptions = LayoutOptions.CenterAndExpand;
			lbtextoB.XAlign = TextAlignment.Center;

			var fsB = new FormattedString ();

			Span spB = new Span () {
				Text = "Si mantines estos hábitos de",
				FontFamily = "MyriadPro-Bold",
				FontSize=16
			};

			fsB.Spans.Add (spB);
			lbtextoB.FormattedText = fsB;

			layout.Children.Add (lbtextoB,
				Constraint.Constant (45),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-90;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));

			y = y + 35;

			Label lbtextoC = new Label ();
			lbtextoC.HorizontalOptions = LayoutOptions.CenterAndExpand;


			var fsC = new FormattedString ();

			Span spC = new Span () {
				Text = "ahorro, en ",
				FontFamily = "MyriadPro-Bold",
				FontSize=16
			};

			fsC.Spans.Add (spC);
			lbtextoC.FormattedText = fsC;

			layout.Children.Add (lbtextoC,
				Constraint.Constant (45),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-90;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));
			
			numero = new ExtendedEntry () {
				Font = Font.OfSize("TwCenMT-Condensed",26),
				XAlign= TextAlignment.Center,
				IsEnabled=false
			};
			layout.Children.Add (numero,
				Constraint.Constant (125),
				Constraint.Constant (y-5),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));

			meses = new ExtendedEntry () {
				Font = Font.OfSize("TwCenMT-Condensed",26),
				XAlign= TextAlignment.Center,
				IsEnabled=false
			};
			layout.Children.Add (meses,
				Constraint.Constant (170),
				Constraint.Constant (y-5),
				Constraint.RelativeToParent ((Parent) => {
					return 90;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));

			y = y + 35;

			Label lbtextoD = new Label ();
			lbtextoD.HorizontalOptions = LayoutOptions.CenterAndExpand;
			lbtextoD.XAlign = TextAlignment.Center;

			var fsD = new FormattedString ();

			Span spD = new Span () {
				Text = "alcanzarías tus metas.",
				FontFamily = "MyriadPro-Bold",
				FontSize=16
			};

			fsD.Spans.Add (spD);
			lbtextoD.FormattedText = fsD;

			layout.Children.Add (lbtextoD,
				Constraint.Constant (45),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-90;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));
			
			Content = layout;
			cargarMensaje ();
		}

		public async void cargarMensaje(){

			List<Mensaje2> mensaje = await new RestMensaje2().get (usuario);

			valor.Text = "$ " + mensaje[0].valor.ToString ();
			numero.Text = mensaje[0].numero.ToString ();
			meses.Text = mensaje[0].meses.ToString ();

		}
	}
}

