namespace MyConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MessageWritter MyWritter = new MessageWritter();
			MyWritter.Write("Hello, Writter!");

			FiggleWritter figgleWritter = new FiggleWritter();
			figgleWritter.Write("Hello, Figgle!");
			
		}
	}
}
