using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
	public class Library
	{
		private Book[] books=new Book[100];
		public int CurrentBookCount = 0;
		public int CurrentBrorrowBookCount = 0;
		private Book[] Borrowedbooks=new Book[100];

		public void Display()
		{

            for (int i = 0; i < CurrentBookCount; i++)
            {
				Console.WriteLine(books[i].Title);
            }

        } 
		public void Add(Book book)
		{
			if (CurrentBookCount < books.Length )
			{
				books[CurrentBookCount] = book;
				CurrentBookCount++;
				Console.WriteLine("Book added Succesflly");
			}
			else
			{
				Console.WriteLine("Library is full, can add new books");
			}


		}
		public void Remove(Book book)
		{
			int index = Array.IndexOf(books, book);
			CurrentBookCount--;
			Console.WriteLine("Book Remove");
		}


		public void BrorrowBooks(Book book)
		{
			if (CurrentBrorrowBookCount < books.Length)
			{
				books[CurrentBrorrowBookCount] = book;
				CurrentBookCount++;
				Console.WriteLine("Book Brorrow Succesflly");
			}
			else
			{
				Console.WriteLine("sorry cant borrow mor books");
			}
		}
	}
}
