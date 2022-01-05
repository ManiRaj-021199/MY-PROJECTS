using System.Data.SqlClient;

namespace WebsiteProjectDB
{
	public class DBConnection
	{
		public static SqlConnection GetDataBaseConnection()
		{
			SqlConnection con = new SqlConnection("data source=.; database=WebsiteProject; integrated security=SSPI");

			return con;
		}
	}
}
