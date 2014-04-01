using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniTech.TpsReports.Core
{
    [Serializable]
    public class TpsReportCoverSheet
    {
        [Required]
        [DisplayName("Prepared by")]
        public string PreparedBy { get; set; }

        [Required]
        [DisplayName("Date")]
        public DateTime PreparedDate { get; set; }

        [DisplayName("Device/Program Type")]
        public string DeviceProgramType { get; set; }

        [DisplayName("Product Code")]
        public string ProductCode { get; set; }

        [Required]
        [DisplayName("Customer")]
        public string Customer { get; set; }

        [DisplayName("Vendor")]
        public string Vendor { get; set; }

        [DisplayName("Due Date")]
        public DateTime DueDate { get; set; }

        [Required]
        [DisplayName("Test Date")]
        public DateTime TestDate { get; set; }

        [DisplayName("Target Run Date")]
        public DateTime TargetRunDate { get; set; }

        [DisplayName("Program Run Time")]
        public int ProgramRuntime { get; set; }

        [DisplayName("Reference Guide")]
        public string ReferenceGuide { get; set; }

        [DisplayName("Program Language")]
        public string ProgramLanguage { get; set; }

        [DisplayName("Number of Error Messages")]
        public int NumberOfErrorMessages { get; set; }

        [DisplayName("Comments")]
        public string Comments { get; set; }

        public TpsReportCoverSheet()
        {
            this.PreparedDate = DateTime.Now;
            this.DueDate = DateTime.Now.AddMonths(1);
            this.TargetRunDate = DateTime.Now;
            this.TestDate = DateTime.Now;
        }
    }
}
