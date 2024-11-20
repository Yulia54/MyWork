using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentDoctor.Models
{
    public class DoctorDbInitializer : DropCreateDatabaseAlways<DoctorContext>
    {
        protected override void Seed(DoctorContext context)
        {
            context.Doctors.Add(new Doctor { FIO = "Зимина Галина Ивановна", Speciality = "Терапевт", Stazh = 15, ReceptionTime = new DateTime(2024, 11, 21, 16, 30, 0)});
            context.Doctors.Add(new Doctor { FIO = "Морилова Екатерина Евгеньевна", Speciality = "Подолог", Stazh = 7, ReceptionTime = new DateTime(2024, 11, 22, 8, 20, 0) });
            context.Doctors.Add(new Doctor { FIO = "Ивин Сергей Александрович", Speciality = "Кардиолог", Stazh = 10, ReceptionTime = new DateTime(2024, 11, 25, 10, 40, 0) });
            context.Doctors.Add(new Doctor { FIO = "Пиревина Анна Викторовна", Speciality = "Невролог", Stazh = 8, ReceptionTime = new DateTime(2024, 11, 26, 12, 20, 0) });
            context.Doctors.Add(new Doctor { FIO = "Смирнов Алексей Николаевич", Speciality = "Хирург", Stazh = 12, ReceptionTime = new DateTime(2024, 11, 21, 17, 0, 0) });
            base.Seed(context);
        }
    }
}
