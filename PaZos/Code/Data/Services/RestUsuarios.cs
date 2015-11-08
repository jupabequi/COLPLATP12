using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PaZos
{
	public class RestUsuarios
	{
		#region "Attributes"
		private HttpClient client;
		private string ServiceUrl = String.Format(Constants.ServiceUrl, "usuarios");
		#endregion

		public RestUsuarios ()
		{
			client = new HttpClient ();
			client.MaxResponseContentBufferSize = 256000;
		}

		public async Task<List<Usuario>> get ()
		{			
			var uri = new Uri (ServiceUrl);

			try 
			{
				var response = await client.GetAsync (uri);
				if (response.IsSuccessStatusCode) {
					var content = await response.Content.ReadAsStringAsync ();
					return JsonConvert.DeserializeObject <List<Usuario>> (content);
				}
				return null;
			} catch (Exception ex) 
			{
				Debug.WriteLine (@"ERROR {0}", ex.Message);
				return null;
			}				
		}

		public async Task<bool> insert(Usuario user)
		{
			var uri = new Uri (ServiceUrl);

			try 
			{
				var response = await client.GetAsync (uri);
				if (response.IsSuccessStatusCode) {
					return true;
				}
				return false;
			} catch (Exception ex) 
			{
				Debug.WriteLine (@"ERROR {0}", ex.Message);
				return false;
			}
		}
	}


}

