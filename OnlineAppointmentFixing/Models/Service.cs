using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineAppointmentFixing.Models
{
    public class Service
    {
        public int ID { get; set; }
        public string ServiceName { get; set; }

        public List<Appointment> Appointments { get; set; }
    }
}