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
			Detail = new NavigationPage (new Metas (this,usuario));
			Master = menupage;

			//menupage.lbAcciones.Clicked += (sender, e) => NavigateTo (2);

			//Detail = new NavigationPage (new Metas (this,usuario));

			//Detail = new NavigationPage (new acciones ());

		}
		public MainPage (Usuario tusuario,int opcb)
		{
			usuario = tusuario;

			var menupage = new MenuPage (this, usuario);
			Detail = new NavigationPage (new progreso (this,usuario));
			Master = menupage;

			//menupage.lbAcciones.Clicked += (sender, e) => NavigateTo (2);

			//Detail = new NavigationPage (new Metas (this,usuario));

			//Detail = new NavigationPage (new acciones ());

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

		public void showProgreso()
		{
			//Detail = new NavigationPage (new PaZos.progreso (this,usuario));
			((NavigationPage)this.Detail).PushAsync(new progreso(this,usuario));
		}

	



	}
}

