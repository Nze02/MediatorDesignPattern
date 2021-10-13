using APIMediatorPattern.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMediatorPattern.MediationStructure.Queries
{
    public class GetCompanyListQuery : IRequest<List<Company>>
    {
    }
}
