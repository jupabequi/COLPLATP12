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
	public class RestAccionesAhorradorasEjecucion
	{
		#region "Attributes"
		private HttpClient client;
		private string ServiceUrl = String.Format(Constants.ServiceUrl, "accionesAhorradorasEjecucion");
		#endregion

		public RestAccionesAhorradorasEjecucion ()
		{
			client = new HttpClient ();
			client.MaxResponseContentBufferSize = 256000;
		}

		public async Task<List<AccionesAhorradoras>> get (Usuario usuario)
		{			


			try 
			{
				var json = JsonConvert.SerializeObject (usuario);

				var uri = new Uri (string.Format (ServiceUrl + "?action=1&usuario={0}", json));

				var response = await client.GetAsync (uri);
				if (response.IsSuccessStatusCode) {
					var content = await response.Content.ReadAsStringAsync ();
					return JsonConvert.DeserializeObject <List<AccionesAhorradoras>> (content);
				}
				return null;
			} catch (Exception ex) 
			{
				Debug.WriteLine (@"ERROR {0}", ex.Message);
				return null;
			}				
		}


		public async Task<bool> guardar(AccionesAhorradorasEjecucion acciones)
		{



			try 
			{
				var json = JsonConvert.SerializeObject (acciones);
				var content = new StringContent (json, Encoding.UTF8, "application/json");

				var uri = new Uri (string.Format (ServiceUrl + "?action=2&accionAhorradorasEjecucion={0}", json));
				var response = await client.PostAsync (uri, content);
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

		public async Task<bool> actualizar(AccionesAhorradorasEjecucion acciones)
		{



			try 
			{
				var json = JsonConvert.SerializeObject (acciones);
				var content = new StringContent (json, Encoding.UTF8, "application/json");

				var uri = new Uri (string.Format (ServiceUrl + "?action=3&accionAhorradorasEjecucion={0}", json));
				var response = await client.PostAsync (uri, content);
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