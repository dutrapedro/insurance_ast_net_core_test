using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceAdmin.Models
{
    public class HouseInsurance
    {
        [Key]
        public int Id { get; set; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        [ForeignKey("Insurance")]
        public int InsuranceId { get; set; }

        public HouseInsurance(string StreetName, int StreetNumber, string State, string Country, int InsuranceId)
        {
            this.StreetName = StreetName;
            this.StreetNumber = StreetNumber;
            this.State = State;
            this.Country = Country;
            this.InsuranceId = InsuranceId;
        }
    }
}
