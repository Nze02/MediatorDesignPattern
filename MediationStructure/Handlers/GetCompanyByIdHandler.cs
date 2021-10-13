using APIMediatorPattern.Entities;
using APIMediatorPattern.MediationStructure.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace APIMediatorPattern.MediationStructure.Handlers
{
    public class GetCompanyByIdHandler : IRequestHandler<GetCompanyByIdQuery, Company>
    {
        private readonly IMediator mediator;
        private readonly ApplicationDBContext db;

        public GetCompanyByIdHandler(IMediator mediator, ApplicationDBContext db) 
        {
            this.mediator = mediator;
            this.db = db;
        }

        public async Task<Company> Handle(GetCompanyByIdQuery request, CancellationToken cancellationToken)
        {
            //var companies = await mediator.Send(new GetCompanyListQuery());
            //var company = companies.FirstOrDefault(x => x.Id == request.Id);
            var company = db.Company.Where(c => c.Id == request.Id).FirstOrDefault();

            return company;
        }
    }
}
