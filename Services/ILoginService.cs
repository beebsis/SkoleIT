using SkoleIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkoleIT.Services
{
    public interface ILoginService
    {
        Task<LoginApi> Authenticate(LoginRequest loginRequest);
        
    }
}
