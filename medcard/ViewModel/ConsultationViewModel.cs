using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using medcard.Model;
using System.Runtime.CompilerServices;
using medcard.Tool;

namespace medcard.ViewModel
{
    public class ConsultationViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Consultation> Consultations { get; set; } =
            new ObservableCollection<Consultation>
            {
                new Consultation
                {
                    PatientName = "1",
                    DoctorName = "1",
                    Department = "1",
                    Diagnosis = "1",
                    Recommendation = "1"
                },
                new Consultation
                {
                    PatientName = "1",
                    DoctorName = "1",
                    Department = "1",
                    Diagnosis = "1",
                    Recommendation = "1"
                }
            };
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                       (addCommand = new RelayCommand(obj =>
                       {
                           addConsultation();
                       }));
            }
        }

        private void addConsultation()
        {
            Consultation consult = selectedConsultation;
            Consultations.Add(consult);
            SelectedConsultation = consult;
        }
        private Consultation selectedConsultation = new Consultation();
        public Consultation SelectedConsultation
        {
            get { return selectedConsultation; }
            set
            {
                selectedConsultation = value;
                OnPropertyChanged("SelectedConsultation");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}