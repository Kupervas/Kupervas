/* static double Степінь(double число, int показник)
{
    double результат = 1;
    for (int i = 0; i < показник; i++)
    {
        результат *= число;
    }
    return результат;
}
Console.WriteLine(Степінь(2, 8));
Console.WriteLine(Степінь(5, 0)); 


                                                                                  // Клас - шаблон
using System.Xml.Linq;

class Developer
{
   public string Name;
   public int MonthExperience;
   public string Language;
   public Developer(string name, int months, string language)
    {
        Name = name;
        MonthExperience = months;
        Language = language;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Developer {Name} has {MonthExperience} months of experience in {Language}.");
    }
    public bool IsExperienced()
    {
        return MonthExperience >= 9;
    }
}
class Program
{
    static void Main()
    {
        // Об'єкт - конкретні розробники 
        var team = new List<Developer>
        {
            new Developer("Ruslan", 12, "C#"),
            new Developer("Olga", 6, "JavaScript"),
            new Developer("Ivan", 18, "Python"),
            new Developer("Anna",3,"Java"),
        };
        
        Console.WriteLine("== Team Information ==");
        foreach (var developer in team)
            developer.DisplayInfo();
        Console.WriteLine("\n== Experienced Developers ==");
        foreach (var developer in team)
        {
            if (developer.IsExperienced())
                Console.WriteLine($"{developer.Name} is experienced.");
            else
                Console.WriteLine($"{developer.Name} is not experienced.");
        }
    }
} 
                                                                                               // BankAccount 

class BankAccount
{
    public string AccountName { get; set; }
    public decimal Balance { get; private set; }
    public BankAccount(string accountName, decimal balance)
    {
        AccountName = accountName;
        Balance = balance;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Account: {AccountName}| Balance: {Balance}");
    }
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be positive.");
            return;
        }
        Balance += amount;
        Console.WriteLine($"Deposited {amount} to account {AccountName}. New balance: {Balance}");
    }
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdraw amount must be positive.");
            return;
        }
        if (amount > Balance)
        {
            Console.WriteLine($"Insufficient funds in account {AccountName}. Current balance: {Balance}");
            return;
        }
        Balance -= amount;
        Console.WriteLine($"Withdrawn {amount} from account {AccountName}. New balance: {Balance}");
    }
    public void Transfer(BankAccount targetAccount, decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Transfer amount must be positive.");
            return;
        }
        if (amount > Balance)
        {
            Console.WriteLine($"Insufficient funds in account {AccountName}. Current balance: {Balance}");
            return;
        }
        Balance -= amount; // знімаємо з себе
        targetAccount.Balance += amount; // додаємо на target
        Console.WriteLine($"Transferred {amount} from {AccountName} to {targetAccount.AccountName}.");
        Console.WriteLine($"New balance: {Balance}");
        Console.WriteLine($"New balance of {targetAccount.AccountName}: {targetAccount.Balance}");
    }
}
class Program
{
  static void Main()
  {
    var account1 = new BankAccount("John Doe", 1000);
    var account2 = new BankAccount("Jane Smith", 500);
    account1.ShowInfo();
    account2.ShowInfo();
    account1.Deposit(200);
    account2.Withdraw(100);
    account1.ShowInfo();
    account2.ShowInfo();
    account1.Transfer(account2, 300);
    account2.Transfer(account1, 800); // This will show insufficient funds
    account1.Transfer(account2, -100);
    }
} */
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
// tipa shoc` minyaju

/*static void Main()
{
    var library = new Library();
    library.AddBook(new Book("1984", "George Orwell", 1949, true));
    library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 1960, true));
    library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925, true));
    library.DisplayBooks();
    library.TakeBook("1984");
    library.TakeBook("1984");
    library.ReturnBook("1984");
    library.TakeBook("The Great Gatsby");
    library.ReturnBook("1984");
    library.TakeBook("Machine");
    library.ReturnBook("Machine");
    library.DisplayBooks();
}*/
