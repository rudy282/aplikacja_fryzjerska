using Projekt.models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for AddApointmentWindow.xaml
    /// </summary>
    public partial class AddApointmentWindow : Window
    {
        public AddApointmentWindow()
        {
            InitializeComponent();
        }

        private void AddAppointmentButton_Click(object sender, RoutedEventArgs e)
        {
            string customerName = CustomerNameTextBox.Text;
            DateTime? selectedDate = AppointmentDatePicker.SelectedDate;
            DateOnly appointmentDate = selectedDate.HasValue ? DateOnly.FromDateTime(selectedDate.Value) : DateOnly.MinValue;
            string appointmentTime = AppointmentTimeTextBox.Text;
            string serviceType = ((ComboBoxItem)ServiceTypeComboBox.SelectedItem)?.Content.ToString();
            string customerType = MenRadioButton.IsChecked == true ? "Mężczyzna" :
                                  WomenRadioButton.IsChecked == true ? "Kobieta" :
                                  ChildRadioButton.IsChecked == true ? "Dziecko" : "Nie wybrane";


            if (string.IsNullOrWhiteSpace(customerName))
            {
                MessageBox.Show("Proszę o podanie odpowiedniego imienia", "Niepoprawne dane", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (appointmentDate == DateOnly.MinValue)
            {
                MessageBox.Show("Proszę o wybranie poprawnej daty", "Niepoprawne dane", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!IsValidTime(appointmentTime))
            {
                MessageBox.Show("Proszę o podanie odpowiedniego czasu w formacie: HH:mm.", "Niepoprawne dane", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(serviceType))
            {
                MessageBox.Show("Proszę o wybranie odpowiedniego rodzaju usługi", "Niepoprawne dane", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (string.IsNullOrWhiteSpace(customerType))
            {
                MessageBox.Show("Proszę o wybranie odpowiedniego typu gościa", "Niepoprawne dane", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            Appointment newAppointment = new Appointment
            {
                CustomerName = customerName,
                AppointmentDate = appointmentDate,
                AppointmentTime = appointmentTime,
                ServiceType = serviceType,
                CustomerType = customerType
            };

            MainWindow.Appointments.Add(newAppointment);

            MessageBox.Show($"Nowa wizyta została umówiona, szczegóły:\n" +
                            $"Imie: {newAppointment.CustomerName}\n" +
                            $"Data: {newAppointment.AppointmentDate.ToShortDateString()}\n" +
                            $"Czas: {newAppointment.AppointmentTime}\n" +
                            $"Rodzaj usługi: {newAppointment.ServiceType}\n" +
                            $"Rodzaj gościa: {newAppointment.CustomerType}",
                            "Stworzono nową wizytę", MessageBoxButton.OK, MessageBoxImage.Information);

            this.Close();
        }

        public bool IsValidTime(string appointmentTime)
        {
            string pattern = @"^(?:[01]\d|2[0-3]):[0-5]\d$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(appointmentTime);
        }
    }
}
