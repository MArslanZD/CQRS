using CQRS.Interface;
using CQRS.Model;
using CQRS.Repositories;

namespace CQRS.Queries
{
    public class EmployeeQueries : IEmployeeQueries
    {
        private readonly IEmployeeQueriesRepository _empRepo = new EmployeeQueriesRepository();

        public List<Employee> FindAllEmployees()
        => _empRepo.GetAllEmployees();

        public Employee FindEmployeeById(int empId)
        => _empRepo.GetEmployeeById(empId);

    }
}
