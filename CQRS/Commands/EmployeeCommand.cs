using CQRS.Interface;
using CQRS.Model;
using CQRS.Repositories;

namespace CQRS.Commands
{
    public class EmployeeCommand : IEmployeeCommand
    {
        private readonly IEmployeeCommandRepository _repository = new EmployeeCommandRepository();

        public bool AddEmployee(Employee emp)
        => _repository.InsertAnEmployee(emp);

    }
}
