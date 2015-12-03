using System;

using Xamarin.Forms;


namespace PaZos
{
	public class App : Application, ILoginManager
	{

		static ILoginManager loginManager;
		public static App Current;
		public static Application CurrentApp
		{
			get { return Current; }
		}


		public App ()
		{
			Current = this;

			var isLoggedIn = Properties.ContainsKey("IsLoggedIn")?(bool)Properties ["IsLoggedIn"]:false;

			var user = Properties.ContainsKey("usuario")?Properties ["usuario"]:null;

			// we remember if they're logged in, and only display the login page if they're not
			if (isLoggedIn && user!=null) {

				Usuario usu = new Usuario ();

				usu.Id = (int)user;
				usu.nombre = "";
				usu.ocupacion = "";
				usu.pais = 1;
				usu.genero = 0;
				usu.apellidos = "";

				int usuario = (int)Properties ["usuario"];
				MainPage = new PaZos.MainPage (usu);
			}
			else
				//MainPage = new LoginModalPage (this);
				MainPage = new inicio (this);

			//MainPage = new NavigationPage(new PaZos.Inicio ());
		}

		public void ShowMainPage (Usuario usuario, int opc)
		{	
			if (opc == 0) {
				MainPage = new MainPage (usuario);
			} else {
				MainPage = new MainPage (usuario,1);
			}
		}


		public void ShowRegistro ()
		{	
			MainPage = new PaZos.RegistroModalPage (this);
		}

		public void ShowLogin (string usuario)
		{	
			MainPage = new PaZos.LoginModalPage (this, usuario);
		}
		public void ShowOlvido ()
		{	
			MainPage = new PaZos.OlvidasteContrasena ();
		}

		public void Logout ()
		{
			Properties ["IsLoggedIn"] = false; // only gets set to 'true' on the LoginPage
			MainPage = new PaZos.inicio(this);

		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

