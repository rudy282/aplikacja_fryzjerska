using Projekt.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projekt
{
    /// <summary>
    /// Interaction logic for ShowAppointments.xaml
    /// </summary>
    public partial class ShowAppointmentsWindow : Window
    {
        public ShowAppointmentsWindow()
        {
            InitializeComponent();
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            AppointmentsListBox.ItemsSource = MainWindow.Appointments;
        }

        private void RemoveAppointmentButton_Click(object sender, RoutedEventArgs e)
        {
            Appointment selectedAppointment = AppointmentsListBox.SelectedItem as Appointment;
            if (selectedAppointment != null)
            {
                MainWindow.Appointments.Remove(selectedAppointment);
                CollectionViewSource.GetDefaultView(AppointmentsListBox.ItemsSource).Refresh();
            }
            else
            {
                MessageBox.Show("Proszę wybrać wizytę do usunięcia.", "Nie wybrano żadnej wizyty", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
