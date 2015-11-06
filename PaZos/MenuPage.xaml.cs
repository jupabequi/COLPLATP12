using System;
using System.Collections.Generic;


using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace PaZos
{
	public partial class MenuPage : ContentPage
	{

		ObservableCollection<MenuItem> Items;


		MasterDetailPage master;

		TableView tableView;

		private NavigationPage metas;
		private NavigationPage acciones;
		private NavigationPage evaluacion;
		private NavigationPage progreso;
		private NavigationPage acerca;


		public MenuPage (MasterDetailPage masterDetail)
		{
			
	
	
			Title = "-";
			//Icon = "slideout.png";
			master = masterDetail;

			var embeddedImage = new Image { Aspect = Aspect.AspectFill };
			embeddedImage.Source = ImageSource.FromResource ("PaZos.Resources.meta.png");
			embeddedImage.WidthRequest = 50;
			embeddedImage.HeightRequest = 50;


			ImageCell imgMeta = new ImageCell ();
			imgMeta.ImageSource = ImageSource.FromResource ("PaZos.Resources.meta.png");
			imgMeta.Tapped += (sender, args) => {
				Selected(1);
			};

			ImageCell imgAcciones = new ImageCell ();
			imgAcciones.ImageSource = ImageSource.FromResource ("PaZos.Resources.Acciones.png");
			imgAcciones.Tapped += (sender, args) => {
				Selected(2);
			};

			ImageCell imgEvaluacion = new ImageCell ();
			imgEvaluacion.ImageSource = ImageSource.FromResource ("PaZos.Resources.Evaluacion.png");
			imgEvaluacion.Tapped += (sender, args) => {
				Selected(3);
			};

			ImageCell imgprogreso = new ImageCell ();
			imgprogreso.ImageSource = ImageSource.FromResource ("PaZos.Resources.progreso.png");
			imgprogreso.Tapped += (sender, args) => {
				Selected(4);
			};

			ImageCell imgacercade = new ImageCell ();
			imgacercade.ImageSource = ImageSource.FromResource ("PaZos.Resources.acercade.png");
			imgacercade.Tapped += (sender, args) => {
				Selected(5);
			};




			var section = new TableSection () {
				imgMeta,
				imgAcciones,
				imgEvaluacion,
				imgprogreso,
				imgacercade
			};






			var root = new TableRoot () {section} ;

			tableView = new TableView ()
			{ 
				Root = root,
				Intent = TableIntent.Menu,
				WidthRequest = 100
			};

			var logoutButton = new Button { Text = "Logout" };
			logoutButton.Clicked += (sender, e) => {
				App.Current.Logout();
			};

			Content = new StackLayout {
				BackgroundColor = Color.White,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = {
					tableView, 
					logoutButton
				}
			};

		}

		public void Selected(int option)
		{
			switch (option) {

			case 1:
				master.Detail = metas ??
					(metas = new NavigationPage (
					new Metas ()
				)
				);
				break;
			case 2:
				master.Detail = acciones ??
					(acciones = new NavigationPage (
					new acciones ()
				)
				);
				break;
			case 3:
				master.Detail = evaluacion ??
					(evaluacion = new NavigationPage (
					new evaluacion ()
				)
				);
				break;
			case 4:
				master.Detail = progreso ??
					(progreso = new NavigationPage (
					new progreso ()
				)
				);
				break;
			case 5:
				master.Detail = acerca ??
					(acerca = new NavigationPage (
					new acerca ()
				)
				);
				break;

			}

		}
	}
}

