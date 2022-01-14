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
        public const string SERVER_URL = "https://localhost:5001";

        /// <summary>
        /// Get the list of all Allergens 
        /// </summary>
        /// <returns>The list of all allergens</returns>
        public async Task<List<Allergen>> GetAllAllergensAsync()
        {
            return await GetAllergensRoute();
        }

        /// <summary>
        /// Get a list of allergens in a product
        /// </summary>
        /// <param name="barcode">The product barcode</param>
        /// <returns>The list of allergens contained in the product</returns>
        public async Task<List<Allergen>> GetAllergensInProduct(string barcode)
        {
            return await GetAllergensRoute(barcode);
        }

        /// <summary>
        /// Get the /api/allergens route in the API
        /// </summary>
        /// <param name="parameters">The filter for allergen</param>
        /// <returns>The list of allergens (all or with the parameter filter)</returns>
        private async Task<List<Allergen>> GetAllergensRoute(string parameters = ""){
            string urlConstructor = "/api/allergens";
            if(parameters.Length>0)
                            urlConstructor = urlConstructor+"/"+ parameters;

            HttpClient client = InitializeHttpClient();
            HttpResponseMessage response = await client.GetAsync(urlConstructor);
            if (response.IsSuccessStatusCode)
            {
                string jsonReponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<AllergensContainer>(jsonReponse).Allergens;
            }
            else if (response.StatusCode == HttpStatusCode.NotFound)
                throw new ResourceNotFoundException();
            else
                throw new ServerException();
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
    public class ResourceNotFoundException : ApiRequestException { }
}
