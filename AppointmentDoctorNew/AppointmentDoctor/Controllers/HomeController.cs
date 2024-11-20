using AppointmentDoctor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppointmentDoctor.Controllers
{
    public class HomeController : Controller
    {
        DoctorContext db = new DoctorContext();
        public ActionResult Index()
        {
            IEnumerable<Doctor> doctors = db.Doctors;
            ViewBag.Doctors = doctors;
            return View();
        }
        [HttpGet]
        public ActionResult Appointment(int id)
        {
            ViewBag.IdDoc = id;
            return View();
        }
        [HttpPost]
        public string Appointment(Appointment appointment)
        {
            appointment.DateAppointment = DateTime.Now;
            db.Appointments.Add(appointment);
            db.SaveChanges();
            return appointment.Name+" "+appointment.Otchestvo+", вы успешно записаны на прием";
        }
    }
}