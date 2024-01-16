using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sprout.Exam.WebApp.Data;
using Sprout.Exam.WebApp.Models.Employees;
using System.Threading;
using System.Threading.Tasks;

namespace Sprout.Exam.WebApp.Repositories
{
    public partial class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<EmployeeRepository> _logger;
        private readonly IMapper _mapper;


        public EmployeeRepository(ILogger<EmployeeRepository> logger,
            ApplicationDbContext context, IMapper mapper)

        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }

        public async Task<ActionResult<CreateEmployeeModel>> HandleAsync(CreateEmployee request, CancellationToken cancellationToken)
        {
            var aa = new CreateEmployeeModel();
            var result = await _context.Employee.FirstOrDefaultAsync();

            //if (result is null)
            //{
            //    var berekeningen = _mapper.Map<Database.Models.Berekeningen.Berekeningen>(request.Berekeningen);
            //    await _context.Berekeningen.AddAsync(berekeningen);
            //}
            //else
            //{
            //    _mapper.Map(request.Berekeningen, result);
            //}

            return aa;//ResultsTo.Success<bool>(await _context.SaveChangesAsync() > 0);
        }

        //public async Task<ActionResult<Employee>> HandleAsync(ListEmployee request, CancellationToken cancellationToken)
        //{
        //    var aa = new Employee();
        //    var result = await _context.Employee.FirstOrDefaultAsync();

        //    //if (result is null)
        //    //{
        //    //    var berekeningen = _mapper.Map<Database.Models.Berekeningen.Berekeningen>(request.Berekeningen);
        //    //    await _context.Berekeningen.AddAsync(berekeningen);
        //    //}
        //    //else
        //    //{
        //    //    _mapper.Map(request.Berekeningen, result);
        //    //}

        //    return aa;//ResultsTo.Success<bool>(await _context.SaveChangesAsync() > 0);
        //}

    }

}
