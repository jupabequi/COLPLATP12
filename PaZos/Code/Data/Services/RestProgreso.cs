﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PaZos
{
	public class RestProgreso
	{
		#region "Attributes"
		private HttpClient client;
		private string ServiceUrl = String.Format(Constants.ServiceUrl, "progreso");
		#endregion

		public RestProgreso ()
		{
			client = new HttpClient ();
			client.MaxResponseContentBufferSize = 256000;
		}

		public async Task<List<eMetas>> get (Usuario usuario)
		{			


			try 
			{
				var json = JsonConvert.SerializeObject (usuario);

				var uri = new Uri (string.Format (ServiceUrl + "?action=1&usuario={0}", json));

				var response = await client.GetAsync (uri);
				if (response.IsSuccessStatusCode) {
					var content = await response.Content.ReadAsStringAsync ();
					return JsonConvert.DeserializeObject <List<eMetas>> (content);
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

