using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineAppointmentFixing.Models
{
    public class TimeSlot
    {
        public int ID { get; set; }
        [DataType(DataType.Time)]
        [Display(Name = "Time Slot")]
        public Nullable<DateTime> SlotDateTime { get; set; }

        public List<Appointment> Appointments { get; set; }
    }
}