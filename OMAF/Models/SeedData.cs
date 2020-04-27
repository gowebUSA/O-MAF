using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OMAF.Data;

namespace OMAF.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new OmafContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<OmafContext>>()))
            {
                // Look for any Aircraft.
                if (context.Aircraft.Any())
                {
                    return;   // DB has been seeded
                }

                context.Aircraft.AddRange(
                    new Aircraft
                    {
                        MCN = "GC7115601",
                        Buno = "168661",
                        SysReason = "35 Hrs Insp",
                        JobStat = "MC",
                        InitiateDate = DateTime.Parse("1984-3-13 02:30:00 PM"),
                        UDP = 1,
                        Initiator = "teustace",
                        Discrepancy = "Perform 35 Hrs. Inspection.",
                        IwDate = DateTime.Parse("1984-3-13 02:31:00 PM"),
                        Worker = "bcollins",
                        CorrAction = "Performed 35 Hrs. Inspection. IAW 4790.",
                        Inspector = "mwatson",
                        ComplDate = DateTime.Parse("1984-3-13 03:30:00 PM"),
                        MxCtrl = "rgo111",
                        MxCtrlNotes = "GT Eng dryout",


                    },

                    new Aircraft
                    {
                        MCN = "GC7115602",
                        Buno = "168662",
                        SysReason = "35 Hrs Insp",
                        JobStat = "M3",
                        InitiateDate = DateTime.Parse("1984-3-13 02:30:00 PM"),
                        UDP = 1,
                        Initiator = "aanderson",
                        Discrepancy = "Perform 35 Hrs. Inspection.",
                        //IwDate = DateTime.Parse("1984-3-13 02:31:00 PM"),
                        //Worker = "rdaniels",
                        //CorrAction = "Performed 35 Hrs. Inspection. IAW 4790.",
                        //Inspector = "mrose",
                        //ComplDate = DateTime.Parse("1984-3-13 03:30:00 PM"),
                        //MxCtrl = "rgo111",
                        //MxCtrlNotes = "GT Eng dry",
                    },

                    new Aircraft
                    {
                        MCN = "GC7115603",
                        Buno = "168662",
                        SysReason = "Patch L/Red rotorblade",
                        JobStat = "M3",
                        InitiateDate = DateTime.Parse("1984-3-13 02:30:00 PM"),
                        UDP = 2,
                        Initiator = "rdaniels",
                        Discrepancy = "Found small hole on taco patch. need to patch L/Red rotorblade.",
                        IwDate = DateTime.Parse("1984-3-13 02:31:00 PM"),
                        //Worker = "rdaniels",
                        //CorrAction = "Performed 35 Hrs. Inspection. IAW 4790.",
                        //Inspector = "mrose",
                        //ComplDate = DateTime.Parse("1984-3-13 03:30:00 PM"),
                        //MxCtrl = "rgo111",
                        //MxCtrlNotes = "GT Eng dry",
                    },

                    new Aircraft
                    {
                        MCN = "GC7115604",
                        Buno = "168663",
                        SysReason = "35 Hrs Insp",
                        JobStat = "IW",
                        InitiateDate = DateTime.Parse("1984-3-13 02:30:00 PM"),
                        UDP = 1,
                        Initiator = "jhassell",
                        Discrepancy = "Perform 35 Hrs. Inspection.",
                        IwDate = DateTime.Parse("1984-3-13 02:31:00 PM"),
                        Worker = "jrespress",
                        //CorrAction = "Performed 35 Hrs. Inspection. IAW 4790.",
                        //Inspector = "mrose",
                        //ComplDate = DateTime.Parse("1984-3-13 03:30:00 PM"),
                        //MxCtrl = "rgo111",
                        //MxCtrlNotes = "GT Eng dry",
                    },

                    new Aircraft
                    {
                        MCN = "GC7115605",
                        Buno = "168663",
                        SysReason = "70 Hrs Insp",
                        JobStat = "JC",
                        InitiateDate = DateTime.Parse("1984-3-13 02:30:00 PM"),
                        UDP = 1,
                        Initiator = "jdodge",
                        Discrepancy = "Perform 70 Hrs. Inspection.",
                        IwDate = DateTime.Parse("1984-3-13 02:31:00 PM"),
                        Worker = "cmadani",
                        CorrAction = "Performed 70 Hrs. Inspection. IAW 4790.",
                        Inspector = "teustace",
                        ComplDate = DateTime.Parse("1984-3-13 03:30:00 PM"),
                        //MxCtrl = "rgo111",
                        //MxCtrlNotes = "GT Eng dry",
                    },

                    new Aircraft
                    {
                        MCN = "GC7115606",
                        Buno = "168665",
                        SysReason = "CC upper door hinge is loose",
                        JobStat = "JC",
                        InitiateDate = DateTime.Parse("1984-3-13 02:30:00 PM"),
                        UDP = 3,
                        Initiator = "mrose",
                        Discrepancy = "CC upper door hinge is loose. Recommend replacement.",
                        IwDate = DateTime.Parse("1984-3-13 02:31:00 PM"),
                        Worker = "kpost",
                        CorrAction = "Removed and replace CC upper door hinge IAW 4790.",
                        Inspector = "djordan",
                        ComplDate = DateTime.Parse("1984-3-13 03:30:00 PM"),
                        //MxCtrl = "rgo111",
                        //MxCtrlNotes = "GT Eng dry",
                    },

                    new Aircraft
                    {
                        MCN = "GC7115607",
                        Buno = "168667",
                        SysReason = "35 Hrs Insp",
                        JobStat = "JC",
                        InitiateDate = DateTime.Parse("1984-3-13 02:30:00 PM"),
                        UDP = 1,
                        Initiator = "jryan",
                        Discrepancy = "Perform 35 Hrs. Inspection.",
                        IwDate = DateTime.Parse("1984-3-13 02:31:00 PM"),
                        Worker = "kpost",
                        CorrAction = "Performed 35 Hrs. Inspection. IAW 4790.",
                        Inspector = "djordan",
                        ComplDate = DateTime.Parse("1984-3-13 03:30:00 PM"),
                        //MxCtrl = "rgo111",
                        //MxCtrlNotes = "GT Eng dry",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
