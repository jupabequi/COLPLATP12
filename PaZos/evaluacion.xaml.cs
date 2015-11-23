using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace PaZos
{
	public partial class evaluacion : ContentPage
	{

		MasterDetailPage master;
		private NavigationPage NPdias;
		Usuario usuario;

		ExtendedEntry accion;
		ExtendedEntry accionvalor;
		int diaselected;

		public evaluacion (MasterDetailPage masterDetail, Usuario tusuario)
		{
			master = masterDetail;
			usuario = tusuario;

			var guardaritem = new ToolbarItem {
				Text = "Guardar"
			};
			guardaritem.Clicked += (object sender, System.EventArgs e) => 
			{
				guardarEvaluacion();
			};

			//ToolbarItems.Add(new ToolbarItem(){Icon="pazosicon.png"});
			ToolbarItems.Add(guardaritem);
			this.Title = "Evaluación del día";




			DateTime fecha = DateTime.Now;
			int dia = (int)fecha.DayOfWeek;
			if (dia == 0) {
				dia = 7;
			}
			diaselected= dia;
			dibuja (dia);

		}


		public void Selected(int dia)
		{
			diaselected= dia;
			dibuja (dia);
			//((NavigationPage)master.Detail).PushAsync(new PaZos.evaluacionDia(master, dia));
			/*NPdias = new NavigationPage (
				new evaluacionDia (master, dia)
			);

			master.Detail = NPdias;
			*/
		}

		public void dibuja(int dia){

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




			double y = 20, yinicial;

			yinicial = y;
			int gap;
			int hoy = dia;
			int alto = 40;
			gap = alto + 10;
			int espacio = alto*2+20+15;

			var imglunes = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.Dias.lunes.png"),
			};

			layout.Children.Add (imglunes,
				Constraint.RelativeToParent ((Parent) => {

					if(hoy==1){
						return 10;
					}else{
						return Parent.Width/2 - 125;
					}
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));

			var lblunes = new Button () {
				Text = "",
				TextColor = Color.White,
				//BackgroundColor = Color.Blue
			};
			lblunes.Clicked += (sender, args) => {
				Selected(1);
			};

			layout.Children.Add (lblunes,
				Constraint.RelativeToParent ((Parent) => {
					if(hoy==1){
						return 10;
					}else{
						return Parent.Width/2 - 125;
					}
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));



			if (hoy == 1) {

				y = y + espacio;
			}

			//martes

			var imgmartes = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.Dias.martes.png"),
			};

			layout.Children.Add (imgmartes,
				Constraint.RelativeToParent ((Parent) => {
					if(hoy==2){
						return 10;
					}else{
						return Parent.Width/2 - 125;
					}
				}),
				Constraint.Constant (y+gap),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));

			var lbmartes = new Button () {
				Text = "",
				TextColor = Color.White,
				//BackgroundColor = Color.Blue
			};
			lbmartes.Clicked += (sender, args) => {
				Selected(2);
			};

			layout.Children.Add (lbmartes,
				Constraint.RelativeToParent ((Parent) => {
					if(hoy==2){
						return 10;
					}else{
						return Parent.Width/2 - 125;
					}
				}),
				Constraint.Constant (y+gap),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));

			//miercoles
			if (hoy == 2) {

				y = y + espacio;
			}
			var imgmiercoles = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.Dias.miercoles.png"),
			};


			layout.Children.Add (imgmiercoles,
				Constraint.RelativeToParent ((Parent) => {
					if(hoy==3){
						return 10;
					}else{
						return Parent.Width/2 - 125;
					}
				}),
				Constraint.Constant (y+gap*2),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));


			var lbmiercoles = new Button () {
				Text = "",
				TextColor = Color.White,
				//BackgroundColor = Color.Blue
			};
			lbmiercoles.Clicked += (sender, args) => {
				Selected(3);
			};

			layout.Children.Add (lbmiercoles,
				Constraint.RelativeToParent ((Parent) => {
					if(hoy==3){
						return 10;
					}else{
						return Parent.Width/2 - 125;
					}
				}),
				Constraint.Constant (y+gap*2),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));

			//jueves
			if (hoy == 3) {

				y = y + espacio;
			}
			var imgjueves = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.Dias.Jueves.png"),
			};

			layout.Children.Add (imgjueves,
				Constraint.RelativeToParent ((Parent) => {
					if(hoy==4){
						return 10;
					}else{
						return Parent.Width/2 - 125;
					}
				}),
				Constraint.Constant (y+gap*3),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));

			var lbjueves = new Button () {
				Text = "",
				TextColor = Color.White,
				//BackgroundColor = Color.Blue
			};
			lbjueves.Clicked += (sender, args) => {
				Selected(4);
			};

			layout.Children.Add (lbjueves,
				Constraint.RelativeToParent ((Parent) => {
					if(hoy==4){
						return 10;
					}else{
						return Parent.Width/2 - 125;
					}
				}),
				Constraint.Constant (y+gap*3),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));

			//viernes
			if (hoy == 4) {

				y = y + espacio;
			}
			var imgviernes = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.Dias.Viernes.png")
			};


			layout.Children.Add (imgviernes,
				Constraint.RelativeToParent ((Parent) => {
					if(hoy==5){
						return 10;
					}else{
						return Parent.Width/2 - 125;
					}
				}),
				Constraint.Constant (y+gap*4),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));

			var lbviernes = new Button () {
				Text = "",
				TextColor = Color.White,
				//BackgroundColor = Color.Blue
			};
			lbviernes.Clicked += (sender, args) => {
				Selected(5);
			};

			layout.Children.Add (lbviernes,
				Constraint.RelativeToParent ((Parent) => {
					if(hoy==5){
						return 10;
					}else{
						return Parent.Width/2 - 125;
					}
				}),
				Constraint.Constant (y+gap*4),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));

			//sabado
			if (hoy == 5) {

				y = y + espacio;
			}
			var imgsabado = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.Dias.Sabado.png")
			};


			layout.Children.Add (imgsabado,
				Constraint.RelativeToParent ((Parent) => {
					if(hoy==6){
						return 10;
					}else{
						return Parent.Width/2 - 125;
					}
				}),
				Constraint.Constant (y+gap*5),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));

			var lbsabado = new Button () {
				Text = "",
				TextColor = Color.White,
				//BackgroundColor = Color.Blue
			};
			lbsabado.Clicked += (sender, args) => {
				Selected(6);
			};

			layout.Children.Add (lbsabado,
				Constraint.RelativeToParent ((Parent) => {
					if(hoy==6){
						return 10;
					}else{
						return Parent.Width/2 - 125;
					}
				}),
				Constraint.Constant (y+gap*5),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));


			//domingo
			if (hoy == 6) {

				y = y + espacio;
			}
			var imgdomingo = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.Dias.Domingo.png")
			};


			layout.Children.Add (imgdomingo,
				Constraint.RelativeToParent ((Parent) => {
					if(hoy==7){
						return 10;
					}else{
						return Parent.Width/2 - 125;
					}
				}),
				Constraint.Constant (y+gap*6),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));

			var lbdomingo = new Button () {
				Text = "",
				TextColor = Color.White,
				//BackgroundColor = Color.Blue
			};
			lbdomingo.Clicked += (sender, args) => {
				Selected(7);
			};

			layout.Children.Add (lbdomingo,
				Constraint.RelativeToParent ((Parent) => {
					if(hoy==7){
						return 10;
					}else{
						return Parent.Width/2 - 125;
					}
				}),
				Constraint.Constant (y+gap*6),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));

			Label lblhoyahorre = new Label () {
				Text = "Hoy ahorré en:",
				FontSize = 20,
				FontFamily = "MyriadPro-Bold",
				XAlign= TextAlignment.Center
			};
			layout.Children.Add (lblhoyahorre,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2 - 125;
				}),
				Constraint.Constant (yinicial+gap*(hoy)),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 20;
				}));


			accion = new ExtendedEntry(){
				Placeholder="Acción 1",
				Font = Font.OfSize("TwCenMT-Condensed",22)
			};
			layout.Children.Add (accion,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2 - 125;
				}),
				Constraint.Constant (yinicial+25+gap*(hoy)),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));

			accionvalor = new ExtendedEntry(){
				Placeholder="$",
				Font = Font.OfSize("TwCenMT-Condensed",22),
				XAlign = TextAlignment.End
			};
			accionvalor.Behaviors.Add (new NumberValidatorBehavior ());
			layout.Children.Add (accionvalor,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2;
				}),
				Constraint.Constant (yinicial+30+alto+gap*(hoy)),
				Constraint.RelativeToParent ((Parent) => {
					return 125;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));



			ScrollView scrollview = new ScrollView {

				Content = layout

			};




			Content = scrollview;


		}


		private async void guardarEvaluacion(){

			AccionesAhorradorasEjecucion acciones = new AccionesAhorradorasEjecucion ();

			acciones.uso = usuario.Id;
			acciones.accion = accion.Text;
			acciones.valor = Convert.ToDouble(accionvalor.Text);
			acciones.dia = diaselected;

			
			var resultado = await new RestAccionesAhorradorasEjecucion().guardar(acciones);

			DisplayAlert("Evaluación del día", "Acción actualizada", "OK");

			Selected (diaselected);
		}

	}
}

