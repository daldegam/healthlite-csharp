using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Collections.Generic;


namespace healthapp
{
	public static class WebHandler
	{
		public static string endpoint = "http://192.168.10.122:8099";

		public static async Task<T> HttpGet<T>(string url) 
		{
			HttpClient client = new HttpClient ();
			client.DefaultRequestHeaders.Add ("ContentType", "application/json");

			HttpResponseMessage response = await client.GetAsync (endpoint + url);

			if (response.StatusCode == HttpStatusCode.OK) {
				string responseContent = await response.Content.ReadAsStringAsync ();
				return JsonConvert.DeserializeObject<T> (responseContent);
			} else {
				throw new HttpRequestException ();
			}
		}

		public static async Task<T> HttpPost<T>(string url, object parameters) 
		{
			HttpClient client = new HttpClient ();
			client.DefaultRequestHeaders.Add ("ContentType", "application/json");

			string postBody = JsonConvert.SerializeObject(parameters);

			HttpResponseMessage response = await client.PostAsync (endpoint + url, new StringContent(postBody, Encoding.UTF8, "application/json"));

			if (response.StatusCode == HttpStatusCode.OK) {
				string responseContent = await response.Content.ReadAsStringAsync ();
				return JsonConvert.DeserializeObject<T> (responseContent);
			} else {
				throw new HttpRequestException ();
			}
		}

		public static async Task<T> HttpPut<T>(string url, object parameters) 
		{
			HttpClient client = new HttpClient ();
			client.DefaultRequestHeaders.Add ("ContentType", "application/json");

			string postBody = JsonConvert.SerializeObject(parameters);

			HttpResponseMessage response = await client.PutAsync (endpoint + url, new StringContent(postBody, Encoding.UTF8, "application/json"));

			if (response.StatusCode == HttpStatusCode.OK) {
				string responseContent = await response.Content.ReadAsStringAsync ();
				return JsonConvert.DeserializeObject<T> (responseContent);
			} else {
				throw new HttpRequestException ();
			}
		}
	}
}

