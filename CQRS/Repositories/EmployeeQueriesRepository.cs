using CQRS.Interface;
using CQRS.Model;
using System.Data.SqlClient;

namespace CQRS.Repositories
{
    internal class EmployeeQueriesRepository : IEmployeeQueriesRepository
    {
        public Employee GetEmployeeById(int empId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SNKDB1B;Initial Catalog=ReportServerTempDB;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = "SELECT * FROM EMPLOYEE WHERE EMPID = @empId";
                        cmd.Parameters.Add("@empId", System.Data.SqlDbType.Int);
                        cmd.Parameters["@empId"].Value = empId;
                        conn.Open();
                        var reader = cmd.ExecuteReader();
                        reader.Read();
                        Employee emp = new Employee()
                        {
                            EMPID = reader.GetFieldValue<int>(0),
                            EMPName = reader.GetFieldValue<string>(1),
                            EMPDPT = reader.GetFieldValue<string>(2),
                            EMPSalary = reader.GetFieldValue<decimal>(3)
                        };
                        reader.Close();
                        conn.Close();
                        return emp;
                    }

                }

            }
            catch (Exception ex)
            {

                throw;
            }


        }

        public List<Employee> GetAllEmployees()
        {
            try
            {
                List<Employee> lstEmployee = new List<Employee>();
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SNKDB1B;Initial Catalog=ReportServerTempDB;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = "SELECT * FROM EMPLOYEE";
                        conn.Open();
                        var reader = cmd.ExecuteReader();
                        Employee emp = new Employee();
                        while (reader.Read())
                        {

                            emp = new Employee()
                            {
                                EMPID = reader.GetFieldValue<int>(0),
                                EMPName = reader.GetFieldValue<string>(1),
                                EMPDPT = reader.GetFieldValue<string>(2),
                                EMPSalary = reader.GetFieldValue<decimal>(3)
                            };
                            lstEmployee.Add(emp);
                        }
                        reader.Close();
                        conn.Close();
                        return lstEmployee;
                    }

                }

            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
