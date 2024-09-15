using Projekt.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
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
    /// Interaction logic for ReviewsWindow.xaml
    /// </summary>
    public partial class ReviewsWindow : Window
    {
        public ObservableCollection<Review> Reviews { get; set; }

        public ReviewsWindow()
        {
            InitializeComponent();

            Reviews = new ObservableCollection<Review>();

            FetchReviewsAsync();
        }

        private async Task FetchReviewsAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7247/");
                    HttpResponseMessage response = await client.GetAsync("api/Reviews");

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        Reviews = Newtonsoft.Json.JsonConvert.DeserializeObject<ObservableCollection<Review>>(responseBody);
                        DataContext = this;
                    }
                    else
                    {
                        MessageBox.Show($"Błąd: {response.StatusCode} - {response.ReasonPhrase}", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas pobierania ocen: {ex.Message}", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
