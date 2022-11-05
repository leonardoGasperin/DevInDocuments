/*###
 *### Observation the code on line 250 one day with much documents registred the drawned box will disconfigure out
 */
using DevInDocuments.Data;

namespace DevInDocuments.Features
{
    internal class ScreamMessage
    {

        public static void Welcome()
        {
            Console.WriteLine("||#########################################################################||\n" +
                              $"||    Welcome Employee: {GeneralData._employee.Name} to DevInDocuments!   ||");
            UserScream.MainMenu();
        }

        public static void MenuConsole(MenuType type)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            switch (type)
            {
                case MenuType.Main:
                    Console.WriteLine("||#########################################################################||\n" +
                                      "||        Please, what you want to do? Choose a option:                    ||\n" +
                                      "||-------------------------------------------------------------------------||\n" +
                                      "||              1) Register document                                       ||\n" +
                                      "||              2) Edit document itens                                     ||\n" +
                                      "||              3) Edit document status                                    ||\n" +
                                      "||              4) Scream document                                         ||\n" +
                                      "||              0) Exit                                                    ||\n" +
                                      "||#########################################################################||");
                    break;
                case MenuType.Register:
                    Console.WriteLine("||#########################################################################||\n" +
                                      "||        What type of Document you want to register? Choose a option:     ||\n" +
                                      "||-------------------------------------------------------------------------||\n" +
                                      "||              1) Tax Invoice                                             ||\n" +
                                      "||              2) Contracts                                               ||\n" +
                                      "||              3) Licenses                                                ||\n" +
                                      "||              0) Back to Main Menu                                       ||\n" +
                                      "||#########################################################################||");
                    break;
                case MenuType.ScremmDoc:
                    Console.WriteLine("||#########################################################################||\n" +
                                      "||        Please, what you want to scream? Choose a option:                ||\n" +
                                      "||-------------------------------------------------------------------------||\n" +
                                      "||              1) Screan TaxBill                                          ||\n" +
                                      "||              2) Scream Contracts                                        ||\n" +
                                      "||              3) Scream Licenses                                         ||\n" +
                                      "||              4) By document status                                      ||\n" +
                                      "||              5) Scream all                                              ||\n" +
                                      "||              6) Search one by code                                      ||\n" +
                                      "||              0) Back to Main Menu                                       ||\n" +
                                      "||#########################################################################||");
                    break;
                case MenuType.Exit:
                    Console.WriteLine("||#########################################################################||\n" +
                                      $"||        Bye bye {GeneralData._employee.Name} and have a good rest.      ||\n" +
                                      "||#########################################################################||");
                    break;
                default:
                    break;
            }
            Console.ResetColor();
        }

        public static void FormsMessage(int code)
        {
            switch (code)
            {
                case 0:
                    Console.WriteLine("||#########################################################################||\n" +
                                      "||        Enter with establishment name:                                   ||\n" +
                                      "||-------------------------------------------------------------------------||");
                    break;
                case 1:
                    Console.WriteLine("||-------------------------------------------------------------------------||\n" +
                                      "||        Enter with CNPJ                                                  ||\n" +
                                      "||-------------------------------------------------------------------------||");
                    break;
                case 2:
                    Console.WriteLine("||-------------------------------------------------------------------------||\n" +
                                      "||        Enter with total value price                                     ||\n" +
                                      "||-------------------------------------------------------------------------||");
                    break;
                case 3:
                    Console.WriteLine("||-------------------------------------------------------------------------||\n" +
                                      "||        Enter with selled product name                                   ||\n" +
                                      "||-------------------------------------------------------------------------||");
                    break;
                case 4:
                    Console.WriteLine("||-------------------------------------------------------------------------||\n" +
                                      "||        Enter with tax type                                              ||");
                    break;
                case 5:
                    Console.WriteLine("||-------------------------------------------------------------------------||\n" +
                                      "||        Enter with total tax value percentage                            ||\n" +
                                      "||-------------------------------------------------------------------------||");
                    break;
                case 6:
                    Console.WriteLine("||-------------------------------------------------------------------------||\n" +
                                      "||        Enter with the goals                                             ||\n" +
                                      "||-------------------------------------------------------------------------||");
                    break;
                case 7:
                    Console.WriteLine("||-------------------------------------------------------------------------||\n" +
                                      "||        Enter with witnesses names:                                      ||\n" +
                                      "||              witness 1 names                                          ||\n" +
                                      "||-------------------------------------------------------------------------||");
                    break;
                case 8:
                    Console.WriteLine("||-------------------------------------------------------------------------||\n" +
                                      "||              witness 2 names                                          ||\n" +
                                      "||-------------------------------------------------------------------------||");
                    break;
                case 9:
                    Console.WriteLine("||-------------------------------------------------------------------------||\n" +
                                      "||        Enter with an expiration date:                                   ||\n" +
                                      "||              Enter with year                                            ||\n" +
                                      "||-------------------------------------------------------------------------||");
                    break;
                case 10:
                    Console.WriteLine("||-------------------------------------------------------------------------||\n" +
                                      "||              Enter with month                                           ||\n" +
                                      "||-------------------------------------------------------------------------||");
                    break;
                case 11:
                    Console.WriteLine("||-------------------------------------------------------------------------||\n" +
                                      "||              Enter with date                                            ||\n" +
                                      "||-------------------------------------------------------------------------||");
                    break;
                case 12:
                    Console.WriteLine("||-------------------------------------------------------------------------||\n" +
                                      "||        Enter with the adress                                            ||\n" +
                                      "||-------------------------------------------------------------------------||");
                    break;
                case 13:
                    Console.WriteLine("||-------------------------------------------------------------------------||\n" +
                                      "||        Enter with the operation                                         ||");
                    break;
                case 14:
                    Console.WriteLine("||-------------------------------------------------------------------------||\n" +
                                      "||        Enter with Status type                                           ||");
                    break;
                case 15:
                    Console.WriteLine("||-------------------------------------------------------------------------||\n" +
                                      "||        Enter with Document code                                         ||\n" +
                                      "||-------------------------------------------------------------------------||");
                    break;
                default:
                    break;
            }
        }

