using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PaZos
{
	public partial class Metas : ContentPage
	{
		MasterDetailPage master;
		private NavigationPage NPdias;

		public Metas (MasterDetailPage masterDetail)
		{

			this.Title = "Metas";

			//this.Icon =  "Resources/menuicon.png";

			//cargarImagenes ();

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


			Label lblTitle = new Label () {
				Text= "¿Para qué quieres ahorrar?",
				FontSize=20,
				FontFamily="MyriadPro-Bol",
			};

			layout.Children.Add (lblTitle,
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return 300;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 50;
				}));

			Label lbtexto = new Label ();

			var fs = new FormattedString ();

			Span sp1 = new Span () {
				Text = "Ingresa aquí, en orden de prioridad, 3. ",
				FontFamily = "MyriadPeo-Regular"
			};
			fs.Spans.Add (sp1);
			Span sp2 = new Span () {
				Text = " metas especificas de ahorro.",
				FontFamily = "MyriadPeo-Regular"
			};
			fs.Spans.Add (sp2);
			Span sp3 = new Span () {
				Text = "Define si tus metas son",
				FontFamily = "MyriadPeo-Regular"
			};
			fs.Spans.Add (sp3);
			Span sp4 = new Span () {
				Text = "personales, ",
				FontFamily = "MyriadPeo-Bold"
			};
			fs.Spans.Add (sp4);
			Span sp5 = new Span () {
				Text = " o para tu ",
				FontFamily = "MyriadPeo-Regular"
			};
			fs.Spans.Add (sp5);
			Span sp6 = new Span () {
				Text = "empresndimiento",
				FontFamily = "MyriadPeo-Bold"
			};
			fs.Spans.Add (sp6);	
				
			layout.Children.Add (lbtexto,
				Constraint.Constant (20),
				Constraint.Constant (100),
				Constraint.RelativeToParent ((Parent) => {
					return 100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));	
				
			Image imgMeta1 = new Image () {
				Aspect = Aspect.AspectFill,
				Source=  ImageSource.FromResource ("PaZos.Resources.meta1.png"),
				WidthRequest = 338,
				HeightRequest = 200
			};
			layout.Children.Add (imgMeta1,
				Constraint.Constant (20),
				Constraint.Constant (150),
				Constraint.RelativeToParent ((Parent) => {
					return 100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));	


			Picker pkTipoMeta = new Picker(){
				Title = "Tipo de meta"
			};
			layout.Children.Add (pkTipoMeta,
				Constraint.Constant (20),
				Constraint.Constant (175),
				Constraint.RelativeToParent ((Parent) => {
					return 100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));	

			Entry entmeta = new Entry () {
				Text = "Escribe tu meta"
			};
				layout.Children.Add (entmeta,
					Constraint.Constant (20),
					Constraint.Constant (200),
					Constraint.RelativeToParent ((Parent) => {
						return 100;
					}),
					Constraint.RelativeToParent ((Parent) => {
						return 30;
					}));	

			DatePicker dtinicio = new DatePicker () {
				VerticalOptions=LayoutOptions.Center,
				Format="D"
			};
			layout.Children.Add (dtinicio,
				Constraint.Constant (20),
				Constraint.Constant (225),
				Constraint.RelativeToParent ((Parent) => {
					return 100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));	

			DatePicker dtfinal = new DatePicker () {
				VerticalOptions=LayoutOptions.Center,
				Format="D"
			};
			layout.Children.Add (dtfinal,
				Constraint.Constant (20),
				Constraint.Constant (250),
				Constraint.RelativeToParent ((Parent) => {
					return 100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));

			Picker pkTipoAhorro = new Picker () {
				Title = "Tipo de ahorro"
			};

			layout.Children.Add (pkTipoAhorro,
				Constraint.Constant (20),
				Constraint.Constant (275),
				Constraint.RelativeToParent ((Parent) => {
					return 100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));






			// Dictionary to get Color from color name.
			Dictionary<string, int> tiposMetas = new Dictionary<string, int>
			{
				{ "Emprendimiento", 1 }, 
				{ "Personal", 2 }
			};

			//Picker picker = new Picker
			//{
			//	Title = "Tipo de meta",
			//	VerticalOptions = LayoutOptions.CenterAndExpand
			//};

			foreach (string tipoMeta in tiposMetas.Keys)
			{
				pkTipoMeta.Items.Add(tipoMeta);
			}

			//stk1.Children.Add (picker);


			Content = layout;

		}

		private void cargarImagenes(){
			//imgMeta1.Source = ImageSource.FromResource ("PaZos.Resources.meta1.png");
			// = ImageSource.FromResource ("PaZos.Resources.fondapp.png");
		}

	}
}

