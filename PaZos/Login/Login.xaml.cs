﻿using System;
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

			var button = new Button { 
				Text = "Iniciar sesión",
				FontSize = 24,
				TextColor = Color.FromHex("#FFFFFF"),
				FontAttributes = FontAttributes.Bold
			};
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



			embeddedImage.Source = ImageSource.FromResource ("PaZos.Resources.login.png");

				


			username = new Entry { Text = "Usuario",
            TextColor=Color.Black
            };
			//username.WidthRequest = 280;

			password = new Entry { Text = "Contrasena",
            TextColor=Color.Black };
			//password.WidthRequest = 280;



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

			//abslayout.Children.Add (new Label { Text = "Iniciar sesión", FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)) }, new Point (30, 30));
			//abslayout.Children.Add (new Label { Text = "Username" }, new Point (40, 40));
			abslayout.Children.Add (username, 
				Constraint.Constant (38),
				Constraint.Constant (342),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 50;
				}));
			//abslayout.Children.Add (new Label { Text = "Password" }, new Point (50, 50));
			abslayout.Children.Add (password, 
				Constraint.Constant (38),
				Constraint.Constant (395),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 50;
				}));
			abslayout.Children.Add (button,  
				Constraint.Constant (30),
				Constraint.Constant (460),
				Constraint.RelativeToParent ((Parent) => {
					return 305;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 60;
				}));
			//abslayout.Children.Add (create, new Point (80, 80));



			/*ScrollView scrollview = new ScrollView {
								
				Content = abslayout

			};*/

			Content = abslayout;
			//Content = scrollview;
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
