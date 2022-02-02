using WebsiteProjectDB.COMMON.PocoClasses;

namespace WebsiteProjectDB.COMMON.Interfaces.AccessInterfaces
{
	interface ILoggedInUserAccess
	{
		bool AddPost(Article article);
		void EditPost(Article article);
		void DeletePost(Article article);
	}
}
