using Newtonsoft.Json;
using EdaApp.Client.Models;

namespace EdaApp.Client.Services
{
    public static class ItemService
    {
        private static HttpClient client = new HttpClient();

        public static async Task<List<Item>> GetAll()
        {
            HttpResponseMessage response = await client.GetAsync("https://localhost:7147/item");
            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<Item>>(json);
        }

    }
}
