using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class Person
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public byte GenderId { get; set; }
        public byte CategoryId { get; set; }
        public DateTime AddedOn { get; set; }
        public string AddedByIp { get; set; }
        public int AddedBy { get; set; }
    }
}
