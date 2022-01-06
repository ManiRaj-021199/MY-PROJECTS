using System.Data;
using System.Data.SqlClient;

namespace WebsiteProjectDB.AuthorArticleLogics
{
	public class AuthorLogics
	{
		private SqlConnection con;

		public AuthorLogics()
		{
			con = DBConnection.GetDataBaseConnection();
		}

		public DataSet GetAllAuthorDetails()
		{
			DataSet dsAllAuthorDetails = new DataSet();

			using(SqlDataAdapter authorsList = new SqlDataAdapter("SELECT * FROM Authors", con))
			{
				authorsList.Fill(dsAllAuthorDetails);
			}

			return dsAllAuthorDetails;
		}
	}
}
