using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.models
{
    public class Appointment
    {
        public string CustomerName { get; set; }
        public DateOnly AppointmentDate { get; set; }
        public string AppointmentTime { get; set; }
        public string ServiceType { get; set; }
        public string CustomerType { get; set; }
    }
}
