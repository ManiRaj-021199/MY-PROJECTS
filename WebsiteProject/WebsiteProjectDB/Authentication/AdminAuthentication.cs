using WebsiteProjectDB.COMMON.Interfaces.AuthenticationInterfaces;
using System.Collections;
using System.Data.SqlClient;
using System;

namespace WebsiteProjectDB.Authentication
{
	public class AdminAuthentication : IAuthentication
	{
		private readonly SqlConnection con;

		public AdminAuthentication()
		{
			con = DBConnection.GetDataBaseConnection();
		}

		public Hashtable Login(string email, string password)
		{
			Hashtable htUser = new Hashtable();

			SqlCommand selectQuery = new SqlCommand($"SELECT * FROM AdminUsers WHERE EMail='{email}' AND Password='{password}'", con);

			try
			{
				con.Open();
				SqlDataReader sdr = selectQuery.ExecuteReader();

				if(sdr.HasRows)
				{
					while(sdr.Read())
					{
						htUser.Add("UserId", sdr["ID"]);
						htUser.Add("strUserName", sdr["Name"].ToString());
						htUser.Add("strUserEMail", sdr["EMail"].ToString());
					}
				}
			}
			catch(Exception e)
			{
				
			}
			finally
			{
				con.Close();
			}

			return htUser;
		}
	}
}
