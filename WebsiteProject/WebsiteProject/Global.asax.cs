using System;
using System.Web.Routing;

namespace WebsiteProject
{
	public class Global : System.Web.HttpApplication
	{
		void RegisterRoutes(RouteCollection routes)
		{
			// Default
			routes.MapPageRoute("", "", "~/UI/ADMIN/AdminLogin.aspx");

			// Admin URL Routings
			routes.MapPageRoute("Admin", "Admin", "~/UI/ADMIN/AdminLogin.aspx");
			routes.MapPageRoute("Dashboard", "Admin/Dashboard", "~/UI/ADMIN/Dashboard.aspx");
			routes.MapPageRoute("DailyPuzzles", "Admin/DailyPuzzles", "~/UI/ADMIN/DailyPuzzles.aspx");
			routes.MapPageRoute("AdminBlog", "Admin/AdminBlog", "~/UI/ADMIN/Blog/AdminBlog.aspx");
			routes.MapPageRoute("ShowMyArticles", "Admin/AdminBlog/ShowMyArticles", "~/UI/ADMIN/Blog/ShowMyArticles.aspx");
			routes.MapPageRoute("ShowAllAdminArticles", "Admin/AdminBlog/ShowAllAdminArticles", "~/UI/ADMIN/Blog/ShowAllAdminArticles.aspx");
			routes.MapPageRoute("ShowAllUserArticles", "Admin/AdminBlog/ShowAllUserArticles", "~/UI/ADMIN/Blog/ShowAllUserArticles.aspx");
			routes.MapPageRoute("UserStatistics", "Admin/UserStatistics", "~/UI/ADMIN/UserStatistics.aspx");
		}

		protected void Application_Start(object sender, EventArgs e)
		{
			RegisterRoutes(RouteTable.Routes);
		}

		protected void Session_Start(object sender, EventArgs e)
		{

		}

		protected void Application_BeginRequest(object sender, EventArgs e)
		{

		}

		protected void Application_AuthenticateRequest(object sender, EventArgs e)
		{

		}

		protected void Application_Error(object sender, EventArgs e)
		{

		}

		protected void Session_End(object sender, EventArgs e)
		{

		}

		protected void Application_End(object sender, EventArgs e)
		{

		}
	}
}