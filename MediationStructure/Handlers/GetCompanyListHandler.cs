using APIMediatorPattern.Entities;
using APIMediatorPattern.MediationStructure.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace APIMediatorPattern.MediationStructure.Handlers
{
    public class GetCompanyListHandler : IRequestHandler<GetCompanyListQuery, List<Company>>
    {
        private ApplicationDBContext db;

        public GetCompanyListHandler(ApplicationDBContext db) => this.db = db;

        public Task<List<Company>> Handle(GetCompanyListQuery request, CancellationToken cancellationToken)
        {
            return this.db.Company.ToListAsync();
        }
    }
}
