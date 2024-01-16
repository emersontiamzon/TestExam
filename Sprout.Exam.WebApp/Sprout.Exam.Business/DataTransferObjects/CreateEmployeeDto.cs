using Sprout.Exam.DataAccess.Models.DB;

namespace Sprout.Exam.Business.DataTransferObjects
{
    public class CreateEmployeeDto : BaseSaveEmployeeDto
    {
        private readonly SproutDbContext _sproutDbContext;

        public CreateEmployeeDto(SproutDbContext sproutDbContext)
        {
            _sproutDbContext = sproutDbContext;
        }

        //public async Task<IActionResult> Create(CreateEmployeeDto employeeDto)
        //{
        //    var employee = await _sproutDbContext.Employees.FirstOrDefaultAsync();
        //    var Id = employee.Id + 1;

        //    _sproutDbContext.Employees.Add(new Employee
        //    {
        //        FullName = employeeDto.FullName
        //    }
        //        );
        //    return (IActionResult)employeeDto;

        // var id = await Task.FromResult(StaticEmployees.ResultList.Max(m => m.Id) + 1);

        //StaticEmployees.ResultList.Add(new EmployeeDto
        //{
        //    Birthdate = input.Birthdate.ToString("yyyy-MM-dd"),
        //    FullName = input.FullName,
        //    Id = id,
        //    Tin = input.Tin,
        //    TypeId = input.TypeId
        //});
    }

}

