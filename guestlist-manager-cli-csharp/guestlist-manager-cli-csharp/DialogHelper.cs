using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace guestlist_manager_cli_csharp
{
    internal class DialogHelper
    {
        public static int ShowMainMenu()
        {
            int choice;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(20, 0);
            Console.WriteLine("Welcome to Guest List Manager");
            Console.ResetColor();
            Console.WriteLine();
            Console.Write(
                "Please enter your choice: \n\n" +
                "[0] Add new guest. \n" +
                "[1] Show guests list. \n" +
                "[2] Update guest info (by ID). \n" +
                "[3] Delete guest (by ID). \n" +
                "[4] Exit. \n");
            Console.WriteLine("-------------------------------");

            var entry = Console.ReadLine();
            if (!int.TryParse(entry, out choice))
            {
                choice = 5;
            }
            return choice;
        }

        private static void ShowHeader(string title)
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(20, 0);
            Console.WriteLine(title);
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void ShowContinueMessage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n------------------------------------------\n");
            Console.ResetColor();
            Console.WriteLine("Operation completed! \n" +
                "Press return key to continue...");
            Console.Read();
        }

        public static GuestModel ShowAddNewGuest()
        {
            ShowHeader("Add new guest");

            var guest = new GuestModel();

            Console.Write("Enter guest full name: ");
            guest.FullName = Console.ReadLine();

            Console.Write("Enter guest email address: ");
            guest.Email = Console.ReadLine();

            return guest;
        }

        public static void ShowGuestList(List<GuestModel> guestsList)
        {
            ShowHeader("Guests list");

            var table = new ConsoleTable("Id", "Name", "Email", "Confirmed");

            foreach (var guest in guestsList)
            {
                table.AddRow(guest.Id, guest.FullName, guest.Email, guest.HasConfirmed);
            }
            table.Print();

            ShowContinueMessage();
        }

        public static string ShowUpdateGuest()
        {
            ShowHeader("Update Guest");

            Console.WriteLine("Enter guest Id: ");

            return Console.ReadLine();
        }

        public static string ShowDeleteGuest()
        {
            ShowHeader("Delete Guest");

            Console.Write("Enter guest ID: ");

            return Console.ReadLine();
        }
    }
}
