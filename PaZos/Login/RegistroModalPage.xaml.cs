using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PaZos
{
	public partial class RegistroModalPage : CarouselPage
	{
		ContentPage login, create;
		public RegistroModalPage (ILoginManager ilm)
		{
			login = new Login (ilm);
			create = new Registro (ilm);

			this.Children.Add (create);
			this.Children.Add (login);



			MessagingCenter.Subscribe<ContentPage> (this, "Create", (sender) => {
				this.SelectedItem = create;
			});
			MessagingCenter.Subscribe<ContentPage> (this, "Login", (sender) => {
				this.SelectedItem = login;
			});
		}
	}
}

