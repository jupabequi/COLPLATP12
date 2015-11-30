using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace PaZos
{
	public partial class Cumplio : ContentPage
	{
		MasterDetailPage master;
		Usuario usuario;
		Switch slino;

		public Cumplio (MasterDetailPage masterDetail, Usuario tusuario)
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
				Source = ImageSource.FromResource ("PaZos.Resources.cumplio.png"),
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

			int y = 75;
			int factor = 375;

			Span sp2 = new Span () {
				Text = "¿Cumpliste con tus acciones ahorradoras?",
				FontFamily = "MyriadPro-Bold",
				FontSize=16
			};
			fs.Spans.Add (sp2);
			lbtexto.FormattedText = fs;

			layout.Children.Add (lbtexto,
				Constraint.Constant (45),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width*75/factor;	
				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-90;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));
			
			y = y + 60;


			slino = new Switch () {
				
			};

			layout.Children.Add (slino,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2-15;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width*135/factor;	
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 60;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 60;
				}));
			
			Label lblno = new Label () {
				Text="No",
				Font = Font.OfSize("TwCenMT-Condensed",18)
			};
			layout.Children.Add (lblno,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2-60;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width*140/factor;	
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 60;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 60;
				}));

			Label lblsi = new Label () {
				Text="Si",
				Font = Font.OfSize("TwCenMT-Condensed",18)
			};
			layout.Children.Add (lblsi,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2+60;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width*140/factor;	
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 60;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 60;
				}));

			y = y + 100;

			Label lbtexto3 = new Label ();
			lbtexto3.HorizontalOptions = LayoutOptions.CenterAndExpand;
			lbtexto3.XAlign = TextAlignment.Center;

			var fs3 = new FormattedString ();


			Span sp3 = new Span () {
				Text = "Guarda y protege tu dinero en un lugar seguro, ¿estás ahorrando en un banco?",
				FontFamily = "MyriadPro-Regular",
				FontSize=16
			};
			fs3.Spans.Add (sp3);

			lbtexto3.FormattedText = fs3;

			layout.Children.Add (lbtexto3,
				Constraint.Constant (40),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width*250/factor;	
				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-80;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 80;
				}));	
			



			Content = layout;
		}

		public void continuar(){

			if (slino.IsToggled) {

				((NavigationPage)master.Detail).PushAsync(new PaZos.Felicitaciones(master,usuario));
			} else {
				((NavigationPage)master.Detail).PushAsync(new PaZos.Animo(master,usuario));
			}
		}
	}
}

