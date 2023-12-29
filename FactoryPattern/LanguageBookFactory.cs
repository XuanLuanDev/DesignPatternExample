
namespace DesignPatternExample
{
	public class LanguageBookFactory : BookFactory
	{
		protected override Book MakeBook()
		{
			Book book = new LanguageBook();
			return book;
		}
	}
}