        internal static void RedAlert(int alertCode)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            switch (alertCode)
            {
                case 0:
                    Console.WriteLine("||#########################################################################||\n" +
                                      "||              Invalid option, please try again                           ||\n" +
                                      "||#########################################################################||");
                    break;
                case 1:
                    Console.WriteLine("||-------------------------------------------------------------------------||\n" +
                                      "||              Or tipe anything to cancel                                 ||\n" +
                                      "||#########################################################################||");
                    break;
            }
            Console.ResetColor();
        }

        internal static void ClearRedAlert(int alertCode)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            switch (alertCode)
            {
                case 0:
                    Console.WriteLine("||#########################################################################||\n" +
                                      "||              The Document receveid some value with invalid format.       ||\n" +
                                      "||              Operation canceled                                         ||\n" +
                                      "||#########################################################################||");
                    break;
                case 1:
                    Console.WriteLine("||#########################################################################||\n" +
                                      "||              The Document not be found                                  ||\n" +
                                      "||#########################################################################||");
                    break;
            }
            Console.ResetColor();
        }

        internal static void YellowAlert(int alertCode)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            switch (alertCode)
            {
                case 0:
                    Console.WriteLine("||#########################################################################||\n" +
                                      "||        Check if document is valid to confirm:                           ||\n" +
                                      "||              1) Save                                                    ||");
                    break;
                case 1:
                    Console.WriteLine("||-------------------------------------------------------------------------||\n" +
                                      "||              ||###############||                                        ||\n" +
                                      "||              ||---------------||                                        ||\n" +
                                      "||              ||    0) ICMS    ||                                        ||\n" +
                                      "||              ||    1) IPI     ||                                        ||\n" +
                                      "||              ||    2) IOF     ||                                        ||\n" +
                                      "||              ||    3) Other   ||                                        ||\n" +
                                      "||              ||---------------||                                        ||\n" +
                                      "||-------------------------------------------------------------------------||");
                    break;
                case 2:
                    Console.WriteLine("||-------------------------------------------------------------------------||\n" +
                                      "||              ||########################||                               ||\n" +
                                      "||              ||------------------------||                               ||\n" +
                                      "||              ||    0) Industry         ||                               ||\n" +
                                      "||              ||    1) Agricultural     ||                               ||\n" +
                                      "||              ||    2) Metallurgical    ||                               ||\n" +
                                      "||              ||    3) Technological    ||                               ||\n" +
                                      "||              ||    4) Others           ||                               ||\n" +
                                      "||              ||------------------------||                               ||\n" +
                                      "||-------------------------------------------------------------------------||");
                    break;
                case 3:
                    Console.WriteLine("||-------------------------------------------------------------------------||\n" +
                                      "||              ||#####################||                                  ||\n" +
                                      "||              ||---------------------||                                  ||\n" +
                                      "||              ||    0) Active        ||                                  ||\n" +
                                      "||              ||    1) Processing    ||                                  ||\n" +
                                      "||              ||    2) Suspended     ||                                  ||\n" +
                                      "||              ||---------------------||                                  ||\n" +
                                      "||-------------------------------------------------------------------------||");
                    break;
            }
            Console.ResetColor();
        }

        internal static void GreenAlert(int alertCode)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            switch (alertCode)
            {
                case 0:
                    Console.WriteLine("||-------------------------------------------------------------------------||\n" + 
                                      $"||\tDocuments amount: {GeneralData.documentsList.Count}\t\t\t\t\t\t   ||\n" +
                                      "||-------------------------------------------------------------------------||");
                    break;
                case 1:
                    Console.WriteLine("||#########################################################################||\n" +
                                      "||              Document Found!                                            ||\n" +
                                      "||#########################################################################||");
                    break;
            }
            Console.ResetColor();
        }
    }
}
