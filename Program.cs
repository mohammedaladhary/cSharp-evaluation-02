using System.Net.NetworkInformation;

namespace evaluation_02
{
    
    internal class Program
    {
        //Library Management System
        static void Main(string[] args)
        {
            // book object initiated
            Book book = new Book("11111", "The Great Wall", "Mohammed AL Adhary", 5);

            book.BookDetails();
            book.borrowBook();
            Console.WriteLine("Available Copies: " + book.AvailableCopies);
            Console.WriteLine("--------------------------------------------");

            // LibraryMember object initiated
            LibraryMembers member = new LibraryMembers("M6499", "khalifa", "souq seeb street", 9236253);

            member.MemberDetails();
            Console.WriteLine("--------------------------------------------");

            //borrow book
            member.BorrowBook(book);
            Console.WriteLine("Available Copies: " + book.AvailableCopies);

            Console.WriteLine("---------------------------------------------");
            //return book and call the member details
            member.ReturnBook(book);
            Console.WriteLine("Available Copies: " + book.AvailableCopies);

            Library library = new Library();

            Book book2 = new Book("9876543210", "how to sleep well", "Harper Lee", 3);
            // Add the books to the library
            library.AddBook(book);
            library.AddBook(book2);

            // Create some LibraryMember objects
            LibraryMembers member1 = new LibraryMembers("C321", "Ahmed", "Barka Street", 8273526);
            library.AddLibraryMember(member1);

            // Display all books/members in the library
            library.DisplayAllBooks();
            library.DisplayAllLibraryMembers();

            // Member1 borrows book2
            //library.BorrowBook(member1, book2);

            // Member1 returns book2
            //library.ReturnBook(member1, book2);
            Console.WriteLine("---------------------------------------------");

            //by using interface ILendable
            Book specialBook = new Book("S213","End of the Chapter","Ammar",3);
            specialBook.BookDetails();
            specialBook.borrowBook();
            specialBook.returnBook();
        }
    }
}