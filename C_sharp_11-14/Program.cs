using System;

namespace C_sharp_11_14
{
    class Program
    {
        static void Main(string[] args)
        {
    //        Address address = new Address();
           
            

            Book altoriuSeselis = new Book("111-222-3333");
           
            altoriuSeselis.PageCount = 555;
            altoriuSeselis.PublishedDate = new DateTime(1999, 01, 01);
            altoriuSeselis.Author = 
                new Author() { FirstName = "Vincas", LastName = "Putinas" };
            altoriuSeselis.Genre = Genre.Thriller;

            Library viesojiBiblioteka = new Library(Address.GetViesojiBiblioteka());
            viesojiBiblioteka.Books.Add(altoriuSeselis);

            foreach (var book in viesojiBiblioteka.Books)
            {
                Console.WriteLine(book.Author.FirstName);
            }

        }
    }
}
