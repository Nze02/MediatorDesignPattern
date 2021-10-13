using APIMediatorPattern.Entities;
using APIMediatorPattern.MediationStructure.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace APIMediatorPattern.MediationStructure.Handlers
{
    public class AddCompanyHandler : IRequestHandler<AddCompanyCommand, Company>
    {
        private readonly ApplicationDBContext db;

        public AddCompanyHandler(ApplicationDBContext db) => this.db = db;

        public async Task<Company> Handle(AddCompanyCommand request, CancellationToken cancellationToken)
        {
            Company company = new Company 
            {
                Name = request.Name,
                Address = request.Address,
                Country = request.Country
            };

            db.Company.Add(company);
            await db.SaveChangesAsync();

            return await Task.FromResult(company) ;
        }
    }
}
