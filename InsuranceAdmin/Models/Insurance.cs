using System;
using System.ComponentModel.DataAnnotations;

namespace InsuranceAdmin.Models
{
    public class Insurance
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public string CPF { get; set; }
        public string CustomerName { get; set; }

        public Insurance(string Description, int Type, string CPF, string CustomerName)
        {
            this.Description = Description;
            this.Type = Type;
            this.CPF = CPF;
            this.CustomerName = CustomerName;
        }
    }
}
