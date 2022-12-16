using System;

namespace medcard.Model
{
    public class Consultation
    {
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public string Recommendation { get; set; }
        public string Diagnosis { get; set; }
        public string Department { get; set; }
        public DateTime DateConclusion { get; set; } = DateTime.Today;
    }
}