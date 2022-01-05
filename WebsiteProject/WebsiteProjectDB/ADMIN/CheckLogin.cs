using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WebsiteProjectDB.ADMIN
{
	public class CheckLogin
	{
		SqlConnection con;

		public CheckLogin()
		{
			con = DBConnection.GetDataBaseConnection();
		}

		public Dictionary<string, string> AdminLoginValidation(string userName, string password)
		{
			Dictionary<string, string> adminUser = new Dictionary<string, string>();
			SqlCommand selectQuery = new SqlCommand($"SELECT * FROM AdminUsers WHERE Name='{userName}' AND Password='{password}'", con);

			try
			{
				con.Open();
				SqlDataReader sdr = selectQuery.ExecuteReader();

				if(sdr.HasRows)
				{
					while(sdr.Read())
					{
						adminUser.Add(sdr["Name"].ToString(), sdr["EMail"].ToString());
					}
				}

				return adminUser;
			}
			catch(Exception e)
			{
				return adminUser;
			}
			finally
			{
				con.Close();
			}
		}
	}
}
