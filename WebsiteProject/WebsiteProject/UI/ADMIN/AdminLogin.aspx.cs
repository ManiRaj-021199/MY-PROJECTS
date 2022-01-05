using System;
using System.Collections.Generic;

namespace WebsiteProject.UI.ADMIN
{
	public partial class AdminLogin : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if(!IsPostBack)
			{
				if(Session["AdminUserName"] != null)
				{
					Response.Redirect("/Admin/Dashboard");
				}
			}
		}

		protected void AdminFormSubmitted(object sender, EventArgs e)
		{
			string userName = adminUserName.Value.ToString();
			string password = adminPassword.Value.ToString();

			Dictionary<string, string> adminUser = new WebsiteProjectDB.ADMIN.CheckLogin().AdminLoginValidation(userName, password);

			if(adminUser.Count != 0)
			{
				foreach(KeyValuePair<string, string> user in adminUser)
				{
					Session["AdminUserName"] = user.Key;
					Session["AdminEMail"] = user.Value;
				}
				
				Response.Redirect("/Admin/Dashboard");
			}
			else
			{
				Response.Write("Wrong Password");
			}
		}
	}
}