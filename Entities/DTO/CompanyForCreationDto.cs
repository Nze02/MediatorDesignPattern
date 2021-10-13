using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMediatorPattern.Entities.DTO
{
    public class CompanyForCreationDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }

        //public IEnumerable<EmployeeForCreationDTO> Employees { get; set; }
    }
}
