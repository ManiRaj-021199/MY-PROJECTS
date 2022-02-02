using System;
using System.Collections;
using WebsiteProjectDB.Authentication;

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
			string strUserEmail = adminUserEmail.Value.ToString();
			string strUserPassword = adminPassword.Value.ToString();

			Hashtable adminUser = new AdminAuthentication().Login(strUserEmail, strUserPassword);

			if(adminUser.Contains("strUserName"))
			{
				Session["AdminID"] = adminUser["UserId"];
				Session["AdminUserName"] = adminUser["strUserName"];
				Session["AdminEMail"] = adminUser["strUserEMail"];
				
				Response.Redirect("/Admin/Dashboard");
			}
			else
			{
				Response.Write("Wrong Password");
			}
		}
	}
}