using CQRS.Model;

namespace CQRS.Interface
{
    internal interface IEmployeeQueriesRepository
    {

        public Employee GetEmployeeById(int empId);

        public List<Employee> GetAllEmployees();

    }
}
