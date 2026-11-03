using Start1;
class Program
{
    static void Main()
    {
        var library = new Library();
        while (true)
        {
            Console.WriteLine("===== LIBRARY =====");
            Console.WriteLine("1. Show all books");
            Console.WriteLine("2. Show available books");
            Console.WriteLine("3. Add book");
            Console.WriteLine("4. Take book");
            Console.WriteLine("5. Return book");
            Console.WriteLine("6. Delete book");
            Console.WriteLine("7. Search by the author");
            Console.WriteLine("0. Exit");
            Console.Write("Your Choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    library.DisplayBooks();
                    break;

                case "2":
                    library.DisplayAvailableBooks();
                    break;

                case "3":
                    Console.WriteLine("Name: ");
                    string title = Console.ReadLine();
                    Console.WriteLine("Author: ");
                    string author = Console.ReadLine();
                    Console.WriteLine("Year" );
                    int year = int.Parse(Console.ReadLine());
                    library.AddbookWithId(new Book(title, author, year, true));
                    break;

                case "4":
                    Console.WriteLine("Which book ?");
                    library.TakeBook(Console.ReadLine());
                    break;

                case "5":
                    Console.WriteLine("Which book ?");
                    library.ReturnBook(Console.ReadLine());
                    break;

                case "6":
                    Console.WriteLine("Which book you want to delete (type the ID) ?");
                    int id = int.Parse(Console.ReadLine());
                    library.DeleteBook(id);
                    break;

                case "7":
                    Console.WriteLine("Which author you want to search for ?");
                    library.SearchByAuthor(Console.ReadLine());
                    break;

                case "0":
                    Console.WriteLine(" Bye!");
                    return;
            }
        }
    }
}