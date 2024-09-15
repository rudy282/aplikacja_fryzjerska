using Projekt.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows;

namespace Projekt.services
{
    internal class AppointmentManager
    {
        private const string FilePath = "appointments.json";

        public void SaveAppointments(List<Appointment> appointments)
        {

            string json = JsonConvert.SerializeObject(appointments);
            File.WriteAllText(FilePath, json);
            
        }

        public List<Appointment> LoadAppointments()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                return JsonConvert.DeserializeObject<List<Appointment>>(json);
            } else
            {
                return new List<Appointment>();
            }
        }
    }
}
