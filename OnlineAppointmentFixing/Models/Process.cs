using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineAppointmentFixing.Models
{
    public class Process
    {
        public int ID { get; set; }
        public int AppointmentID { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Process Date")]
        public Nullable<DateTime> ProcessDate { get; set; }
        public string Remarks { get; set; }

        public Appointment Appointment { get; set; }
    }
}