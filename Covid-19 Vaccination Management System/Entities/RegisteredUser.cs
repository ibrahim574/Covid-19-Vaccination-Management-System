using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid_19_Vaccination_Management_System.Entities
{
    class RegisteredUser
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int PatientNid { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string FirstDose { get; set; }
        public string SecondDose { get; set; }
        public string VaccineName { get; set; }
    }

}
