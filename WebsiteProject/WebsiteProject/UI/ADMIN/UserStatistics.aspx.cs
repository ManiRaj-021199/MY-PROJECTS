using System;
using System.Data;
using WebsiteProjectDB.AuthorArticleLogics;

namespace WebsiteProject.MasterPages
{
	public partial class WebForm3 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if(!IsPostBack)
			{
				ShowAllAuthors();
			}
		}

		public void ShowAllAuthors()
		{
			DataSet ds = new AuthorLogics().GetAllAuthorDetails();

			gvAuthorsListTable.DataSource = ds;
			gvAuthorsListTable.DataBind();
		}
	}
}