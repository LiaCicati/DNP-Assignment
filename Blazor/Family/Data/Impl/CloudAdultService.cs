using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Family.Models;


namespace Family.Data.Impl
{
    public class CloudAdultService : IAdultService

    {
        private string uri = "https://localhost:5003";
        private readonly HttpClient _client;

        public CloudAdultService()
        {
            _client = new HttpClient();
        }


        public async Task<IList<Adult>> GetAdults()
        {
            HttpResponseMessage responseMessage = await _client.GetAsync(uri + "/adults");
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception("Something went wrong");
            }

            string message = await responseMessage.Content.ReadAsStringAsync();
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            return result;
        }

        public async Task<HttpStatusCode> AddAdult(Adult adult)
        {
            string adultsAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(adultsAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await _client.PostAsync(uri + "/adults", content);
            return responseMessage.StatusCode;
        }

        public async Task RemoveAdult(int adultId)
        {
            await _client.DeleteAsync($"{uri}/adults/{adultId}");
        }
    }
}