
namespace DesignPatternExample
{
	public abstract class BookFactory
	{
		protected abstract Book MakeBook();
		public Book CreateBook()
		{
			return MakeBook();
		}
	}
}
