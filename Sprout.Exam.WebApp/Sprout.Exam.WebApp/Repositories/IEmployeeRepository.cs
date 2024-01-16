using Microsoft.AspNetCore.Mvc;
using Sprout.Exam.Common.Service;
using Sprout.Exam.WebApp.Models.Employees;

namespace Sprout.Exam.WebApp.Repositories
{
    public interface IEmployeeRepository :
         IHandlerAsync<EmployeeRepository.CreateEmployee, ActionResult<CreateEmployeeModel>>
    //IHandlerAsync<EmployeeRepository.ListEmployee, ActionResult<Employee>>
    {

    }
}
