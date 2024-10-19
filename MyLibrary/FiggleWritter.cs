namespace MyLibrary
{
	public class FiggleWritter
	{
		public void Write(string message)
		{
			Console.WriteLine(Figgle.FiggleFonts.Standard.Render(message));
		}
	}
}
