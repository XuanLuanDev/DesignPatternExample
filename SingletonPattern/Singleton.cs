
namespace DesignPatternExample
{
	public sealed class Singleton
	{
		private static Singleton instance = null;

		/// <summary>
		/// this method is called when you want to use this class
		/// </summary>
		/// <returns></returns>
		public static Singleton GetInstance() { 
		 if (instance == null)
			{
				instance = new Singleton();
			}
		 return instance;
		}
		public Singleton()
		{
			Console.WriteLine("new instance");
		}
		/// <summary>
		/// sample method
		/// </summary>
		/// <param name="message"></param>
		public void PrintMessage(string message)
		{
			Console.WriteLine(message);
		}
	}
}
