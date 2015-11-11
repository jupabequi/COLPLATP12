using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XLabs.Forms.Controls;

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
				Text = "¿Para qué quieres ahorrar?",
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
				Text = "Ingresa aquí, en orden de prioridad, 3 ",
				FontFamily = "MyriadPro-Regular",
				FontSize=13
			};
			fs.Spans.Add (sp1);
			Span sp2 = new Span () {
				Text = " metas especificas de ahorro.",
				FontFamily = "MyriadPro-Regular",
				FontSize=13
			};
			fs.Spans.Add (sp2);
			Span sp3 = new Span () {
				Text = " Define si tus metas son ",
				FontFamily = "MyriadPro-Regular",
				FontSize=13
			};
			fs.Spans.Add (sp3);
			Span sp4 = new Span () {
				Text = "personales, ",
				FontFamily = "MyriadPro-Bold",
				FontSize=13
			};
			fs.Spans.Add (sp4);
			Span sp5 = new Span () {
				Text = " o para tu ",
				FontFamily = "MyriadPro-Regular",
				FontSize=13
			};
			fs.Spans.Add (sp5);
			Span sp6 = new Span () {
				Text = "emprendimiento",
				FontFamily = "MyriadPro-Bold",
				FontSize=13
			};
			fs.Spans.Add (sp6);	
			lbtexto.FormattedText = fs;

			layout.Children.Add (lbtexto,
				Constraint.Constant (20),
				Constraint.Constant (22),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-40;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 80;
				}));	

			int y = 80;

			Image imgMeta1 = new Image () {
				Aspect = Aspect.AspectFill,
				Source = ImageSource.FromResource ("PaZos.Resources.Metas.btnmeta1.png")

			};
			layout.Children.Add (imgMeta1,
				Constraint.Constant (20),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 175;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));	
			var lbMeta1 = new Label()
			{
				Text = "Meta 1",
				TextColor = Color.White,
				FontSize=26,
				FontFamily =  "MyriadPro-Bold",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center
			};
			layout.Children.Add (lbMeta1,
				Constraint.Constant (70),
				Constraint.Constant (y+13),
				Constraint.RelativeToParent ((Parent) => {
					return 175;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));


			Picker pkTipoMeta = new Picker () {
				Title = "Tipo de meta"
			};
			layout.Children.Add (pkTipoMeta,
				Constraint.Constant (199),
				Constraint.Constant (y+22),
				Constraint.RelativeToParent ((Parent) => {
					return ParentView.Width-199-20;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));	

				

			y = y + 52 + 3;
			Entry entmeta = new ExtendedEntry () {
				Placeholder = "Escribe tu meta"
			};
			layout.Children.Add (entmeta,
				Constraint.Constant (20),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-40;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));	


			y = y + 40 + 2;
			var entvalor = new ExtendedEntry() {
				Placeholder = "$"
			};
			layout.Children.Add (entvalor,
				Constraint.Constant (20),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/2;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));


			ExtendedDatePicker dtinicio = new ExtendedDatePicker () {
				VerticalOptions = LayoutOptions.Center,
				Format = "dd/MM/yyyy"
			};
			layout.Children.Add (dtinicio,
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/2+5+20;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4-5;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));	

			DatePicker dtfinal = new DatePicker () {
				VerticalOptions = LayoutOptions.Center,
				Format = "dd/MM/yyyy"
			};
			layout.Children.Add (dtfinal,
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4*3+5+20;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4-5;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));

			y = y + 30 + 2;
			Picker pkTipoAhorro = new Picker () {
				Title = "Tipo de ahorro"
			};

			layout.Children.Add (pkTipoAhorro,
				Constraint.Constant (20),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 150;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));






			// Dictionary to get Color from color name.
			Dictionary<string, int> tiposMetas = new Dictionary<string, int> {
				{ "Emprendimiento", 1 }, 
				{ "Personal", 2 }
			};

			//Picker picker = new Picker
			//{
			//	Title = "Tipo de meta",
			//	VerticalOptions = LayoutOptions.CenterAndExpand
			//};



			//stk1.Children.Add (picker);




			y = y + 30 + 10;
			Image imgMeta2 = new Image () {
				Aspect = Aspect.AspectFill,
				Source=  ImageSource.FromResource ("PaZos.Resources.Metas.btmeta2.png")

			};
			layout.Children.Add (imgMeta2,
				Constraint.Constant (20),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 175;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));	
			var lbMeta2 = new Label()
			{
				Text = "Meta 2",
				TextColor = Color.White,
				FontSize=26,
				FontFamily =  "MyriadPro-Bold",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center
			};
			layout.Children.Add (lbMeta2,
				Constraint.Constant (70),
				Constraint.Constant (y+13),
				Constraint.RelativeToParent ((Parent) => {
					return 175;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));


			Picker pkTipoMeta2 = new Picker () {
				Title = "Tipo de meta"
			};
			layout.Children.Add (pkTipoMeta2,
				Constraint.Constant (199),
				Constraint.Constant (y+22),
				Constraint.RelativeToParent ((Parent) => {
					return ParentView.Width-199-20;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));	



			y = y + 52 + 3;
			Entry entmeta2 = new ExtendedEntry () {
				Placeholder = "Escribe tu meta"
			};
			layout.Children.Add (entmeta2,
				Constraint.Constant (20),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-40;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));	


			y = y + 40 + 2;
			var entvalor2 = new ExtendedEntry() {
				Placeholder = "$"
			};
			layout.Children.Add (entvalor2,
				Constraint.Constant (20),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/2;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));


			ExtendedDatePicker dtinicio2 = new ExtendedDatePicker () {
				VerticalOptions = LayoutOptions.Center,
				Format = "dd/MM/yyyy"
			};
			layout.Children.Add (dtinicio2,
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/2+5+20;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4-5;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));	

			DatePicker dtfinal2 = new DatePicker () {
				VerticalOptions = LayoutOptions.Center,
				Format = "dd/MM/yyyy"
			};
			layout.Children.Add (dtfinal2,
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4*3+5+20;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4-5;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));

			y = y + 30 + 2;
			Picker pkTipoAhorro2 = new Picker () {
				Title = "Tipo de ahorro"
			};

			layout.Children.Add (pkTipoAhorro2,
				Constraint.Constant (20),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 150;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));
			



			y = y + 30+10;
			Image imgMeta3 = new Image () {
				Aspect = Aspect.AspectFill,
				Source=  ImageSource.FromResource ("PaZos.Resources.Metas.btnmeta3.png")

			};
			layout.Children.Add (imgMeta3,
				Constraint.Constant (20),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 175;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));

			var lbMeta3 = new Label()
			{
				Text = "Meta 3",
				TextColor = Color.White,
				FontSize=26,
				FontFamily =  "MyriadPro-Bold",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center
			};
			layout.Children.Add (lbMeta3,
				Constraint.Constant (70),
				Constraint.Constant (y+13),
				Constraint.RelativeToParent ((Parent) => {
					return 175;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));


			Picker pkTipoMeta3 = new Picker () {
				Title = "Tipo de meta"
			};
			layout.Children.Add (pkTipoMeta3,
				Constraint.Constant (199),
				Constraint.Constant (y+22),
				Constraint.RelativeToParent ((Parent) => {
					return ParentView.Width-199-20;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));	



			y = y + 52 + 3;
			Entry entmeta3 = new ExtendedEntry () {
				Placeholder = "Escribe tu meta"
			};
			layout.Children.Add (entmeta3,
				Constraint.Constant (20),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-40;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));	


			y = y + 40 + 2;
			var entvalor3 = new ExtendedEntry() {
				Placeholder = "$"
			};
			layout.Children.Add (entvalor3,
				Constraint.Constant (20),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/2;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));


			ExtendedDatePicker dtinicio3 = new ExtendedDatePicker () {
				VerticalOptions = LayoutOptions.Center,
				Format = "dd/MM/yyyy"
			};
			layout.Children.Add (dtinicio3,
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/2+5+20;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4-5;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));	

			DatePicker dtfinal3 = new DatePicker () {
				VerticalOptions = LayoutOptions.Center,
				Format = "dd/MM/yyyy"
			};
			layout.Children.Add (dtfinal3,
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4*3+5+20;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4-5;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));

			y = y + 30 + 2;
			Picker pkTipoAhorro3 = new Picker () {
				Title = "Tipo de ahorro"
			};

			layout.Children.Add (pkTipoAhorro3,
				Constraint.Constant (20),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 150;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));
			
			
		

	

			foreach (string tipoMeta in tiposMetas.Keys) {
				pkTipoMeta.Items.Add (tipoMeta);
				pkTipoMeta2.Items.Add (tipoMeta);
				pkTipoMeta3.Items.Add (tipoMeta);
			}

			// Dictionary to get Color from color name.
			Dictionary<string, int> tiposAhorro = new Dictionary<string, int> {
				{ "Ahorro diario", 1 }, 
				{ "Ahorro semanal", 2 },
				{ "Ahorro mensual", 3 }
			};

			foreach (string tipoAhorro in tiposAhorro.Keys) {
				pkTipoAhorro.Items.Add (tipoAhorro);
				pkTipoAhorro2.Items.Add (tipoAhorro);
				pkTipoAhorro3.Items.Add (tipoAhorro);
			}

			ScrollView scrollview = new ScrollView {

				Content = layout

			};


			Content = scrollview;

		}

		private void cargarImagenes(){
			//imgMeta1.Source = ImageSource.FromResource ("PaZos.Resources.meta1.png");
			// = ImageSource.FromResource ("PaZos.Resources.fondapp.png");
		}

	}
}

