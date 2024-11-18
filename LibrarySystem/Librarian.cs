using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
	public class Librarian : User
	{

		public Librarian(string name) 
		{
		Name = name;
		}

        public int EmployeeNamber { get; set; }

		public void AddBook(Book NewBook, Library library)
		{
			library.Add(NewBook);

		}
		public void RemovBook(Book RemovBook, Library library)
		{
			library.Remove(RemovBook);	

		}
    }
}
