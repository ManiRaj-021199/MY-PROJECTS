using System;
using System.Web.UI;

namespace WebsiteProject.MasterPages
{
	public partial class AdminMasterPage : System.Web.UI.MasterPage
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if(Session["AdminUserName"] == null)
			{
				Response.Redirect("/Admin");
			}
			else
			{
				siteAdminName.InnerText = Session["AdminUserName"].ToString();
				siteAdminEmail.InnerText = Session["AdminEMail"].ToString();
			}
		}

		protected void Logout_Click(object sender, EventArgs e)
		{
			Session.Remove("AdminUserName");
			Session.Remove("AdminEMail");

			Response.Redirect("/Admin");
		}
	}
}