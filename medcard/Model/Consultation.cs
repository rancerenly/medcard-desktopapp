using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace medcard.Model
{
    public class Consultation : INotifyPropertyChanged
    {
        
        public Consultation()
        {
        }

        public Consultation(Consultation other)
        {
            PatientName = other.PatientName;
            DoctorName = other.DoctorName;
            Department = other.Department;
            Diagnosis = other.Diagnosis;
            DateConclusion = other.DateConclusion;
            Recommendation = other.Recommendation;
        }
        private string patientName;
        public string PatientName
        {
            get { return patientName; }
            set
            {
                patientName = value;
                OnPropertyChanged("PatientName");
            }
        }

        private string doctorName;
        public string DoctorName
        {
            get { return doctorName; }
            set
            {
                doctorName = value;
                OnPropertyChanged("DoctorName");
            }
        }

        private string recommendation;
        public string Recommendation
        {
            get { return recommendation; }
            set
            {
                recommendation = value;
                OnPropertyChanged("Recommendation");
            }
        }

        private string diagnosis;
        public string Diagnosis
        {
            get { return diagnosis; }
            set
            {
                diagnosis = value;
                OnPropertyChanged("Diagnosis");
            }
        }

        private string department;
        public string Department
        {
            get { return department; }
            set
            {
                department = value;
                OnPropertyChanged("Department");
            }
        }

        public DateTime DateConclusion { get; set; } = DateTime.Now;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}