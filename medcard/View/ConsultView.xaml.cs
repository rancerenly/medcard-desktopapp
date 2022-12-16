using System.Windows;
using medcard.ViewModel;

namespace medcard.View
{
    public partial class ConsultView : Window
    {
        public ConsultView()
        {
            InitializeComponent();

            DataContext = new ConsultationViewModel();
        }
    }
}