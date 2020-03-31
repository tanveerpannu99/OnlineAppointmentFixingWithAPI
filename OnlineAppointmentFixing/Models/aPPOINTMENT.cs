using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineAppointmentFixing.Models
{
    public class Appointment
    {
        public int ID { get; set; }
        [Display(Name = "Service")]
        public int ServiceID { get; set; }
        [Display(Name = "Customer")]
        public int CustomerID { get; set; }
        [Display(Name = "Slot")]
        public int SlotTimeID { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Appointment Date")]
        public Nullable<DateTime> Date { get; set; }

        public List<AppointmentCancel> AppointmentCancels { get; set; }
        public List<Process> Processs { get; set; }
        public Service Service { get; set; }
        public Customer Customer { get; set; }
        public TimeSlot TimeSlot { get; set; }
    }
}