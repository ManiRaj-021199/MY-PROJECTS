using System;
using System.Data;
using System.Data.SqlClient;

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
			SqlDataAdapter authors = new WebsiteProjectDB.CommonOperations.GetRecords().GetAuthorDetails();
			DataSet ds = new DataSet();

			authors.Fill(ds);

			gvAuthorsListTable.DataSource = ds;
			gvAuthorsListTable.DataBind();
		}
	}
}