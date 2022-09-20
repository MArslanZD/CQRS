using CQRS.Model;

namespace CQRS.Interface
{
    internal interface IEmployeeCommandRepository
    {
        public bool InsertAnEmployee(Employee emp);

    }
}
