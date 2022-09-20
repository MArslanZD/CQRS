using CQRS.Model;

namespace CQRS.Interface
{
    public interface IEmployeeQueries
    {
        public Employee FindEmployeeById(int empId);

        public List<Employee> FindAllEmployees();

    }
}
