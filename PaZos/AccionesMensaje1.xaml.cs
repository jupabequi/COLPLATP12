using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PaZos
{
	public partial class AccionesMensaje1 : ContentPage
	{
		MasterDetailPage master;

		public AccionesMensaje1 (MasterDetailPage masterDetail)
		{
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


			//Colocar background
			var imgBackground2 = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.accionesmensaje1.png"),
				Aspect = Aspect.AspectFill
			};

			layout.Children.Add (imgBackground2,
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Height;
				}));
			//Fin Colocar background 

			Label lbtexto = new Label ();
			lbtexto.HorizontalOptions = LayoutOptions.CenterAndExpand;
			lbtexto.XAlign = TextAlignment.Center;

			var fs = new FormattedString ();


			Span sp1 = new Span () {
				Text = "¡Tu meta de ahorro es muy importante! es buena idea que guardes el dinero en un lugar seguro y que haga crecer tus ahorros. Acércate a un ",
				FontFamily = "MyriadPro-Regular",
				FontSize=16
			};
			fs.Spans.Add (sp1);
			Span sp2 = new Span () {
				Text = "banco",
				FontFamily = "MyriadPro-Bold",
				FontSize=16
			};
			fs.Spans.Add (sp2);

			Span sp3 = new Span () {
				Text = ", o visita su ",
				FontFamily = "MyriadPro-Regular",
				FontSize=16
			};
			fs.Spans.Add (sp3);
			Span sp4 = new Span () {
				Text = "página web",
				FontFamily = "MyriadPro-Bold",
				FontSize=16
			};
			fs.Spans.Add (sp4);
			Span sp5 = new Span () {
				Text = " para conocer sus servicios de ahorro.",
				FontFamily = "MyriadPro-Regular",
				FontSize=16
			};
			fs.Spans.Add (sp5);
			lbtexto.FormattedText = fs;

			layout.Children.Add (lbtexto,
				Constraint.Constant (45),
				Constraint.Constant (35),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-90;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 160;
				}));


			Content = layout;
		}
	}
}

