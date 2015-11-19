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

		List<eMetas> ListaMeta;
		Usuario usuario;

		int Id;
		AsisprinPicker pkTipoMeta;
		Entry entmeta;
		ExtendedEntry entvalor;
		AsisprinDatePicker dtinicio;
		DatePicker dtfinal;
		Picker pkTipoAhorro;

		int Id2;
		Picker pkTipoMeta2;
		Entry entmeta2;
		ExtendedEntry entvalor2;
		ExtendedDatePicker dtinicio2;
		DatePicker dtfinal2;
		Picker pkTipoAhorro2;

		int Id3;
		Picker pkTipoMeta3;
		Entry entmeta3;
		ExtendedEntry entvalor3;
		ExtendedDatePicker dtinicio3;
		DatePicker dtfinal3;
		Picker pkTipoAhorro3;




		public Metas (MasterDetailPage masterDetail, Usuario tusuario)
		{

			usuario = tusuario;

			var guardaritem = new ToolbarItem {
				Text = "Guardar"
			};
			guardaritem.Clicked += (object sender, System.EventArgs e) => 
			{
				guardarMetas();
			};

			//ToolbarItems.Add(new ToolbarItem(){Icon="pazosicon.png"});
			ToolbarItems.Add(guardaritem);
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

			int y2 = y;



			y = y - 7;
			pkTipoMeta = new AsisprinPicker () {
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
			entmeta = new ExtendedEntry () {
				Placeholder = "Escribe tu meta",
				Font = Font.OfSize("TwCenMT-Condensed",26)
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
				XAlign= TextAlignment.End

			};
			entvalor.Unfocused += (object sender, FocusEventArgs e) => {
				if(Convert.ToDouble(entvalor.Text)>100000){
					enviamensaje();
				}
			};
			entvalor.Behaviors.Add (new NumberValidatorBehavior ());

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
				Format = "dd/MM/yyyy"
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
			pkTipoAhorro = new AsisprinPicker () {
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

			y2 = y;

			y = y - 7;
			pkTipoMeta2 = new AsisprinPicker () {
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
			entmeta2 = new ExtendedEntry () {
				Placeholder = "Escribe tu meta",
				Font = Font.OfSize("TwCenMT-Condensed",26)
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
				XAlign= TextAlignment.End
			};
			entvalor2.Behaviors.Add (new NumberValidatorBehavior ());
			layout.Children.Add (entvalor2,
				Constraint.Constant (20),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/2;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));
			entvalor2.Unfocused += (object sender, FocusEventArgs e) => {
				if(Convert.ToDouble(entvalor2.Text)>100000){
					enviamensaje();
				}
			};


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
				Format = "dd/MM/yyyy"
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
				Format = "dd/MM/yyyy"
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
			pkTipoAhorro2 = new AsisprinPicker () {
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
				Font = Font.OfSize("TwCenMT-Condensed",26)
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
				XAlign= TextAlignment.End
			};
			entvalor3.Behaviors.Add (new NumberValidatorBehavior ());
			layout.Children.Add (entvalor3,
				Constraint.Constant (20),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-40)/2;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));
			entvalor3.Unfocused += (object sender, FocusEventArgs e) => {
				if(Convert.ToDouble(entvalor3.Text)>100000){
					enviamensaje();
				}
			};


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
				Format = "dd/MM/yyyy"
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
				Format = "dd/MM/yyyy"
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
			pkTipoAhorro3 = new AsisprinPicker () {
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

			cargarMetas ();

		}

		private void cargarImagenes(){
			//imgMeta1.Source = ImageSource.FromResource ("PaZos.Resources.meta1.png");
			// = ImageSource.FromResource ("PaZos.Resources.fondapp.png");
		}

		public async void guardarMetas(){


			eMetas Lmeta = new eMetas ();
			eMetas Lmeta2 = new eMetas ();
			eMetas Lmeta3 = new eMetas ();

			Lmeta.Id = Id;
			Lmeta.tipo = pkTipoMeta.SelectedIndex;
			Lmeta.meta = entmeta.Text;
			Lmeta.valor = Convert.ToDouble(entvalor.Text);
			Lmeta.fechainicio = dtinicio.Date;
			Lmeta.fechaFinal = dtfinal.Date;
			Lmeta.tipoAhorro = pkTipoAhorro.SelectedIndex;

			Lmeta2.Id = Id2;
			Lmeta2.tipo = pkTipoMeta2.SelectedIndex;
			Lmeta2.meta = entmeta2.Text;
			Lmeta2.valor = Convert.ToDouble(entvalor2.Text);
			Lmeta2.fechainicio = dtinicio2.Date;
			Lmeta2.fechaFinal = dtfinal2.Date;
			Lmeta2.tipoAhorro = pkTipoAhorro2.SelectedIndex;

			Lmeta3.Id = Id3;
			Lmeta3.tipo = pkTipoMeta3.SelectedIndex;
			Lmeta3.meta = entmeta3.Text;
			Lmeta3.valor = Convert.ToDouble(entvalor3.Text);
			Lmeta3.fechainicio = dtinicio3.Date;
			Lmeta3.fechaFinal = dtfinal3.Date;
			Lmeta3.tipoAhorro = pkTipoAhorro3.SelectedIndex;

			var resultado = await new RestMetas().actualizar (Lmeta);
			var resultado2 = await new RestMetas().actualizar (Lmeta2);
			var resultado3 = await new RestMetas().actualizar (Lmeta3);

			DisplayAlert("Metas", "Metas actualizadas", "OK");
			//var respuesta = await new RestUsuarios().insert(RUSER);

		}

		public async void cargarMetas(){

			ListaMeta = await new RestMetas ().get (usuario);


			Id = ListaMeta [0].Id;
			pkTipoMeta.SelectedIndex = ListaMeta[0].tipo;
			entmeta.Text=ListaMeta[0].meta;
			entvalor.Text=Convert.ToString(ListaMeta[0].valor);
			dtinicio.Date= Convert.ToDateTime(ListaMeta[0].fechainicio);
			dtfinal.Date=Convert.ToDateTime(ListaMeta[0].fechaFinal);
			pkTipoAhorro.SelectedIndex=ListaMeta[0].tipoAhorro;

			Id2 = ListaMeta [1].Id;
			pkTipoMeta2.SelectedIndex = ListaMeta[1].tipo;
			entmeta2.Text=ListaMeta[1].meta;
			entvalor2.Text=Convert.ToString(ListaMeta[1].valor);
			dtinicio2.Date=Convert.ToDateTime(ListaMeta[1].fechainicio);
			dtfinal2.Date=Convert.ToDateTime(ListaMeta[1].fechaFinal);
			pkTipoAhorro2.SelectedIndex=ListaMeta[1].tipoAhorro;

			Id3 = ListaMeta [2].Id;
			pkTipoMeta3.SelectedIndex = ListaMeta[2].tipo;
			entmeta3.Text=ListaMeta[2].meta;
			entvalor3.Text=Convert.ToString(ListaMeta[2].valor);
			dtinicio3.Date=Convert.ToDateTime(ListaMeta[2].fechainicio);
			dtfinal3.Date=Convert.ToDateTime(ListaMeta[2].fechaFinal);
			pkTipoAhorro3.SelectedIndex=ListaMeta[2].tipoAhorro;

		}

		protected async override void OnAppearing ()
		{
			base.OnAppearing ();

			 
			/*
			ListaMeta = await new RestMetas ().get (usuario);


			Id = ListaMeta [0].Id;
			pkTipoMeta.SelectedIndex = ListaMeta[0].tipo;
			entmeta.Text=ListaMeta[0].meta;
			entvalor.Text=Convert.ToString(ListaMeta[0].valor);
			dtinicio.Date= Convert.ToDateTime(ListaMeta[0].fechainicio);
			dtfinal.Date=Convert.ToDateTime(ListaMeta[0].fechaFinal);
			pkTipoAhorro.SelectedIndex=ListaMeta[0].tipoAhorro;

			Id2 = ListaMeta [1].Id;
			pkTipoMeta2.SelectedIndex = ListaMeta[1].tipo;
			entmeta2.Text=ListaMeta[1].meta;
			entvalor2.Text=Convert.ToString(ListaMeta[1].valor);
			dtinicio2.Date=Convert.ToDateTime(ListaMeta[1].fechainicio);
			dtfinal2.Date=Convert.ToDateTime(ListaMeta[1].fechaFinal);
			pkTipoAhorro2.SelectedIndex=ListaMeta[1].tipoAhorro;

			Id3 = ListaMeta [2].Id;
			pkTipoMeta3.SelectedIndex = ListaMeta[2].tipo;
			entmeta3.Text=ListaMeta[2].meta;
			entvalor3.Text=Convert.ToString(ListaMeta[2].valor);
			dtinicio3.Date=Convert.ToDateTime(ListaMeta[2].fechainicio);
			dtfinal3.Date=Convert.ToDateTime(ListaMeta[2].fechaFinal);
			pkTipoAhorro3.SelectedIndex=ListaMeta[2].tipoAhorro;
*/
			/*var ListaCiudades = await new RestPaises ().getCiudades();
			foreach (Ciudades tCiudad in ListaCiudades)
			{
				pkCiudad.Items.Add(tCiudad.nombre);
			}*/

			//var s = await new RestUsuarios().get();
			Label e = new Label ();
		}

		protected void enviamensaje()
		{
			((NavigationPage)master.Detail).PushAsync(new PaZos.AccionesMensaje1(master));
		}

	}
}

