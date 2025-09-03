using System;
/* Create a Book class with: Private fields: title, author, isbn, and isAvailable. 
Public properties for Title, Author, and ISBN (read-only). Methods: BorrowBook() → Sets isAvailable to false if available. 
ReturnBook() → Sets isAvailable to true The program will only terminate if the user chooses to end the program

*/ namespace ConsoleApp1
{
    class Book
    {
        private string title;
        private string author;
        private double isbn;
        private bool isAvailable;

        public Book(string title, string author, double isbn)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.isAvailable = true;
        }

        public string GetTitle() { return title; }
        public void SetTitle(string title) { this.title = title; }

        public string GetAuthor() { return author; }
        public void SetAuthor(string author) { this.author = author; }

        public double GetISBN() { return isbn; }
        public void SetISBN(double isbn) { this.isbn = isbn; }

        public bool IsAvailable() { return isAvailable; }
        public void SetAvailability(bool availability) { this.isAvailable = availability; }

        public bool BorrowBook()
        {
            if (isAvailable)
            {
                isAvailable = false;
                return true;
            }
            return false;
        }

        public bool ReturnBook()
        {
            if (!isAvailable)
            {
                isAvailable = true;
                return true;
            }
            return false;
        }

        public void DisplayBook()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("ISBN: " + isbn);
            Console.WriteLine("Available: " + isAvailable);
            Console.WriteLine("-------------------------");
        }
    }

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Alphabet", "Mark Dotong", 10.5);
            Book book2 = new Book("Numbers", "Mark Dotong", 19.2);
            Book book3 = new Book("Dictionary", "Mark Dotong", 31.5);

            int choice;
            do
            {
                Console.WriteLine("Available Books:\n");

                book1.DisplayBook();
                book2.DisplayBook();
                book3.DisplayBook();

                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Borrow a Book");
                Console.WriteLine("2. Return a Book");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("\nEnter book title: ");
                    string title = Console.ReadLine();

                    if (title == book1.GetTitle())
                    {
                        if (book1.BorrowBook())
                            Console.WriteLine("You borrowed it :)");
                        else
                            Console.WriteLine("Book is already borrowed.");
                    }

                    else if (title == book2.GetTitle())
                    {
                        if (book2.BorrowBook())
                            Console.WriteLine("You borrowed it :)");
                        else
                            Console.WriteLine("Book is already borrowed.");
                    }

                    else if (title == book3.GetTitle())
                    {
                        if (book3.BorrowBook())
                            Console.WriteLine("You borrowed it :)");
                        else
                            Console.WriteLine("Book is already borrowed.");
                    }

                }

                else if (choice == 2)
                {
                    Console.Write("\nEnter book title: ");
                    string title = Console.ReadLine();

                    if (title == book1.GetTitle())
                    {
                        if (book1.ReturnBook())
                            Console.WriteLine("You borrowed it :)");
                        else
                            Console.WriteLine("You didn't borrow it.");
                    }

                    else if (title == book2.GetTitle())
                    {
                        if (book2.ReturnBook())
                            Console.WriteLine("You borrowed it :)");
                        else
                            Console.WriteLine("You didn't borrow it.");
                    }

                    else if (title == book3.GetTitle())
                    {
                        if (book3.ReturnBook())
                            Console.WriteLine("You borrowed it :)");
                        else
                            Console.WriteLine("You didn't borrow it.");
                    }

                }
            } while (choice != 3);

            Console.WriteLine("byeee.");
        }
    }
}
