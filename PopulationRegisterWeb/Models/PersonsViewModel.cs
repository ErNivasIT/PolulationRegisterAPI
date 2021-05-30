using PopulationManagementAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PopulationRegisterWeb.Models
{
    public class PersonsViewModel
    {
        public long Id { get; set; }
        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Display(Name ="Midddle Name")]
        public string MiddleName { get; set; }
        [Required]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [Required]
        public DateTime? Dob { get; set; }
        [Required]
        [Display(Name = "Father Name")]

        public string FatherName { get; set; }
        [Required]
        [Display(Name ="Mother Name")]
        public string MotherName { get; set; }
        [Required]
        [Display(Name = "Gender")]

        public byte? GenderId { get; set; }
        [Required]
        [Display(Name = "Category")]

        public byte? CategoryId { get; set; }
        public DateTime AddedOn { get; set; }
        public string AddedByIp { get; set; }
        public int AddedBy { get; set; }
        
    }
}
