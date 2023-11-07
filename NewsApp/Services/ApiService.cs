using System;
using Newtonsoft.Json;
using NewsApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Services
{
    public class ApiService
    {
        public async Task<Root> GetNews(string categoryNamer)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync($"");
            return JsonConvert.DeserializeObject<Root>(response);
        }
    }
}
