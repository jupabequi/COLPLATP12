using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PaZos
{
	public partial class Animo : ContentPage
	{
		MasterDetailPage master;
		Usuario usuario;

		public Animo (MasterDetailPage masterDetail, Usuario tusuario)
		{
			usuario = tusuario;

			var guardaritem = new ToolbarItem {
				Text = "Continuar"
			};
			guardaritem.Clicked += (object sender, System.EventArgs e) => 
			{
				continuar();
			};

			//ToolbarItems.Add(new ToolbarItem(){Icon="pazosicon.png"});
			ToolbarItems.Add(guardaritem);
			this.Title = "Acciones ahorradoras";

			master = masterDetail;

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
			//Fin Colocar background 
			var imgmensaje = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.Animo.png"),
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

			int y = 75;
			int factor = 375;


			Label lbtextotitulo = new Label ();
			lbtextotitulo.HorizontalOptions = LayoutOptions.CenterAndExpand;
			lbtextotitulo.XAlign = TextAlignment.Center;
			lbtextotitulo.TextColor = Color.Red;

			var fstitulo = new FormattedString ();



			Span sptitulo = new Span () {
				Text = "¡Ánimo!",
				FontFamily = "Noteworthy-Bold",
				FontSize=28

			};
			fstitulo.Spans.Add (sptitulo);

			lbtextotitulo.FormattedText = fstitulo;

			layout.Children.Add (lbtextotitulo,
				Constraint.Constant (50),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width*75/factor;	
				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));

			Label lbtexto = new Label ();
			lbtexto.HorizontalOptions = LayoutOptions.CenterAndExpand;
			lbtexto.XAlign = TextAlignment.Center;

			var fs = new FormattedString ();


			Span sp3 = new Span () {
				Text = "Revisa tus acciones, mañana tienes otra oportunidad de ahorrar más.",
				FontFamily = "MyriadPro-Bold",
				FontSize=16
			};
			fs.Spans.Add (sp3);

			lbtexto.FormattedText = fs;

			layout.Children.Add (lbtexto,
				Constraint.Constant (50),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width*125/factor;	
				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 80;
				}));
			

			Content = layout;
		}

		public void continuar(){


			((NavigationPage)master.Detail).PushAsync(new PaZos.Preguntas(master,usuario));

		}
	}
}

