using APIMediatorPattern.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMediatorPattern.MediationStructure.Queries
{
    public class GetCompanyByIdQuery : IRequest<Company>
    {
        public int Id { get; set; }
    }
}
