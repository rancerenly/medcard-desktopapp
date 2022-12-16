using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using medcard.Model;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media.Effects;
using medcard.Tool;

namespace medcard.ViewModel
{
    public class ConsultationViewModel : INotifyPropertyChanged
    {
        public ConsultationViewModel()
        {
            SelectedConsultation = new Consultation();
        }
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
            if (SelectedConsultation == null)
            {
                SelectedConsultation = new Consultation();
            }
            Consultation consult = new Consultation(SelectedConsultation);
            Consultations.Add(consult);
            SelectedConsultation = consult;

        }
        private RelayCommand deleteCommand;
        public RelayCommand DeleteCommand
        {
            get
            {
                return deleteCommand ??
                       (deleteCommand = new RelayCommand(obj =>
                       {
                           deleteConsultation();
                       }));
            }
        }
        private void deleteConsultation()
        {
            if (selectedConsultation != null)
            {
                var consult = Consultations.FirstOrDefault(cons =>
                    cons.PatientName == selectedConsultation.PatientName &&
                    cons.DoctorName == selectedConsultation.DoctorName &&
                    cons.Diagnosis == selectedConsultation.Diagnosis);
                Consultations.Remove(consult);
            }
            else
            {
                errorWindow();
            }
        }

        private void errorWindow()
        {
            MessageBox.Show("Выберите консультацию!");
        }

        private Consultation selectedConsultation;
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