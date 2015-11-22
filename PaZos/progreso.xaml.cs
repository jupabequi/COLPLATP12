using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace PaZos
{
	public partial class progreso : ContentPage
	{
		MasterDetailPage master;
		private NavigationPage NPdias;

		Usuario usuario;
		List<eMetas> ListaMeta;

		int Id;
		AsisprinPicker pkTipoMeta;
		Entry entmeta;
		ExtendedEntry entvalor;
		AsisprinDatePicker dtinicio;
		DatePicker dtfinal;
		Entry entacumulado;
		Entry porcentaje;


		int Id2;
		Picker pkTipoMeta2;
		Entry entmeta2;
		ExtendedEntry entvalor2;
		ExtendedDatePicker dtinicio2;
		DatePicker dtfinal2;
		Entry entacumulado2;
		Entry porcentaje2;


		int Id3;
		Picker pkTipoMeta3;
		Entry entmeta3;
		ExtendedEntry entvalor3;
		ExtendedDatePicker dtinicio3;
		DatePicker dtfinal3;
		Entry entacumulado3;
		Entry porcentaje3;


		public progreso (MasterDetailPage masterDetail, Usuario tusuario)
		{
			this.Title = "Progreso";
			usuario = tusuario;

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



			int y = 20;

			int y2 = y;



			y = y - 7;
			pkTipoMeta = new AsisprinPicker () {
				Title = "Tipo de meta",
				IsEnabled = false
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
			entmeta = new ExtendedEntry () {
				Placeholder = "Escribe tu meta",
				Font = Font.OfSize("TwCenMT-Condensed",26),
				IsEnabled=false
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

			Image imgMeta1 = new Image () {
				Aspect = Aspect.AspectFill,
				Source = ImageSource.FromResource ("PaZos.Resources.Metas.btnmeta1.png")

			};
			layout.Children.Add (imgMeta1,
				Constraint.Constant (20),
				Constraint.Constant (y2),
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
				Constraint.Constant (y2+13),
				Constraint.RelativeToParent ((Parent) => {
					return 175;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));

			y = y + 40 + 2;
			entvalor = new ExtendedEntry() {
				Placeholder = "$",
				Font = Font.OfSize("TwCenMT-Condensed",28),
				XAlign= TextAlignment.End,
				IsEnabled=false
			};

			//entvalor.Behaviors.Add (new NumberValidatorBehavior ());

			layout.Children.Add (entvalor,
				Constraint.Constant (20),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/2;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));



			Label lbinicia = new Label () {
				Text = "Inicia",
				FontSize = 14,
				FontFamily = "TwCenMT-Condensed",
			};
			layout.Children.Add (lbinicia,
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/2+5+20;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4-5;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 10;
				}));





			dtinicio = new AsisprinDatePicker () {
				VerticalOptions = LayoutOptions.Center,
				Format = "dd/MM/yyyy",
				IsEnabled=false
			};


			layout.Children.Add (dtinicio,
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/2+5+20;
				}),
				Constraint.Constant (y+10),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4-5;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));	

			Label lbTermina = new Label () {
				Text = "Termina",
				FontSize = 14,
				FontFamily = "TwCenMT-Condensed",
			};
			layout.Children.Add (lbTermina,
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4*3+5+20;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4-5;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 10;
				}));

			dtfinal = new AsisprinDatePicker () {
				VerticalOptions = LayoutOptions.Center,
				Format = "dd/MM/yyyy",
				IsEnabled=false
			};
			layout.Children.Add (dtfinal,
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4*3+5+20;
				}),
				Constraint.Constant (y+10),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4-5;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));

			y = y + 40 + 2;
			entacumulado = new ExtendedEntry () {
				Font = Font.OfSize("TwCenMT-Condensed",24),
				XAlign = TextAlignment.End,
				IsEnabled=false
			};
			layout.Children.Add (entacumulado,
				Constraint.Constant (20),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-50)/2;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));
			porcentaje = new ExtendedEntry () {
				Font = Font.OfSize("TwCenMT-Condensed",24),
				XAlign = TextAlignment.Center,
				IsEnabled=false
			};
			layout.Children.Add (porcentaje,
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width)/2+5;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-50)/2;
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

			y2 = y;

			y = y - 7;
			pkTipoMeta2 = new AsisprinPicker () {
				Title = "Tipo de meta",
				IsEnabled=false
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
			entmeta2 = new ExtendedEntry () {
				Placeholder = "Escribe tu meta",
				Font = Font.OfSize("TwCenMT-Condensed",26),
				IsEnabled=false
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
			entvalor2 = new ExtendedEntry() {
				Placeholder = "$",
				Font = Font.OfSize("TwCenMT-Condensed",28),
				XAlign= TextAlignment.End,
				IsEnabled=false
			};
			//entvalor2.Behaviors.Add (new NumberValidatorBehavior ());
			layout.Children.Add (entvalor2,
				Constraint.Constant (20),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/2;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));



			Image imgMeta2 = new Image () {
				Aspect = Aspect.AspectFill,
				Source=  ImageSource.FromResource ("PaZos.Resources.Metas.btmeta2.png")

			};
			layout.Children.Add (imgMeta2,
				Constraint.Constant (20),
				Constraint.Constant (y2),
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
				Constraint.Constant (y2+13),
				Constraint.RelativeToParent ((Parent) => {
					return 175;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));

			Label lbinicia2 = new Label () {
				Text = "Inicia",
				FontSize = 14,
				FontFamily = "TwCenMT-Condensed",
			};
			layout.Children.Add (lbinicia2,
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/2+5+20;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4-5;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 10;
				}));

			dtinicio2 = new AsisprinDatePicker () {
				VerticalOptions = LayoutOptions.Center,
				Format = "dd/MM/yyyy",
				IsEnabled=false
			};
			layout.Children.Add (dtinicio2,
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/2+5+20;
				}),
				Constraint.Constant (y+10),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4-5;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));	


			Label lbTermina2 = new Label () {
				Text = "Termina",
				FontSize = 14,
				FontFamily = "TwCenMT-Condensed",
			};
			layout.Children.Add (lbTermina2,
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4*3+5+20;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4-5;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 10;
				}));

			dtfinal2 = new AsisprinDatePicker () {
				VerticalOptions = LayoutOptions.Center,
				Format = "dd/MM/yyyy",
				IsEnabled=false
			};
			layout.Children.Add (dtfinal2,
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4*3+5+20;
				}),
				Constraint.Constant (y+10),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4-5;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));


			y = y + 40 + 2;
			entacumulado2 = new ExtendedEntry () {
				Font = Font.OfSize("TwCenMT-Condensed",24),
				IsEnabled=false,
				XAlign=TextAlignment.End
			};
			layout.Children.Add (entacumulado2,
				Constraint.Constant (20),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-50)/2;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));
			porcentaje2 = new ExtendedEntry () {
				Font = Font.OfSize("TwCenMT-Condensed",24),
				IsEnabled=false,
				XAlign=TextAlignment.Center
			};
			layout.Children.Add (porcentaje2,
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width)/2+5;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-50)/2;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));




			y = y + 30+10;
			y2 = y;
			y = y - 7;



			pkTipoMeta3 = new AsisprinPicker () {
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
			entmeta3 = new ExtendedEntry () {
				Placeholder = "Escribe tu meta",
				Font = Font.OfSize("TwCenMT-Condensed",26),
				IsEnabled=false
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

			Image imgMeta3 = new Image () {
				Aspect = Aspect.AspectFill,
				Source=  ImageSource.FromResource ("PaZos.Resources.Metas.btnmeta3.png")

			};
			layout.Children.Add (imgMeta3,
				Constraint.Constant (20),
				Constraint.Constant (y2),
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
				Constraint.Constant (y2+13),
				Constraint.RelativeToParent ((Parent) => {
					return 175;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));


			y = y + 40 + 2;
			entvalor3 = new ExtendedEntry() {
				Placeholder = "$",
				Font = Font.OfSize("TwCenMT-Condensed",28),
				XAlign= TextAlignment.End,
				IsEnabled=false
			};
			//entvalor3.Behaviors.Add (new NumberValidatorBehavior ());
			layout.Children.Add (entvalor3,
				Constraint.Constant (20),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/2;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));


			Label lbinicia3 = new Label () {
				Text = "Inicia",
				FontSize = 14,
				FontFamily = "TwCenMT-Condensed",
			};
			layout.Children.Add (lbinicia3,
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/2+5+20;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4-5;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 10;
				}));
			dtinicio3 = new AsisprinDatePicker () {
				VerticalOptions = LayoutOptions.Center,
				Format = "dd/MM/yyyy",
				IsEnabled=false
			};
			layout.Children.Add (dtinicio3,
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/2+5+20;
				}),
				Constraint.Constant (y+10),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4-5;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));	

			Label lbTermina3 = new Label () {
				Text = "Termina",
				FontSize = 14,
				FontFamily = "TwCenMT-Condensed",
			};
			layout.Children.Add (lbTermina3,
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4*3+5+20;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4-5;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 10;
				}));
			dtfinal3 = new AsisprinDatePicker () {
				VerticalOptions = LayoutOptions.Center,
				Format = "dd/MM/yyyy",
				IsEnabled=false
			};
			layout.Children.Add (dtfinal3,
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4*3+5+20;
				}),
				Constraint.Constant (y+10),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/4-5;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));

			y = y + 40 + 2;
			entacumulado3 = new ExtendedEntry () {
				Font = Font.OfSize("TwCenMT-Condensed",24),
				IsEnabled=false,
				XAlign=TextAlignment.End
			};
			layout.Children.Add (entacumulado3,
				Constraint.Constant (20),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-50)/2;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));
			porcentaje3 = new ExtendedEntry () {
				Font = Font.OfSize("TwCenMT-Condensed",24),
				IsEnabled=false,
				XAlign = TextAlignment.Center
			};
			layout.Children.Add (porcentaje3,
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width)/2+5;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-50)/2;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));


			Label lbespacio = new Label () {
				Text = " "
			};
			layout.Children.Add (lbespacio,
				Constraint.Constant (20),
				Constraint.Constant (y+30),
				Constraint.RelativeToParent ((Parent) => {
					return 150;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 10;
				}));


			foreach (string tipoMeta in tiposMetas.Keys) {
				pkTipoMeta.Items.Add (tipoMeta);
				pkTipoMeta2.Items.Add (tipoMeta);
				pkTipoMeta3.Items.Add (tipoMeta);
			}


			ScrollView scrollview = new ScrollView {

				Content = layout

			};


			Content = scrollview;
			cargarMetas ();
		}

		public async void cargarMetas(){
			
			ListaMeta = await new RestProgreso ().get (usuario);


			Id = ListaMeta [0].Id;
			pkTipoMeta.SelectedIndex = ListaMeta[0].tipo;
			entmeta.Text=ListaMeta[0].meta;
			entvalor.Text="$ " + Convert.ToString(ListaMeta[0].valor);
			dtinicio.Date= Convert.ToDateTime(ListaMeta[0].fechainicio);
			dtfinal.Date=Convert.ToDateTime(ListaMeta[0].fechaFinal);
			entacumulado.Text = "$ " + ListaMeta [0].acumulado.ToString();
			porcentaje.Text = ListaMeta [0].porcentaje.ToString() + "%";

			Id2 = ListaMeta [1].Id;
			pkTipoMeta2.SelectedIndex = ListaMeta[1].tipo;
			entmeta2.Text=ListaMeta[1].meta;
			entvalor2.Text="$ " + Convert.ToString(ListaMeta[1].valor);
			dtinicio2.Date=Convert.ToDateTime(ListaMeta[1].fechainicio);
			dtfinal2.Date=Convert.ToDateTime(ListaMeta[1].fechaFinal);
			entacumulado2.Text ="$ " + ListaMeta [1].acumulado.ToString();
			porcentaje2.Text = ListaMeta [1].porcentaje.ToString()+"%";

			Id3 = ListaMeta [2].Id;
			pkTipoMeta3.SelectedIndex = ListaMeta[2].tipo;
			entmeta3.Text=ListaMeta[2].meta;
			entvalor3.Text="$ " + Convert.ToString(ListaMeta[2].valor);
			dtinicio3.Date=Convert.ToDateTime(ListaMeta[2].fechainicio);
			dtfinal3.Date=Convert.ToDateTime(ListaMeta[2].fechaFinal);
			entacumulado3.Text = "$ " + ListaMeta [2].acumulado.ToString();
			porcentaje3.Text = ListaMeta [2].porcentaje.ToString() + "%";

		}
	}
}

