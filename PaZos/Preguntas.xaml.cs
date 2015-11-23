using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XLabs.Forms.Controls;


namespace PaZos
{
	public partial class Preguntas : ContentPage
	{




		MasterDetailPage master;
		Usuario usuario;

		Switch C1,C2,C3,C4,C5;

		public Preguntas (MasterDetailPage masterDetail, Usuario tusuario)
		{
			master = masterDetail;

			var guardaritem = new ToolbarItem {
				Text = "Continuar"
			};
			guardaritem.Clicked += (object sender, System.EventArgs e) => 
			{
				continuar();
			};

			//ToolbarItems.Add(new ToolbarItem(){Icon="pazosicon.png"});
			ToolbarItems.Add(guardaritem);
			this.Title = "¿Qué vas a hacer con tus ahorros?";


			tusuario = usuario;

			var imgBackground = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.FondoLogin.png"),
				Aspect = Aspect.AspectFill
			};

			RelativeLayout layoutcontent = new RelativeLayout ();

			layoutcontent.Children.Add (imgBackground,
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Height;
				}));

			int y=30;
			int altura = 60;


			BoxView boxView = new BoxView {

				Color = Color.White


			};

			layoutcontent.Children.Add (boxView,
				Constraint.Constant (20),
				Constraint.Constant (y-10),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-40;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return altura*5+20;
				}));









			Label A1 = new Label () {
				Text = "1.",
				TextColor = Color.Red,
				FontFamily = "MyriadPro-Bold",
				FontSize=26
			};
			layoutcontent.Children.Add (A1,
				Constraint.Constant (30),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));
			Label B1 = new Label () {
				HorizontalOptions = LayoutOptions.StartAndExpand
			};
			var B1fs = new FormattedString ();
			Span B1sp = new Span () {
				Text = "¿Tienes una cuenta de ahorros?",
				FontFamily = "MyriadPro-Regular",
				FontSize=18
			};
			B1fs.Spans.Add (B1sp);
			B1.FormattedText = B1fs;

			layoutcontent.Children.Add (B1,
				Constraint.Constant (60),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-60-30-60;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return altura;
				}));
			C1 = new Switch () {

			};
			layoutcontent.Children.Add (C1,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-60-30;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));

			y = y + 60;

			Label A2 = new Label () {
				Text = "2.",
				TextColor = Color.Red,
				FontFamily = "MyriadPro-Bold",
				FontSize=26
			};
			layoutcontent.Children.Add (A2,
				Constraint.Constant (30),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));
			Label B2 = new Label () {
				HorizontalOptions = LayoutOptions.StartAndExpand
			};
			var B2fs = new FormattedString ();
			Span B2sp = new Span () {
				Text = "¿Sabés que es un CDT?",
				FontFamily = "MyriadPro-Regular",
				FontSize=18
			};
			B2fs.Spans.Add (B2sp);
			B2.FormattedText = B2fs;

			layoutcontent.Children.Add (B2,
				Constraint.Constant (60),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-60-30-60;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return altura;
				}));
			C2 = new Switch () {

			};
			layoutcontent.Children.Add (C2,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-60-30;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));

			y = y + 60;

			Label A3 = new Label () {
				Text = "3.",
				TextColor = Color.Red,
				FontFamily = "MyriadPro-Bold",
				FontSize=26
			};
			layoutcontent.Children.Add (A3,
				Constraint.Constant (30),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));
			Label B3 = new Label () {
				HorizontalOptions = LayoutOptions.StartAndExpand
			};
			var B3fs = new FormattedString ();
			Span B3sp = new Span () {
				Text = "¿Estás ahorrando las utilidades de tu negocio en un banco?",
				FontFamily = "MyriadPro-Regular",
				FontSize=18
			};
			B3fs.Spans.Add (B3sp);
			B3.FormattedText = B3fs;

			layoutcontent.Children.Add (B3,
				Constraint.Constant (60),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-60-30-60;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return altura;
				}));
			C3 = new Switch () {

			};
			layoutcontent.Children.Add (C3,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-60-30;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));
			

			y = y + 60;

			Label A4 = new Label () {
				Text = "4.",
				TextColor = Color.Red,
				FontFamily = "MyriadPro-Bold",
				FontSize=26
			};
			layoutcontent.Children.Add (A4,
				Constraint.Constant (30),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));
			Label B4 = new Label () {
				HorizontalOptions = LayoutOptions.StartAndExpand
			};
			var B4fs = new FormattedString ();
			Span B4sp = new Span () {
				Text = "¿Irías a un banco para pedir información sobre cómo ahorrar?",
				FontFamily = "MyriadPro-Regular",
				FontSize=18
			};
			B4fs.Spans.Add (B4sp);
			B4.FormattedText = B4fs;

			layoutcontent.Children.Add (B4,
				Constraint.Constant (60),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-60-30-60;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return altura;
				}));
			C4 = new Switch () {

			};
			layoutcontent.Children.Add (C4,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-60-30;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));
			
			y = y + 60;

			Label A5 = new Label () {
				Text = "5.",
				TextColor = Color.Red,
				FontFamily = "MyriadPro-Bold",
				FontSize=26
			};
			layoutcontent.Children.Add (A5,
				Constraint.Constant (30),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));
			Label B5 = new Label () {
				HorizontalOptions = LayoutOptions.StartAndExpand
			};
			var B5fs = new FormattedString ();
			Span B5sp = new Span () {
				Text = "¿Conoces los servicios virtuales de tu banco?",
				FontFamily = "MyriadPro-Regular",
				FontSize=18
			};
			B5fs.Spans.Add (B5sp);
			B5.FormattedText = B5fs;

			layoutcontent.Children.Add (B5,
				Constraint.Constant (60),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-60-30-60;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return altura;
				}));
			C5 = new Switch () {

			};
			layoutcontent.Children.Add (C5,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-60-30;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));
			
						// Build the page.
			Content = layoutcontent;


		}

		public void continuar(){

			int cuantos = 0;
			if (C1.IsToggled) {
				cuantos += 1;
			}
			if (C2.IsToggled) {
				cuantos += 1;
			}
			if (C3.IsToggled) {
				cuantos += 1;
			}
			if (C4.IsToggled) {
				cuantos += 1;
			}
			if (C5.IsToggled) {
				cuantos += 1;
			}


			if (cuantos>2) {

				((NavigationPage)master.Detail).PushAsync(new PaZos.FelicitacionesFinal(master));
			} else {
				((NavigationPage)master.Detail).PushAsync(new PaZos.FinalInformate(master));
			}
		}
	}
}

