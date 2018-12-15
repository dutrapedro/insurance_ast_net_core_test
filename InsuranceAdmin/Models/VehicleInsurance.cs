using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceAdmin.Models
{
    public class VehicleInsurance
    {
        [Key]
        public int Id { get; set; }
        public string Brand { get; set; }
        public string State { get; set; }
        public string Plate { get; set; }

        [ForeignKey("Insurance")]
        public int InsuranceId { get; set; }

        public VehicleInsurance(string Brand, string State, string Plate, int InsuranceId)
        {
            this.Brand = Brand;
            this.State = State;
            this.Plate = Plate;
            this.InsuranceId = InsuranceId;
        }
    }
}
