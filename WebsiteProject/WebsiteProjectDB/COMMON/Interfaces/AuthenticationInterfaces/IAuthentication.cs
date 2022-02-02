using System.Collections;

namespace WebsiteProjectDB.COMMON.Interfaces.AuthenticationInterfaces
{
	interface IAuthentication
	{
		Hashtable Login(string email, string password);
	}
}
