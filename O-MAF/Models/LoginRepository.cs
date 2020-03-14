using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace O_MAF.Models
{
    public class LoginRepository
    {
        private static List<LoginResponse> responses = new List<LoginResponse>();
        public static IEnumerable<LoginResponse> Responses                                 
        {
            get
            { return responses; }
        }
        public static void AddResponse(LoginResponse response)                             
        {
            responses.Add(response);
        }
    }
}
