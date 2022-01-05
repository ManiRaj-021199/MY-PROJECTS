using System.Data.SqlClient;

namespace WebsiteProjectDB.CommonOperations
{
	public class GetRecords
	{
		SqlConnection con;

		public GetRecords()
		{
			con = DBConnection.GetDataBaseConnection();
		}

		public SqlDataAdapter GetAuthorDetails()
		{
			SqlDataAdapter authorsList = new SqlDataAdapter("SELECT * FROM Authors", con);

			return authorsList;
		}
	}
}
