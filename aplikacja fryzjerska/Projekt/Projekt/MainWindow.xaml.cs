using Projekt.models;
using Projekt.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Appointment> Appointments = new List<Appointment>();

        AppointmentManager appointmentManager = new AppointmentManager();



        public MainWindow()
        {
            InitializeComponent();
            Appointments = appointmentManager.LoadAppointments();
        }

        private void Add_appointment_button_Click(object sender, RoutedEventArgs e)
        {
            AddApointmentWindow addApointmentWindow = new AddApointmentWindow();
            addApointmentWindow.ShowDialog();
        }

        private void Show_appointments_button_Click(object sender, RoutedEventArgs e)
        {
            ShowAppointmentsWindow showAppointmentsWindow = new ShowAppointmentsWindow();
            showAppointmentsWindow.ShowDialog();
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            appointmentManager.SaveAppointments(Appointments);
        }

        private void Workers_button_Click(object sender, RoutedEventArgs e)
        {
            WorkersWindow workers = new WorkersWindow();
            workers.ShowDialog();
        }

        private void Prices_button_Click(object sender, RoutedEventArgs e)
        {
            PricesWindow pricesWindow = new PricesWindow();
            pricesWindow.ShowDialog();
        }

        private void Customer_reviews_button_Click(object sender, RoutedEventArgs e)
        {
            ReviewsWindow reviewsWindow = new ReviewsWindow();
            reviewsWindow.ShowDialog();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Aplikacja dla salonów fryzjerskich stworzona przez Sławomira Dąbrowskiego", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
