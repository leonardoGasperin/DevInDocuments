using DevInDocuments.Data;

namespace DevInDocuments.Features
{
    internal class ScreemMessage
    {
        public static void RedAlert(int erroCode)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            switch (erroCode)
            {
                case 0:
                    Console.WriteLine("Invalid option, please try again");
                    break;
                case 1:
                    Console.WriteLine("tipe anything to cancel");
                    break;
            }
            Console.ResetColor();
        }

        public static void ClearRedAlert(int erroCode)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            switch (erroCode)
            {
                case 0:
                    Console.WriteLine("The Document recivie some value with invalid format.\nOperation canceled");
                    break;
                case 1:
                    Console.WriteLine("The Document not be found\n");
                    break;
            }
            Console.ResetColor();
        }

        internal static void YellowAlert(int erroCode)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            switch (erroCode)
            {
                case 0:
                    Console.WriteLine("Check if document is valid to confirm:\n" +
                                      "1) Save");
                    break;
                case 1:
                    Console.WriteLine("0) ICMS\n1) IPI\n2) IOF\n3) Other");
                    break;
                case 2:
                    Console.WriteLine("0) ICMS\n1) IPI\n2) IOF\n3) Other");
                    break;
                case 3:
                    Console.WriteLine("0) Active\n1) Processing\n2) Suspended");
                    break;
            }
            Console.ResetColor();
        }

        internal static void GreenAlert(int erroCode)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            switch (erroCode)
            {
                case 0:
                    Console.WriteLine($"We have {GeneralData.documentsList.Count} Documents in our Bank System");
                    break;
            }
            Console.ResetColor();
        }

        internal static void GreenAlert(int erroCode, string name)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            switch (erroCode)
            {
                case 0:
                    Console.WriteLine($"\nBye bye {name} and have a good rest.");
                    break;
            }
            Console.ResetColor();
        }
    }
}
