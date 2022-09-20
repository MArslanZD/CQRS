using CQRS.Model;

namespace CQRS.Interface
{
    public interface IEmployeeCommand
    {
        public bool AddEmployee(Employee emp);
    }
}
