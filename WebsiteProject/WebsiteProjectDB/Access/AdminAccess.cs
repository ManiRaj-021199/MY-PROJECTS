using System;
using System.Data.SqlClient;
using WebsiteProjectDB.COMMON.PocoClasses;
using WebsiteProjectDB.COMMON.Interfaces.AccessInterfaces;

namespace WebsiteProjectDB.Access
{
	public class AdminAccess : ILoggedInUserAccess
	{
		private readonly SqlConnection con;

		public AdminAccess()
		{
			con = DBConnection.GetDataBaseConnection();
		}

		public bool AddPost(Article article)
		{
			SqlCommand insertQuery = new SqlCommand($"INSERT INTO AdminBlog(Title, Description, BlogContent, Fk_AdminUser_Id) VALUES ('{article.Title}', '{article.Description}', '{article.BlogContent}', {article.AuthorDetails["userId"]})", con);
			
			try
			{
				con.Open();

				insertQuery.ExecuteNonQuery();

				return true;
			}
			catch(Exception e)
			{
				return false;
			}
			finally
			{
				con.Close();
			}
		}

		public void EditPost(Article article)
		{

		}

		public void DeletePost(Article article)
		{

		}
	}
}
