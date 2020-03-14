using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace O_MAF.Models
{
    public class InitiateRepository
    {
        private static List<InitiateResponse> responses = new List<InitiateResponse>();
        public static IEnumerable<InitiateResponse> Responses
        {
            get
            { return responses; }
        }
        public static void AddResponse(InitiateResponse response)
        {
            responses.Add(response);
        }
    }
}
