using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAdoNet
{
    public class ProductDal
    {
        public DataTable GetAll()
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\ProjectModels; initial catalog =ETrade; integrated security = True");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("SELECT * FROM Products",connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            connection.Close();

            return dataTable;
        }
    }
}
