using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteProject.MasterPages
{
	public partial class UserStatistics : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if(!IsPostBack)
			{
				ShowAuthorsList();
			}
		}

		public void ShowAuthorsList()
		{

		}
	}
}