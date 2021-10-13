using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMediatorPattern.Entities.DTO
{
    public class CompanyDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FullAddress { get; set; }
    }
}
