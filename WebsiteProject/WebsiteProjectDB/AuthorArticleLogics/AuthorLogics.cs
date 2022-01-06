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
			SqlDataAdapter authorsList = new SqlDataAdapter("SELECT * FROM Authors", con);
			DataSet dsAllAuthorDetails = new DataSet();

			authorsList.Fill(dsAllAuthorDetails);

			return dsAllAuthorDetails;
		}
	}
}
