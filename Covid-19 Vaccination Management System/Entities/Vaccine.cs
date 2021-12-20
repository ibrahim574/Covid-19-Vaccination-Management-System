using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid_19_Vaccination_Management_System.Entities
{
    class Vaccine
    {
        public int VaccineId { get; set; }
        public string VaccineName { get; set; }
        public int Quantity { get; set; }
        public string CountyrName { get; set; }
    }
}
