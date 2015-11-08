using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace PaZos
{
	public partial class Registro : ContentPage
	{
		public Registro (ILoginManager ilm)
		{

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

			int alto = 40;
			int ytemp = 70;


			var txtNombre = new ExtendedEntry () {
				Placeholder="Nombre",
				BackgroundColor = Color.White
			};
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
				BackgroundColor = Color.White
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

			ytemp = ytemp + alto+10;
			var txtCorreo = new ExtendedEntry () {
				Placeholder="Correo electrónico",
				BackgroundColor = Color.White
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
			ytemp = ytemp + alto;
			var txtUsuario = new ExtendedEntry () {
				Placeholder="Usuario (Nombre para mostrar)",
				BackgroundColor = Color.White
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

			ytemp = ytemp + alto+10;
			var txtclave = new ExtendedEntry () {
				Placeholder="Contraseña",
				BackgroundColor = Color.White
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

			ytemp = ytemp + alto;
			var txtclave2 = new ExtendedEntry () {
				Placeholder="Repetir contraseña",
				BackgroundColor = Color.White
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

			ytemp = ytemp + alto+10;
			var txtedad = new ExtendedPicker () {
				Title="Edad",
				BackgroundColor = Color.White
			};
			int i = 0;
			while (i<100)
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

			var pksexo = new ExtendedPicker () {
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
			var pkPais = new ExtendedPicker () {
				Title="Pais",
				BackgroundColor = Color.White
			};
			Dictionary<string, int> Dpaises = new Dictionary<string, int>
			{
				{ "Colombia", 1 }, 
				{ "Perú", 2 },
				{ "Chile", 3 }
			};
			foreach (string tPais in Dpaises.Keys)
			{
				pkPais.Items.Add(tPais);
			}
			layout.Children.Add (pkPais,
				Constraint.Constant (50),
				Constraint.Constant (ytemp),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));

			ytemp = ytemp + alto;
			var pkDepartamento = new ExtendedPicker () {
				Title="Departamento",
				BackgroundColor = Color.White
			};
			Dictionary<string, int> Ddepartamento = new Dictionary<string, int>
			{
				{ "Bogotá D.C.", 1 }, 
				{ "Cundinamarca", 2 },
				{ "Antioquia", 3 }
			};
			foreach (string tDepartamento in Ddepartamento.Keys)
			{
				pkDepartamento.Items.Add(tDepartamento);
			}
			layout.Children.Add (pkDepartamento,
				Constraint.Constant (50),
				Constraint.Constant (ytemp),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return alto;
				}));

			ytemp = ytemp + alto;
			var pkCiudad = new ExtendedPicker () {
				Title="Ciudad o municipio",
				BackgroundColor = Color.White
			};
			Dictionary<string, int> Dciudad = new Dictionary<string, int>
			{
				{ "DC", 1 }, 
				{ "Chía", 2 },
				{ "Sopo", 3 }
			};
			foreach (string tCiudad in Dciudad.Keys)
			{
				pkCiudad.Items.Add(tCiudad);
			}
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
			var button = new Button { Text = "Iniciar sesión",
				BackgroundColor = Color.Gray,
				TextColor = Color.White
			};
			button.Clicked += (sender, e) => {
				DisplayAlert("Cuenta creada", "Add processing login here", "OK");
				ilm.ShowMainPage();
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
				VerticalOptions = LayoutOptions.Center
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
				VerticalOptions = LayoutOptions.Center
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





			Content = layout;



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
	}
}

