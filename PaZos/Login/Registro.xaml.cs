using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace PaZos
{
	public partial class Registro : ContentPage
	{

		Picker pkPais;
		Picker pkDepartamento;
		Picker pkCiudad;
		List<Paises> ListaPaises;
		List<Departamentos> ListaDepartamentos;
		List<Ciudades> ListaCiudades;


		public Registro (ILoginManager ilm)
		{

			this.Title = "Registro";

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


			BoxView bv = new BoxView () {
				BackgroundColor = Color.FromRgb(232,78,27)
			};
			layout.Children.Add (bv,
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 60;
				}));

			Label titulo = new Label () {
				Text="Registro",
				FontSize = 24,
				FontFamily = "TwCenMT-Condensed",
				TextColor = Color.White,
				HorizontalOptions=LayoutOptions.Center,
				XAlign= TextAlignment.Center
			};
			layout.Children.Add (titulo,
				Constraint.Constant (0),
				Constraint.Constant (25),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 60;
				}));

			var logo = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.pazosicon.png"),
				Aspect = Aspect.AspectFill
			};

			layout.Children.Add (logo,
				Constraint.Constant (15),
				Constraint.Constant (15),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));
			

			int alto = 35;
			int ytemp = 70;


			var txtNombre = new ExtendedEntry () {
				Placeholder="Nombre",
				BackgroundColor = Color.White,
				Font = Font.OfSize("TwCenMT-Condensed",18),
				HasBorder=true
			};

			txtNombre.Behaviors.Add (new MaxLengthValidator { MaxLength = 40 });

			layout.Children.Add (txtNombre,
				Constraint.Constant (50),
				Constraint.Constant (ytemp),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));
			ytemp = ytemp + alto;
			var txtApellido = new ExtendedEntry () {
				Placeholder="Apellido",
				BackgroundColor = Color.White,
				Font = Font.OfSize("TwCenMT-Condensed",18),
				HasBorder=true
			};
			layout.Children.Add (txtApellido,
				Constraint.Constant (50),
				Constraint.Constant (ytemp),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));

			txtApellido.Behaviors.Add (new MaxLengthValidator { MaxLength = 40 });


			ytemp = ytemp + alto+10;
			var txtCorreo = new ExtendedEntry () {
				Placeholder="Correo electrónico",
				BackgroundColor = Color.White,
				Font = Font.OfSize("TwCenMT-Condensed",18),
				HasBorder=true
			};
			layout.Children.Add (txtCorreo,
				Constraint.Constant (50),
				Constraint.Constant (ytemp),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));
			txtCorreo.Behaviors.Add (new EmailValidatorBehavior());


			ytemp = ytemp + alto;
			var txtUsuario = new ExtendedEntry () {
				Placeholder="Usuario (Nombre para mostrar)",
				BackgroundColor = Color.White,
				Font = Font.OfSize("TwCenMT-Condensed",18),
				HasBorder=true
			};
			layout.Children.Add (txtUsuario,
				Constraint.Constant (50),
				Constraint.Constant (ytemp),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));
			txtUsuario.Behaviors.Add (new MaxLengthValidator { MaxLength = 12 });

			ytemp = ytemp + alto+10;
			var txtclave = new ExtendedEntry () {
				Placeholder="Contraseña",
				BackgroundColor = Color.White,
				Font = Font.OfSize("TwCenMT-Condensed",18),
				HasBorder=true,
				IsPassword=true
			};
			layout.Children.Add (txtclave,
				Constraint.Constant (50),
				Constraint.Constant (ytemp),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));
			txtclave.Behaviors.Add (new MaxLengthValidator { MaxLength = 12 });

			ytemp = ytemp + alto;
			var txtclave2 = new ExtendedEntry () {
				Placeholder="Repetir contraseña",
				BackgroundColor = Color.White,
				Font = Font.OfSize("TwCenMT-Condensed",18),
				HasBorder=true,
				IsPassword=true
			};
			layout.Children.Add (txtclave2,
				Constraint.Constant (50),
				Constraint.Constant (ytemp),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));

			txtclave2.Behaviors.Add (new MaxLengthValidator { MaxLength = 12 });

			ytemp = ytemp + alto+10;
			var txtedad = new AsisprinPicker () {
				Title="Edad",
				BackgroundColor = Color.White
			};



			int i = 12;
			while (i<60)
			{
				txtedad.Items.Add(i.ToString());
				i++;
			}
			layout.Children.Add (txtedad,
				Constraint.Constant (50),
				Constraint.Constant (ytemp),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-100)/2-5;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));




			var pksexo = new AsisprinPicker () {
				Title="Sexo",
				BackgroundColor = Color.White
			};
			Dictionary<string, int> tiposexo = new Dictionary<string, int>
			{
				{ "Masculino", 1 }, 
				{ "Femenino", 2 },
				{ "LGBTI", 3 }
			};
			foreach (string tSexo in tiposexo.Keys)
			{
				pksexo.Items.Add(tSexo);
			}
			layout.Children.Add (pksexo,
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width/2)+5;
				}),
				Constraint.Constant (ytemp),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width-100)/2-5;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));

			ytemp = ytemp + alto+10;
			pkPais = new AsisprinPicker () {
				Title="Pais",
				BackgroundColor = Color.White
			};


			pkPais.SelectedIndex = 1;
			layout.Children.Add (pkPais,
				Constraint.Constant (50),
				Constraint.Constant (ytemp),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));
			pkPais.SelectedIndexChanged += (object sender, EventArgs e) => {
				ListarDepartamentos ();
			};
				

			ytemp = ytemp + alto;
			pkDepartamento = new AsisprinPicker () {
				Title="Departamento",
				BackgroundColor = Color.White
			};


			layout.Children.Add (pkDepartamento,
				Constraint.Constant (50),
				Constraint.Constant (ytemp),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));

			pkDepartamento.SelectedIndexChanged += (object sender, EventArgs e) => {
				ListarCiudades ();
			};

			ytemp = ytemp + alto;
			pkCiudad = new AsisprinPicker () {
				Title="Ciudad o municipio",
				BackgroundColor = Color.White
			};


			layout.Children.Add (pkCiudad,
				Constraint.Constant (50),
				Constraint.Constant (ytemp),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));

			ytemp = ytemp + alto+10;
			var button = new Button { Text = "Registrar usuario",
				BackgroundColor = Color.Gray,
				TextColor = Color.White,
				Font = Font.OfSize("TwCenMT-Condensed",22)
			};
			button.Clicked += (sender, e) => {



				/*if (txtNombre.Text=="" || txtNombre.Text == null){

					DisplayActionSheet("Resgistro sin completar","Cancelar","ok",null);
					return;
				}*/
				Usuario Ruser = new Usuario();

				Ruser.nombre = txtNombre.Text;
				Ruser.apellidos = txtApellido.Text;
				Ruser.correo = txtCorreo.Text;
				Ruser.ciudad = pkCiudad.SelectedIndex;
				Ruser.contrasena=txtclave.Text;
				Ruser.departamento=pkDepartamento.SelectedIndex;
				Ruser.genero=pksexo.SelectedIndex;
				Ruser.edad=txtedad.SelectedIndex;
				Ruser.ocupacion="";
				Ruser.pais=pkPais.SelectedIndex;
				Ruser.usuario=txtUsuario.Text;



				registrausuario(Ruser);

				//DisplayAlert("Cuenta creada", "Add processing login here", "OK");
				ilm.ShowLogin(txtUsuario.Text);
			};
			layout.Children.Add (button,
				Constraint.Constant (50),
				Constraint.Constant (ytemp),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));
			/*
			ytemp = ytemp + alto+10;
			var lbmen1 = new Label () {
				Text = "Si continúas, aceptas las",
				VerticalOptions = LayoutOptions.Center
			};
			layout.Children.Add (lbmen1,
				Constraint.Constant (50),
				Constraint.Constant (ytemp),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 50;
				}));
			ytemp = ytemp + 20;
			var lbmen2 = new Label () {
				Text = "condiciones de uso de la aplicación",
				VerticalOptions = LayoutOptions.Center,
				Font = Font.OfSize("TwCenMT-Condensed",22)
			};
			layout.Children.Add (lbmen2,
				Constraint.Constant (50),
				Constraint.Constant (ytemp),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 50;
				}));
			ytemp = ytemp + 20;
			var lbmen3 = new Label () {
				Text = "y la política de privacidad.",
				VerticalOptions = LayoutOptions.Center,
				Font = Font.OfSize("TwCenMT-Condensed",22)
			};
			layout.Children.Add (lbmen3,
				Constraint.Constant (50),
				Constraint.Constant (ytemp),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 50;
				}));


			var cancel = new Button { Text = "Cancel" };
			cancel.Clicked += (sender, e) => {



				MessagingCenter.Send<ContentPage> (this, "Login");
			};
*/

			ScrollView scrollview = new ScrollView {

				Content = layout

			};



			Content = scrollview;



				/*new StackLayout {
				Padding = new Thickness (10, 40, 10, 10),
				Children = {
					imgBackground,
					new Label { Text = "Create Account", Font = Font.SystemFontOfSize(NamedSize.Large) }, 
					new Label { Text = "Choose a Username" },
					new Entry { Text = "" },
					new Label { Text = "Password" },
					new Entry { Text = "" },
					new Label { Text = "Re-enter Password" },
					new Entry { Text = "" },
					button, cancel
				}
			};*/
		}

		protected async override void OnAppearing ()
		{
			base.OnAppearing ();



			ListaPaises = await new RestPaises().get();

			if (ListaPaises != null) {

				foreach (Paises tPais in ListaPaises) {
					pkPais.Items.Add (tPais.nombre);
				}
			} else {
				DisplayAlert ("Acceso a datos", "Problemas en la comunicación.", "Aceptar");
			}



			/*var ListaCiudades = await new RestPaises ().getCiudades();
			foreach (Ciudades tCiudad in ListaCiudades)
			{
				pkCiudad.Items.Add(tCiudad.nombre);
			}*/

			//var s = await new RestUsuarios().get();
			Label e = new Label ();
		}

		public async void registrausuario(Usuario RUSER){

			var respuesta = await new RestUsuarios().insert(RUSER);

		}
		protected async void ListarDepartamentos(){

			if (pkPais.SelectedIndex != -1) {
				ListaDepartamentos = await new RestPaises ().getDepartamentos (ListaPaises [pkPais.SelectedIndex]);

				if (ListaDepartamentos != null) {
					foreach (Departamentos tDepartamento in ListaDepartamentos) {
						pkDepartamento.Items.Add (tDepartamento.nombre);
					}
				} else {
					DisplayAlert ("Acceso a datos", "Problemas en la comunicación.", "Aceptar");
				}
			}

		}


		protected async void ListarCiudades(){

			if (pkDepartamento.SelectedIndex != -1) {
				ListaCiudades = await new RestPaises ().getCiudades (ListaDepartamentos [pkDepartamento.SelectedIndex]);
				if (ListaCiudades != null) {
					foreach (Ciudades tCiudades in ListaCiudades) {
						pkCiudad.Items.Add (tCiudades.nombre);
					}
				} else {
					DisplayAlert ("Acceso a datos", "Problemas en la comunicación.", "Aceptar");
				}
			}

		}
	



	}
}

