using SkoleIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SkoleIT.Services
{

    public class StudentCardService
    {
        HttpClient httpClient;
        public StudentCardService()
        {
            httpClient = new HttpClient();
        }

        StudentCard studentCard = new();
        public async Task<StudentCard> getStudentCard()
        {
            if(studentCard != null)
            {
                return studentCard;
            }

            var url = "https://svt.elthoro.dk/?pass=elev&item=card&id=1";

            var response = await httpClient.GetAsync(url);

            if(response.IsSuccessStatusCode)
            {
                studentCard = await response.Content.ReadFromJsonAsync<StudentCard>();
            }

            return studentCard;
        }
    }
}
