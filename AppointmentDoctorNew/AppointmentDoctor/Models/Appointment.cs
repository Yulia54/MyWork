using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentDoctor.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        public int IdDoc { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Otchestvo { get; set; }
        public string Policy { get; set; }
        public DateTime DateAppointment { get; set; }
    }
}
