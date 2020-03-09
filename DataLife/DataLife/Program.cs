using System;
using System.Collections;

namespace DataLife
{
    class Program
    {
        static void Main(string[] args)
        {
            MainPage();
        }

        static void MainPage()
        {
            System.Console.WriteLine("@project: DataLife\n");
            System.Console.WriteLine("@author: Momo971\n");
            System.Console.WriteLine("Input Your Commend:\n");
            ProcessCommend();
        }

        static void ProcessCommend()
        {
            bool isQuit = false;
            string commend = Console.ReadLine();
            if (commend == CommendDictionary.Com["ShowAllBooks"])
            {
                ReadData.GetInstance().ShowAllBooks();
            }
            else if (commend == CommendDictionary.Com["StartReadBook"])
            {
                System.Console.WriteLine("Book Name:");
                var bookName = Console.ReadLine();
                System.Console.WriteLine("Book Author:");
                var bookAuthor = Console.ReadLine();
                System.Console.WriteLine("Book Type:(1:Tech)(2:Liter)(3:Social)(4:History)(5:Economy)");
                var bookType = Console.ReadLine();
                var typeNum = int.Parse(bookType);
                ReadData.GetInstance().StartRead(bookName, bookAuthor, (BOOK_TYPE)typeNum);
            }
            else if (commend == CommendDictionary.Com["Quit"])
            {
                isQuit = true;
            }
			
			System.Console.WriteLine("\npress any key continue...\n");
			Console.ReadKey();

            if (!isQuit)
            {
                System.Console.Clear();
                MainPage();
            }
        }

    }
}
