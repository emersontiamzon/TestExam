using Microsoft.AspNetCore.Mvc;
using Sprout.Exam.Common.Service;
using Sprout.Exam.WebApp.Models.Employees;

namespace Sprout.Exam.WebApp.Services
{
    public interface IEmployeeService :

    IHandlerAsync<EmployeeService.CreateEmployee, ActionResult<CreateEmployeeModel>>
    {

    }
}
