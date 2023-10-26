using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_coding
{
    internal class Program
    {
            static void Main()
            {
                Book book = new Book();

                while (true)
                {
                    Console.WriteLine("Library Management System");
                    Console.WriteLine("1. Add the Book");
                    Console.WriteLine("2. Remove the Book");
                    Console.WriteLine("3. Display All the Books");
                    Console.WriteLine("4. Search Book by Title");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter your choice: ");

                    if (int.TryParse(Console.ReadLine(), out int choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                Console.Write("Enter the Book Title: ");
                                string title = Console.ReadLine();
                                Console.Write("Enter the Author of the Book: ");
                                string author = Console.ReadLine();
                                Console.Write("Enter the Book ISBN: ");
                                string isbn = Console.ReadLine();

                                Book newBook = new Book { Title = title, Author = author, ISBN = isbn };
                               
                                break;

                            case 2:
                                Console.Write("Enter ISBN of the Book to Remove: ");
                                break;

                            case 3:
                                Console.Write("Enter the Title to Search: ");
                                break;
                            case 4:
                            Console.WriteLine("Display all books present");
                                break;

                            case 5:
                                Environment.Exit(0);
                                break;

                            default:
                                Console.WriteLine("Invalid choice. Please try again correctly.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid choice.");
                    }
                }
            }
        }
    }
   
