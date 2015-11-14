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
	public class RestPaises
	{
		#region "Attributes"
		private HttpClient client;
		private string ServiceUrl = String.Format(Constants.ServiceUrl, "paises");
		private string ServiceUrlDepartamentos = String.Format(Constants.ServiceUrl, "departamentos");
		private string ServiceUrlCiudades = String.Format(Constants.ServiceUrl, "ciudades");
		#endregion

		public RestPaises ()
		{
			client = new HttpClient ();
			client.MaxResponseContentBufferSize = 256000;
		}

		public async Task<List<Paises>> get ()
		{			
			var uri = new Uri (string.Format (ServiceUrl + "?action=1", string.Empty));

			try 
			{
				var response = await client.GetAsync (uri);
				if (response.IsSuccessStatusCode) {
					var content = await response.Content.ReadAsStringAsync ();
					return JsonConvert.DeserializeObject <List<Paises>> (content);
				}
				return null;
			} catch (Exception ex) 
			{
				Debug.WriteLine (@"ERROR {0}", ex.Message);
				return null;
			}				
		}

		public async Task<List<Departamentos>> getDepartamentos (Paises pais)
		{			
			

			try 
			{

				var json = JsonConvert.SerializeObject (pais);
				var uri = new Uri (string.Format (ServiceUrlDepartamentos + "?action=1&pais={0}", json));

				var response = await client.GetAsync (uri);
				if (response.IsSuccessStatusCode) {
					var content = await response.Content.ReadAsStringAsync ();
					return JsonConvert.DeserializeObject <List<Departamentos>> (content);
				}
				return null;
			} catch (Exception ex) 
			{
				Debug.WriteLine (@"ERROR {0}", ex.Message);
				return null;
			}				
		}


		public async Task<List<Ciudades>> getCiudades (Departamentos departamento)
		{			
			

			try 
			{
				var json = JsonConvert.SerializeObject (departamento);
				var uri = new Uri (string.Format (ServiceUrlCiudades + "?action=1&departamento={0}", json));

				var response = await client.GetAsync (uri);
				if (response.IsSuccessStatusCode) {
					var content = await response.Content.ReadAsStringAsync ();
					return JsonConvert.DeserializeObject <List<Ciudades>> (content);
				}
				return null;
			} catch (Exception ex) 
			{
				Debug.WriteLine (@"ERROR {0}", ex.Message);
				return null;
			}				
		}

	}


}

