using System;

namespace Personal_register
{
	class Program
	{
		static void Main(string[] args)
		{
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Wybierz opcje:");
            Console.WriteLine("1) Dodaj osobe");
            Console.WriteLine("2) Usun osobe");
            Console.WriteLine("3) Wyswietl");
            Console.Write("4) Wyjscie");

            switch (Console.ReadLine())
            {
                case "1":
                    
                    return true;
                case "2":
                    
                    return true;
                case "3":
                    return false;
                default:
                    Console.WriteLine("Wybrałeś złą opcję, spróbuj ponownie");
                    return true;
            }
        }
    }
}


