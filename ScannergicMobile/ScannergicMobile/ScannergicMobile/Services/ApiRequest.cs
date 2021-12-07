using ScannergicMobile.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace ScannergicMobile.Services
{
    /// <summary>
    /// This class manage and make calls to the API 
    /// </summary>
    public class ApiRequest
    {
        /// <summary>
        /// The principal server URL where the api is.
        /// </summary>
        public const string SERVER_URL = "http://192.168.42.220:5000";

        /// <summary>
        /// Get the list of all Allergens 
        /// </summary>
        /// <returns>The list of all allergens</returns>
        public async Task<List<Allergen>> GetAllAllergensAsync()
        {
            List<Allergen> allergens = new List<Allergen>(0);

            HttpClient client = InitializeHttpClient();
            HttpResponseMessage response = await client.GetAsync("/scannergic/allergens");
            if (response.IsSuccessStatusCode)
            {
                string jsonReponse = await response.Content.ReadAsStringAsync();
                allergens = JsonConvert.DeserializeObject<AllergensContainer>(jsonReponse).Allergens;
            }
            else
            {
                throw new ServerException();
            }
            return allergens;
        }

        private HttpClient InitializeHttpClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(SERVER_URL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }
    }

    public class ApiRequestException : Exception{}
    public class ServerException : ApiRequestException { }
}
