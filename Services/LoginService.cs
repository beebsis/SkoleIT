using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SkoleIT.Models;

namespace SkoleIT.Services
{
    public class LoginService 
    {
        public async Task<LoginApi> Login (string userName, string password)
        {
            var userInfo = new List<LoginApi>();
            var client= new HttpClient();

            string url = "https://svt.elthoro.dk/basic.php"+userName+"/"+password;

            client.BaseAddress = new Uri(url);
            HttpResponseMessage response = await client.GetAsync("");
            if (response.IsSuccessStatusCode)
            {
                string content=response.Content.ReadAsStringAsync().Result;

                // My api 

                userInfo=JsonConvert.DeserializeObject<List<LoginApi>>(content);

                return await Task.FromResult(userInfo.FirstOrDefault());
            } else
            {
                return null;
            }
        }
    }
}
