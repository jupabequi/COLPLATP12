using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PaZos
{
	public partial class MainPage : MasterDetailPage 
	{

		Usuario usuario;

		public MainPage (Usuario tusuario)
		{
			usuario = tusuario;
			var menupage = new MenuPage (this, usuario);

			//menupage.lbAcciones.Clicked += (sender, e) => NavigateTo (2);

			//Detail = new NavigationPage (new Metas (this,usuario));
			Detail = new NavigationPage (new Preguntas (this,usuario));
			//Detail = new NavigationPage (new acciones ());
			Master = menupage;



		}

		void NavigateTo (int menu)
		{
			
			//((NavigationPage)this.Detail).PushAsync(new acciones(mas));
			/*Page displayPage = (Page)Activator.CreateInstance (typeof(acciones));

			Detail = new NavigationPage (displayPage);*/


			IsPresented = false;
		}


		public void showMetas ()
		{	
			Detail = new NavigationPage (new PaZos.Metas (this,usuario));
		}

	}
}

