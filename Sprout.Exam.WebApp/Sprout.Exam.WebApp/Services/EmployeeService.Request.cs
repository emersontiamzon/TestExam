namespace Sprout.Exam.WebApp.Services
{
    public partial class EmployeeService
    {
        public record CreateEmployee
        {
            public int Id { get; set; }
            public string FullName { get; set; }
            public string Birthdate { get; set; }
            public string Tin { get; set; }
            public int TypeId { get; set; }
        }
        public record ListEmployee
        {
            public int Id { get; set; }
            public string FullName { get; set; }
            public string Birthdate { get; set; }
            public string Tin { get; set; }
            public int TypeId { get; set; }
        }
    }
}
