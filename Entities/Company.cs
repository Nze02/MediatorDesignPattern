using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIMediatorPattern.Entities
{
    public class Company
    {
        [Column("CompanyId")]
        public int Id { set; get; }

        [Required(ErrorMessage = "Company name is a required field")]
        [MaxLength(60, ErrorMessage = "Maximum length for Name is 60 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Company address is a required field")]
        [MaxLength(60, ErrorMessage = "Maximum length for Address is 60 characters")]
        public string Address { get; set; }

        public string Country { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
