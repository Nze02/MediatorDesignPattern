using APIMediatorPattern.Entities;
using APIMediatorPattern.MediationStructure.Commands;
using APIMediatorPattern.MediationStructure.Handlers;
using APIMediatorPattern.MediationStructure.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace APIMediatorPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private IMediator mediator;

        public CompanyController(IMediator mediator) => this.mediator = mediator;

        [HttpGet]
        public async Task<List<Company>> GetAllCompanies() => await mediator.Send(new GetCompanyListQuery());

        [HttpGet("{Id}")]
        public async Task<Company> GetCompany([FromRoute] GetCompanyByIdQuery query) => await this.mediator.Send(query);

        [HttpPost]
        //public async Task<Company> CreateCompany([FromBody] Company company) => await mediator.Send(new AddCompanyCommand {Name = company.Name, Address = company.Address, Country = company.Country });
        public async Task<Company> CreateCompany([FromBody] AddCompanyCommand query) => await mediator.Send(query);
    }
}
