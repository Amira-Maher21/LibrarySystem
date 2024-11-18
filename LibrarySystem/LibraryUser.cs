using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
	public class LibraryUser : User
	{
        public LibraryUser(string name)
        {
			name = name;
        }
        public LibraryCard Card { get; set; }


		

		public void BrorrowBooks(Book book, Library library)
		{

		library.BrorrowBooks(book);
		}
	}
}
