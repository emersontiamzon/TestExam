using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sprout.Exam.WebApp.Models.Employees;
using Sprout.Exam.WebApp.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace Sprout.Exam.WebApp.Services
{
    public partial class EmployeeService : IEmployeeService
    {

        private readonly ILogger<EmployeeService> _logger;
        private readonly IEmployeeRepository _repository;

        public EmployeeService(ILogger<EmployeeService> logger,
       IEmployeeRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public async Task<ActionResult<CreateEmployeeModel>> HandleAsync(CreateEmployee request, CancellationToken cancellationToken = default)
        {
            var aa = new CreateEmployeeModel { Birthdate = "asdsa" };
            var aaa = await _repository.HandleAsync(new EmployeeRepository.CreateEmployee { Birthdate = "", FullName = "" });


            return aa;
            //return await _repository.HandleAsync(new BelastingTabellenWitGroenRepository.GetWoonlandbeginsel(), CancellationToken.None);
        }
    }
}
