using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PaZos
{
	public partial class MainPage : MasterDetailPage
	{
		public MainPage ()
		{
			

			Detail = new NavigationPage (new Metas (this));
			Master = new MenuPage (this);



		}

/*		void NavigateTo(MenuItem menu)
		{
			Page displayPage = (Page)Activator.CreateInstance (menu.Tar

		}*/
	}
}

