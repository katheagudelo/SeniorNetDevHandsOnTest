 using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace DataLayer.Controllers
{
    public class ApiControllerBase
    {
        private HttpClient Client { get; set; }
        

        public ApiControllerBase()
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri($"http://masglobaltestapi.azurewebsites.net/api/Employees");           
            Client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public HttpResponseMessage Get()
        {
            return Client.GetAsync(Client.BaseAddress).Result;
        }
    }
}
