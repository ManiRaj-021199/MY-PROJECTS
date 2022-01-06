using System.Collections;

namespace WebsiteProjectDB.Interfaces
{
	interface IAuthentication
	{
		Hashtable Login(string email, string password);
	}
}
