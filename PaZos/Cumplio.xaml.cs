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

		public Cumplio (MasterDetailPage masterDetail, Usuario tusuario)
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
				Source = ImageSource.FromResource ("PaZos.Resources.cumplio.png"),
				Aspect = Aspect.AspectFill
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

			int y = 60;

			Span sp2 = new Span () {
				Text = "¿Cumpliste con tus acciones ahorradoras?",
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

			y = y + 60;


			Switch slino = new Switch () {
				
			};

			layout.Children.Add (slino,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2-15;
				}),
				Constraint.Constant (y-7),
				Constraint.RelativeToParent ((Parent) => {
					return 60;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 60;
				}));

			Label lblno = new Label () {
				Text="No"
			};
			layout.Children.Add (lblno,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2-60;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 60;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 60;
				}));

			Label lblsi = new Label () {
				Text="Si"
			};
			layout.Children.Add (lblsi,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2+60;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 60;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 60;
				}));

			Content = layout;
		}
	}
}

