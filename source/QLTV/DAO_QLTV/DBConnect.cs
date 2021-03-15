using System.Data.SqlClient;
using System.Data.OleDb;

namespace DAO_QLTV
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=DESKTOP-Q8QHN7B\\TIENNH;Initial Catalog=QLTV;User ID=tiennh23;Password=123456aA@");
    }
}
