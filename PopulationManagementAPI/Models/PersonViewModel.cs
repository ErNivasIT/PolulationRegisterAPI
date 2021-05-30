using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PopulationManagementAPI.Models
{
    public class PersonViewModel
    {
        public long Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime? Dob { get; set; }
        [Required]
        public string FatherName { get; set; }
        [Required]
        public string MotherName { get; set; }
        [Required]
        public byte? GenderId { get; set; }
        [Required]
        public byte? CategoryId { get; set; }
        public DateTime AddedOn { get; set; }
        public string AddedByIp { get; set; }
        public int AddedBy { get; set; }
    }
}
