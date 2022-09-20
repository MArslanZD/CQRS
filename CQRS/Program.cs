
using CQRS.Commands;
using CQRS.Interface;
using CQRS.Model;
using CQRS.Queries;

IEmployeeQueries _empQuery = new EmployeeQueries();
IEmployeeCommand _empCommand = new EmployeeCommand();

// Query Implementation [Searching]

Console.WriteLine("-------------- Fetching a Single Employee by Id------------------ \n");
var employee = _empQuery.FindEmployeeById(2);
Console.WriteLine($"Employee Name: {employee.EMPName}, Employee Salary: {employee.EMPSalary} \n");

var allEmployees = _empQuery.FindAllEmployees();

Console.WriteLine("---------- Fetching All the Employees ------------------ \n");

foreach (var emp in allEmployees)
    Console.WriteLine($"Employee Name: {emp.EMPName}, Employee Salary: {emp.EMPSalary} \n");

// Command Implementation [Writing]
Console.WriteLine("--------------- Adding an Employee ------------------- \n");

Employee insertEmp = new Employee
{
    EMPName = "ALI",
    EMPDPT = "Finance",
    EMPSalary = 200000
};

bool isInserted = _empCommand.AddEmployee(insertEmp);
if (isInserted)
    Console.WriteLine("New Employee Added....");