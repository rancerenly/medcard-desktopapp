using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace medcard.Model
{
    public class Consultation : INotifyPropertyChanged
    {
        private string patientName = string.Empty;

        public string PatientName
        {
            get { return patientName; }
            set
            {
                patientName = value;
                OnPropertyChanged("PatientName");
            }
        }
        private string doctorName = string.Empty;
        public string DoctorName
        {
            get { return doctorName; }
            set
            {
                doctorName = value;
                OnPropertyChanged("DoctorName");
            }
        }
        
        private string recommendation = string.Empty;
        public string Recommendation
        {
            get { return recommendation; }
            set
            {
                recommendation = value;
                OnPropertyChanged("Recommendation");
            }
        }
        private string diagnosis = string.Empty;
        public string Diagnosis
        {
            get { return diagnosis; }
            set
            {
                diagnosis = value;
                OnPropertyChanged("Diagnosis");
            }
        }
        private string department = string.Empty;
        public string Department
        {
            get { return department; }
            set
            {
                department = value;
                OnPropertyChanged("Department");
            }
        }

        public DateTime DateConclusion { get; set; } = DateTime.Today;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}