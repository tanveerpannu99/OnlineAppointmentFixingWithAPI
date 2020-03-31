using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineAppointmentFixing.Models
{
    public class AppointmentCancel
    {
        public int ID { get; set; }
        public int AppointmentID { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Cancel Date")]
        public Nullable<DateTime> CancelDate { get; set; }
        public string Reason { get; set; }

        public Appointment Appointment { get; set; }
    }
}