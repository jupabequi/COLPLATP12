using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaZos
{
	public partial class Inicio : ContentPage
	{
		public Inicio ()
		{
			//InitializeComponent ();




			Button btiniciasesion = new Button {
				Text = "Inicia sesión",
				VerticalOptions=LayoutOptions.Center,
				BorderWidth=1
			};
			btiniciasesion.Clicked += OnbtiniciasesionClick;


			Label lblnotiene = new Label {
				Text = "¿No tienes cuenta de PaZos?"
			};
			Button btCrearcuenta = new Button {
				Text = "Crear cuenta"
			};



			RelativeLayout relativeLayaut = new RelativeLayout ();



			relativeLayaut.Children.Add (btiniciasesion, 
				Constraint.RelativeToParent ((parent) => {
					return parent.Width/2-btiniciasesion.Width/2;
				}),
				Constraint.RelativeToParent ((parent) => {
					return parent.Height/2;
				})
			);

			relativeLayaut.Children.Add (btCrearcuenta, 
				Constraint.RelativeToParent ((parent) => {
					return parent.Width/2;
				}),
				Constraint.RelativeToParent ((parent) => {
					return parent.Height/2+50;
				})
			);

			relativeLayaut.Children.Add (lblnotiene, 
				Constraint.RelativeToParent ((parent) => {
					return parent.Width/2;
				}),
				Constraint.RelativeToParent ((parent) => {
					return parent.Height/2+35;
				})
			);


			this.Content = relativeLayaut;

		}

		void OnbtiniciasesionClick(object sender, EventArgs e)
		{


			//Navigation.PushAsync (new Login ());


			/*Button button = (Button)sender;
			await DisplayAlert("Clicked!",
				"The button labeled '" + button.Text + "' has been clicked",
				"OK");*/
		}
	}
}

