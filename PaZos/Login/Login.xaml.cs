using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XLabs.Forms;

namespace PaZos
{
	public partial class Login : ContentPage
	{
		Entry username, password;

		public Login (ILoginManager ilm)
		{

			var button = new Button { Text = "Iniciar sesión" };
			button.Clicked += (sender, e) => {
				if (String.IsNullOrEmpty(username.Text) || String.IsNullOrEmpty(password.Text))
				{
					DisplayAlert("Error de validación", "Username y contraseña son requeridos", "Intente nuevamente");
				} else {
					// REMEMBER LOGIN STATUS!
					App.Current.Properties["IsLoggedIn"] = true;
					ilm.ShowMainPage();
				}
			};
			var create = new Button { Text = "Crear cuenta" };
			create.Clicked += (sender, e) => {
				MessagingCenter.Send<ContentPage> (this, "Create");
			};




			var embeddedImage = new Image { Aspect = Aspect.AspectFill };
			embeddedImage.Source = ImageSource.FromResource ("PaZos.Resources.iniciarsesion.png");
			embeddedImage.WidthRequest = 375;
			embeddedImage.HeightRequest = 680;

				

			username = new Entry { Text = "" };
			username.WidthRequest = 280;

			password = new Entry { Text = "" };
			password.WidthRequest = 280;



			var abslayout = new AbsoluteLayout ();
			abslayout.Children.Add(embeddedImage, new Point(0,-25));
			//abslayout.Children.Add (new Label { Text = "Iniciar sesión", FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)) }, new Point (30, 30));
			//abslayout.Children.Add (new Label { Text = "Username" }, new Point (40, 40));
			abslayout.Children.Add (username, new Point (45,420));
			//abslayout.Children.Add (new Label { Text = "Password" }, new Point (50, 50));
			abslayout.Children.Add (password, new Point (45, 480));
			abslayout.Children.Add (button, new Point (70,520));
			abslayout.Children.Add (create, new Point (80, 80));



			ScrollView scrollview = new ScrollView {
				
				Content = abslayout

			};

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


	}
}

