using System;
using System.Net.Http;
using System.Text;
using MarineLife.Services.Models;
using Newtonsoft.Json;

namespace MarineLife.Services.HttpClients
{
    public class FishHttpClient : IFishHttpClient
    {
        private readonly HttpClient _httpClient;
        public FishHttpClient(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://fishbase.ropensci.org/species?");
            _httpClient = httpClient;
        }
        public FishApi GetFishInfo(string species, string genus)
        {

            var baseAddress = "https://fishbase.ropensci.org/species?";
            var url = $"species={species}&genus={genus}";
            var completeUrl = baseAddress + url;
            
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(completeUrl),
                Method = HttpMethod.Get,
                Content = new StringContent(completeUrl, Encoding.UTF8, "application/json")
            };
            
            var response = _httpClient.SendAsync(request);
           
            if (!response.Result.IsSuccessStatusCode)
            {
                var reason = response.Result.ReasonPhrase;
                return new FishApi();
            }
            
            var data = response.Result.Content.ReadAsByteArrayAsync().Result;
            var dataString = Encoding.UTF8.GetString(data, 0, data.Length);
            //var data = response.Result.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<FishApi>(dataString);
            
            return result;
        }
    }
}