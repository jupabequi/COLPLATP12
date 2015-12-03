using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace PaZos
{
	public partial class Login : ContentPage
	{
		ExtendedEntry username, password;

		int respuesta;
		List<Usuario> usuario;


		public Login (ILoginManager ilm, string usuario)
		{

			var button = new Button { 
				Text = "Iniciar sesión",
				TextColor = Color.FromHex("#FFFFFF"),
				FontAttributes = FontAttributes.Bold,
				BackgroundColor = Color.Gray,
				Font = Font.OfSize("TwCenMT-Condensed",22)
			};
			button.Clicked += (sender, e) => {
				if (String.IsNullOrEmpty(username.Text) || String.IsNullOrEmpty(password.Text))
				{
					DisplayAlert("Error de validación", "Usuario y contraseña son requeridos", "Intente nuevamente");
				} else {
					// REMEMBER LOGIN STATUS!
					CompruebaUser(ilm);

				}
			};
			var create = new Button { Text = "Crear cuenta" };
			create.Clicked += (sender, e) => {
				MessagingCenter.Send<ContentPage> (this, "Create");
			};




			var embeddedImage = new Image { Aspect = Aspect.AspectFill };
			embeddedImage.Source = ImageSource.FromResource ("PaZos.Resources.FondoLogin.png");

				


			username = new ExtendedEntry {
             Placeholder="Usuario",
				BackgroundColor = Color.White,
				Font = Font.OfSize("TwCenMT-Condensed",18),
            };

			if (usuario != null) {
				username.Text = usuario;
			}
			//username.WidthRequest = 280;

			password = new ExtendedEntry { 
				Placeholder="Contraseña",
				BackgroundColor = Color.White,
				IsPassword=true,
				Font = Font.OfSize("TwCenMT-Condensed",18)

			};
			//password.WidthRequest = 280;

			var btnolvido = new Button {
				Text = "¿Olvidaste la contraseña?",
				TextColor = Color.Black,
				VerticalOptions = LayoutOptions.Center,
				Font = Font.OfSize("MyriadPro-Regular",12)
			};
			btnolvido.Clicked += (sender, e) => {
				olvido(ilm);
			};

			var abslayout = new RelativeLayout  ();


			abslayout.Children.Add(embeddedImage, 
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Height;
				}));

			var Personaje = new Image { Aspect = Aspect.AspectFit };
			Personaje.Source = ImageSource.FromResource ("PaZos.Resources.personajelogin.png");

			abslayout.Children.Add(Personaje, 
				Constraint.Constant (25),
				Constraint.Constant (50),
				Constraint.RelativeToParent ((Parent) => {
					if(Parent.Width-50>375)
					{
						return 375;	
					}else{
						return Parent.Width-50;
					}
				}),
				Constraint.RelativeToParent ((Parent) => {
					if(Parent.Width>375){
						return 350;
					}else{
						return (Parent.Width-50)*350/375;
					}
				}));



			int y = 50 + 350;
			//abslayout.Children.Add (new Label { Text = "Iniciar sesión", FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)) }, new Point (30, 30));
			//abslayout.Children.Add (new Label { Text = "Username" }, new Point (40, 40));
			abslayout.Children.Add (username, 
				Constraint.Constant (30),
				Constraint.RelativeToParent ((Parent) => {
					if(Parent.Width-50>375){
						return y;
					}else{
						return y-(350-((Parent.Width-50)*350/375));

					}

				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width - 60;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));
			//abslayout.Children.Add (new Label { Text = "Password" }, new Point (50, 50));
			abslayout.Children.Add (password, 
				Constraint.Constant (30),
				Constraint.RelativeToParent ((Parent) => {
					if(Parent.Width-50>375){
						return y+40;
					}else{
						return (y+40)-(350-((Parent.Width-50)*350/375));

					}

				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-60;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));
			abslayout.Children.Add (button,  
				Constraint.Constant (30),
				Constraint.RelativeToParent ((Parent) => {
					if(Parent.Width-50>375){
						return y+40*2+10;
					}else{
						return (y+40*2+10)-(350-((Parent.Width-50)*350/375));

					}

				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width - 60;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));

			abslayout.Children.Add (btnolvido,  
				Constraint.Constant (30),
				Constraint.RelativeToParent ((Parent) => {
					if(Parent.Width-50>375){
						return y+40*2+10+50;
					}else{
						return (y+40*2+10+50)-(350-((Parent.Width-50)*350/375));

					}

				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width - 60;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));

			//abslayout.Children.Add (create, new Point (80, 80));



			ScrollView scrollview = new ScrollView {
								
				Content = abslayout

			};

			//Content = abslayout;
			Content = scrollview;
			/*Content = new StackLayout {
				Padding = new Thickness (10, 40, 10, 10),
				Children = {
					new Label { Text = "Login", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) }, 
					new Label { Text = "Username" },
					username,
					new Label { Text = "Password" },
					password,
					button, create,

				}
			};*/



		}

		protected async void CompruebaUser(ILoginManager ilm){

			respuesta = 0;
			string txtprueba;
			usuario = await new RestUsuarios ().get(username.Text,password.Text);


			//DisplayAlert("Error de validación", usuario.Count.ToString(), "Intente nuevamente");

			if (usuario.Count > 0) {
				respuesta = 1;
			}

			if(respuesta==1){

				App.Current.Properties["IsLoggedIn"] = true;
				App.Current.Properties ["usuario"] = usuario[0].Id;

				List<respuesta> resp = await new RestMetas ().validar (usuario[0]);


				ilm.ShowMainPage (usuario [0], resp[0].cantidad);

			}else{
				DisplayAlert("Error de validación", "Usuario o contraseña incorrecto.", "Intente nuevamente");
			}



		

		}

		public async void validar(){




		}

		public void olvido(ILoginManager ilm){
			ilm.ShowOlvido ();
		}

	}
}

