using System;
using System.ComponentModel.DataAnnotations;

namespace AppointmentDoctor.Models
{
    public class Doctor
    {
        [Key]
        public int IdDoc { get; set; }
        public string FIO { get; set; }
        public string Speciality { get; set; }
        public int Stazh { get; set; }
        public DateTime ReceptionTime { get; set; }
    }
}
