using CQRS.Interface;
using CQRS.Model;
using System.Data.SqlClient;

namespace CQRS.Repositories
{
    internal class EmployeeCommandRepository : IEmployeeCommandRepository
    {
        public bool InsertAnEmployee(Employee emp)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SNKDB1B;Initial Catalog=ReportServerTempDB;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = @$"INSERT INTO EMPLOYEE( EMPNAME, EMPDPT, EMPSalary) 
                                             VALUES ('{emp.EMPName}','{emp.EMPDPT}', {emp.EMPSalary})";
                        conn.Open();
                        int r = cmd.ExecuteNonQuery();
                        conn.Close();
                        return r > 0 ? true : false;
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
