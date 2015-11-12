using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PaZos
{
	public partial class MainPage : MasterDetailPage
	{
		public MainPage ()
		{
			var menupage = new MenuPage (this);

			//menupage.lbAcciones.Clicked += (sender, e) => NavigateTo (2);

			Detail = new NavigationPage (new Metas (this));
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


	}
}

