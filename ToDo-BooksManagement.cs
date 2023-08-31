using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1_SampleConApp
{

    class Books
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Genre { get; set; }

        public Books(int BookId, string BookName, string Genre)
        {
            this.BookId = BookId;
            this.BookName = BookName;
            this.Genre = Genre;
        }
    }

    class BooksCollection
    {

        private static Books[] AllBooks = new Books[100];

        public static void AddNewBook(Books book)
        {
            for(int i = 0; i < 100; i++)
            {
                if (AllBooks[i] == null)
                {
                    AllBooks[i] = book;
                    Console.WriteLine("Books added successfully");
                    return;
                }
                else continue;
            }
        }

        public static void DisplayAll()
        {
            for(int i = 0; i < AllBooks.Length; i++)
            {
                if(AllBooks[i] != null)
                {
                    Console.WriteLine($"The name of the book is {AllBooks[i].BookName}");
                    Console.WriteLine($"The Id of the book is {AllBooks[i].BookId}");
                    Console.WriteLine($"The genre of the book is {AllBooks[i].Genre}\n");
                }
            }

        }

        public static void BookEntry()
        {
            string Name = utilities.GetString("Enter the name of the book");
            string Genre = utilities.GetString("Enter the genre of the book");
            int BookId = utilities.GetInteger("Enter the book Id");

            Books NewBook = new Books(BookId, Name, Genre);
            AddNewBook(NewBook);
        }

        public static void DeleteBook()
        {
            int BookId = utilities.GetInteger("Enter the Book Id");
            for(int i = 0; i < 100; i++)
            {
                if(AllBooks[i].BookId == BookId)
                {
                    AllBooks[i] = null;
                    Console.WriteLine("Employee Deleted Successfully");
                    break;
                }
            }
        }

        public static void FindBook()
        {
            string Genre = utilities.GetString("Enter the genre of the book");
            for(int i = 0; i < 100; i++)
            {
                if(AllBooks[i].Genre == Genre && AllBooks[i] != null)
                {
                    Console.WriteLine(AllBooks[i].BookName);
                    continue;
                }
            }
        }
    }
    class ToDo_BooksManagement
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("-------------------------------------------\nADD NEW BOOK--->PRESS N\nDELETE A BOOK--->PRESS D\nDISPLAY ALL BOOKS--->ENTER DISPLAY\nFIND A BOOK--->PRESS F\n------------------------------------------ -");

                string choice = utilities.GetString("Enter your choice");

                switch (choice)
                {
                    case "N":
                        BooksCollection.BookEntry();
                        break;

                    case "D":
                        BooksCollection.DeleteBook();
                        break;
                    case "DISPLAY":
                        BooksCollection.DisplayAll();
                        break;
                    case "F":
                        BooksCollection.FindBook();
                        break;
                    default:
                        return;

                }
            } while (true);
        }
    }
}
