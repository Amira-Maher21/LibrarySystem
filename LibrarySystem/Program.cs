namespace LibrarySystem
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the library System");
			Console.WriteLine("Are you Libarain or regular User (L/R)");
			var UserType = Console.ReadLine().ToUpper()[0];


			Console.WriteLine("Welcom Librarian, Enter Your Name");
			string LibrarianName = Console.ReadLine();

			Library library = new Library();
			Librarian L1 = new Librarian(LibrarianName);
			Console.WriteLine($"Welcom {L1.Name}");




			if (UserType == 'L')
			{

				while (true)
				{


				Console.WriteLine("Please choose to add book (A) / Remove book (R) get book (g)");
				var choice = Console.ReadLine().ToUpper()[0];
				switch (choice)
				{
					case 'A':
						Console.WriteLine("Enter book Get");
						string bookName = Console.ReadLine();
						string bookAuthor = Console.ReadLine();
						int bookYear = Convert.ToInt32(Console.ReadLine());
						Book book = new Book()
						{
							Title = bookName,
							Authuer = bookAuthor,
							Year = bookYear,
						};
						L1.AddBook(book, library);
						break;

					case 'R':
						Console.WriteLine("Enter book Get to remov  ");
						bookName = Console.ReadLine();
						bookAuthor = Console.ReadLine();
						bookYear = Convert.ToInt32(Console.ReadLine());
						book = new Book()
						{
							Title = bookName,
							Authuer = bookAuthor,
							Year = bookYear,
						};
						L1.RemovBook(book, library);
						break;

					case 'g':
						Console.WriteLine("The Book List");
						L1.GetBooks(library);
						break;
					default:

						Environment.Exit(0);
						break;


				}

			}


			}


			else if (UserType == 'R')
				{
					Console.WriteLine("Welcome User,vEnter Your Name");
					string name =Console.ReadLine();
					LibraryUser Ln1 = new LibraryUser(name);
					Console.WriteLine($"Welcome {Ln1.Name}");


				while (true)
				{


					Console.WriteLine("Please choose to get book (g) / Borrow book (A) ");
					var choice = Console.ReadLine().ToUpper()[0];
					switch (choice)
					{
						case 'g':
							Console.WriteLine("The Book List");
							Ln1.GetBooks(library);
							break;

						case 'A':
							Console.WriteLine("Enter book Get to Borrow ");
							string bookName = Console.ReadLine();
							string bookAuthor = Console.ReadLine();
							int bookYear = Convert.ToInt32(Console.ReadLine());
							Book book = new Book()
							{
								Title = bookName,
								Authuer = bookAuthor,
								Year = bookYear,
							};
							Ln1.BrorrowBooks(book, library);
							break;

 
						
						default:

							Environment.Exit(0);
							break;


					}

				}

			}
			else
				{
					Console.WriteLine("Please enter Correct Value (L or R)");
				}
		}
		
	}
}

