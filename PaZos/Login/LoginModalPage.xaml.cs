using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PaZos
{
	public partial class LoginModalPage : CarouselPage
	{
		ContentPage login, create;
		public LoginModalPage (ILoginManager ilm)
		{
			login = new Login (ilm);
			create = new Registro (ilm);
			this.Children.Add (login);
			this.Children.Add (create);

			MessagingCenter.Subscribe<ContentPage> (this, "Login", (sender) => {
				this.SelectedItem = login;
			});
			MessagingCenter.Subscribe<ContentPage> (this, "Create", (sender) => {
				this.SelectedItem = create;
			});
		}
	}
}

