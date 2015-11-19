using System;

namespace PaZos
{
	public interface ILoginManager {
		void ShowMainPage (Usuario usuario);
		void Logout();
		void ShowRegistro ();
		void ShowLogin(string usuario);
	}
}

