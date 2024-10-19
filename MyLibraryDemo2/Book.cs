namespace MyLibraryDemo2
{
	internal class Book : Product
	{
		public string Title { get; set; }
		public Book(int id, string name, decimal unitPrice, int unitInStock, string title) : base(id, name, unitPrice, unitInStock)
		{
			Title = title;
		}
	}
	public class Book2(int id, string name, decimal unitPrice, int unitInStock, string title) : Product(id, name, unitPrice, unitInStock)
	{
		public string Title => title;
	}
}
