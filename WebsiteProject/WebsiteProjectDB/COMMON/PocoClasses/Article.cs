using System.Collections;

namespace WebsiteProjectDB.COMMON.PocoClasses
{
	public class Article
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string BlogContent { get; set; }
		public Hashtable AuthorDetails { get; set; }
	}
}
