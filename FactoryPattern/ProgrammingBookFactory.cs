
namespace DesignPatternExample
{
	public class ProgrammingBookFactory : BookFactory
	{
		protected override Book MakeBook()
		{
			Book book = new ProgrammingBook();
			return book;
		}
	}
}
