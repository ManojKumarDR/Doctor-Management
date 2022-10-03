using System;
using System.Collections.Generic;

namespace DoctorSampleApp.Models
{
    public partial class DoctorTable
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorDept { get; set; }
        public string DoctorQualification { get; set; }
        public int DoctorFees { get; set; }
        public string DoctorImage { get; set; }
    }
}
