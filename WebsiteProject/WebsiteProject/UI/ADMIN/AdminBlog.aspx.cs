using System;
using System.Collections;
using WebsiteProjectDB.Access;
using WebsiteProjectDB.COMMON.PocoClasses;

namespace WebsiteProject.MasterPages
{
	public partial class WebForm2 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			
		}

		protected void SubmitArticle_Click(object sender, EventArgs e)
		{
			Hashtable authorDetails = new Hashtable();
			authorDetails.Add("userId", Session["AdminID"]);
			authorDetails.Add("userName", Session["AdminUserName"]);
			authorDetails.Add("Email", Session["AdminEMail"]);

			Article article = new Article();
			article.Title = blogTitle.Value.ToString();
			article.Description = blogDescription.Value.ToString();
			article.BlogContent = blogContent.Value.ToString();
			article.AuthorDetails = authorDetails;

			bool isPosted = new AdminAccess().AddPost(article);

			if(isPosted)
			{
				warningMsg.InnerText = "Article Added Successfully.";
				warningMsg.Style.Add(System.Web.UI.HtmlTextWriterStyle.Color, "green");
				ResetBlogForm();
			}
			else
			{
				warningMsg.InnerText = "Something Went Wrong. Try Again Later...";
				warningMsg.Style.Add(System.Web.UI.HtmlTextWriterStyle.Color, "red");
			}
		}

		protected void ResetArticle_Click(object sender, EventArgs e)
		{
			ResetBlogForm();
		}

		private void ResetBlogForm()
		{
			blogTitle.Value = "";
			blogDescription.Value = "";
			blogContent.Value = "";

			warningMsg.InnerText = "";
		}
	}
}