using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using SkoleIT.Models;

namespace SkoleIT.Services
{
    public class LoginService : ILoginService
    {
        public static string Base64Encode(string plainText, string plainText1)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText + "," + plainText1);
            return System.Convert.ToBase64String(plainTextBytes);
        }

       

        public async Task<LoginApi> Authenticate (LoginRequest loginRequest)
        {
            HttpClientHandler httpClientHandler = new HttpClientHandler()
            {
                Credentials = new NetworkCredential(loginRequest.Login, loginRequest.Password),
            };
            var url = "https://svt.elthoro.dk/basic.php";
            using (var client = new RestClient(url))
            {
                var request = new RestRequest(url, Method.Get);
                request.AddHeader("Authorization", "Basic QWlsZTY4OTg6RXJEZXR0ZT9NOUNvZGU=");
                var body = @"";
                request.AddParameter("text/plain", body, ParameterType.RequestBody);
                RestResponse response = client.Execute(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var json = response.ToString();
                    Debug.WriteLine(response.Content);
                    return JsonConvert.DeserializeObject<LoginApi>(json);
                   // return null;
                }
                else
                {
                    return null;
                }
            }


            /*using (var client = new HttpClient(httpClientHandler))
            {
                string loginrequestStr = JsonConvert.SerializeObject(loginRequest);
                //string loginrequestStr = Base64Encode(loginRequest.Login, loginRequest.Password);
                var response = await client.PostAsync("https://svt.elthoro.dk/basic.php",
                    new StringContent(loginrequestStr, Encoding.UTF8, "application/json"));

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<LoginApi>(json);
                }
                else
                {
                    return null;
                }
            }*/
        }
    }
}
