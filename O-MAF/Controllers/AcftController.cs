using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using O_MAF.Models;

namespace O_MAF.Controllers
{
    public class AcftController : Controller
    {
        public IActionResult Workload()
        {
            InitiateResponse[] array = {
                new InitiateResponse {Modex = 00, SysReason = "", Discrepancy="", Initiator="", Qual="", WkCtr="", AcftUp=true },
                new InitiateResponse {Modex = 01, SysReason = "", Discrepancy="", Initiator="", Qual="", WkCtr="", AcftUp=true },
                new InitiateResponse {Modex = 02, SysReason = "", Discrepancy="", Initiator="", Qual="", WkCtr="", AcftUp=true },
                new InitiateResponse {Modex = 03, SysReason = "", Discrepancy="", Initiator="", Qual="", WkCtr="", AcftUp=true },
                new InitiateResponse {Modex = 04, SysReason = "", Discrepancy="", Initiator="", Qual="", WkCtr="", AcftUp=true },

            };
            return View(array);
        }
    }    
}

