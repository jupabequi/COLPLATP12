using System;

namespace PaZos
{
	public interface ILoginManager {
		void ShowMainPage (Usuario usuario,int opc);
		void Logout();
		void ShowRegistro ();
		void ShowLogin(string usuario);
		void ShowOlvido();
	}
}

