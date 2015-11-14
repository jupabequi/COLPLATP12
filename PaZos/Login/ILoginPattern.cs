using System;

namespace PaZos
{
	public interface ILoginManager {
		void ShowMainPage ();
		void Logout();
		void ShowRegistro ();
		void ShowLogin(string usuario);
	}
}

