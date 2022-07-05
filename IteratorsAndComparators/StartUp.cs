using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    class StartUp
    {
        public static void Main()

        {

            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");

            Book bookTwo = new Book("The Documents in the Case", 2002,

            "Dorothy Sayers", "Robert Eustace");

            Book bookThree = new Book("The Documents in the Case", 1930);

            Library libraryOne = new Library();

            var lib = new Library(new Book("C# basics", 2003, "Nakov"));

            Library libraryTwo = new Library(bookOne, bookTwo, bookThree); 

            foreach (var book in libraryTwo) 
            {
                Console.WriteLine(book.Title);
            }

        }
    }
}
