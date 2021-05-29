using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PersonAddress
    {
        public PersonAddress()
        {
            InversePerson = new HashSet<PersonAddress>();
        }

        public long Id { get; set; }
        public long PersonId { get; set; }
        public string MobileNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string HouseAddress { get; set; }
        public string PinCode { get; set; }
        public int VillageWardId { get; set; }
        public int BlockId { get; set; }
        public int GpZoneId { get; set; }
        public short DistrictId { get; set; }
        public DateTime AddedOn { get; set; }
        public string AddedByIp { get; set; }
        public int AddedBy { get; set; }

        public virtual PersonAddress Person { get; set; }
        public virtual ICollection<PersonAddress> InversePerson { get; set; }
    }
}
