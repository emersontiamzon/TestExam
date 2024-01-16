namespace Sprout.Exam.WebApp.Models.Employees
{
    public interface ICreateEmployeeModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Birthdate { get; set; }
        public string Tin { get; set; }
        public int TypeId { get; set; }
    }
}
