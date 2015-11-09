using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace PaZos
{
	public partial class Login : ContentPage
	{
		ExtendedEntry username, password;

		public Login (ILoginManager ilm)
		{

			var button = new Button { 
				Text = "Iniciar sesión",
				FontSize = 24,
				TextColor = Color.FromHex("#FFFFFF"),
				FontAttributes = FontAttributes.Bold,
				BackgroundColor = Color.Gray
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
			embeddedImage.Source = ImageSource.FromResource ("PaZos.Resources.FondoLogin.png");

				


			username = new ExtendedEntry {
             Placeholder="Usuario",
				BackgroundColor = Color.White
            };
			//username.WidthRequest = 280;

			password = new ExtendedEntry { 
				Placeholder="Contraseña",
				BackgroundColor = Color.White
			
			};
			//password.WidthRequest = 280;

			var btnolvido = new Button {
				Text = "¿Olvidaste la contraseña?",
				TextColor = Color.Black,
				VerticalOptions = LayoutOptions.Center
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
					return 50;
				}));
			//abslayout.Children.Add (new Label { Text = "Password" }, new Point (50, 50));
			abslayout.Children.Add (password, 
				Constraint.Constant (30),
				Constraint.RelativeToParent ((Parent) => {
					if(Parent.Width-50>375){
						return y+50;
					}else{
						return (y+50)-(350-((Parent.Width-50)*350/375));

					}

				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-60;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 50;
				}));
			abslayout.Children.Add (button,  
				Constraint.Constant (30),
				Constraint.RelativeToParent ((Parent) => {
					if(Parent.Width-50>375){
						return y+50*2+10;
					}else{
						return (y+50*2+10)-(350-((Parent.Width-50)*350/375));

					}

				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width - 60;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 60;
				}));

			abslayout.Children.Add (btnolvido,  
				Constraint.Constant (30),
				Constraint.RelativeToParent ((Parent) => {
					if(Parent.Width-50>375){
						return y+50*2+10+70;
					}else{
						return (y+50*2+10+70)-(350-((Parent.Width-50)*350/375));

					}

				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width - 60;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
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

