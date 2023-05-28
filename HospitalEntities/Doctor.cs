using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalEntities
{
    [Table("Doctor")]

    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSurName { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 6)]
        public string? PassWord { get; set; }

        public int DepartmentId { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
