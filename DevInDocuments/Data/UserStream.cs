using DevInDocuments.Entities.Company;
using DevInDocuments.Features;

namespace DevInDocuments.Data
{
    internal static class UserStream
    {
        internal static int RecivieDocCode()
        {
            Console.WriteLine("Enter with Document code:");
            _ = int.TryParse(Console.ReadLine(), out var code);
            return code;
        }

        public static void RegisteringDocument(DevInDocument docCreation)
        {
            try
            {
                switch (docCreation.GetType().Name)
                {
                    case "TaxInvoice":
                        docCreation = UserScreem.RecivieingTaxValues();
                        break;
                    case "Contracts":
                        docCreation = UserScreem.RecivieingContractsValues();
                        break;
                    case "FuntionalitiesLicenses":
                        docCreation = UserScreem.RecivieingLicensesValues();
                        break;
                }

                Console.Clear();
                if (CheckDocumentToConfirm(docCreation) == "1")
                {
                    docCreation.RegisterDocument(GeneralData.documentsList, docCreation);
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The Document recivie some value in valid format.\nOperation canceled");
                Console.ResetColor();
            }
            Console.Clear();
        }

        public static void EditingDocument()
        {
            try
            {
                var docEdit = GeneralData.SearchOneDocument(RecivieDocCode());

                switch (docEdit)
                {
                    case TaxInvoice:
                        var newTax = UserScreem.RecivieingTaxValues();
                        if (CheckDocumentToConfirm(newTax) == "1")
                            docEdit.ChangeItensDocument(newTax);
                        break;
                    case Contracts:
                        var newContract = UserScreem.RecivieingContractsValues();
                        if (CheckDocumentToConfirm(newContract) == "1")
                            docEdit.ChangeItensDocument(newContract);
                        break;
                    case FuntionalitiesLicenses:
                        var newLicence = UserScreem.RecivieingLicensesValues();
                        if (CheckDocumentToConfirm(newLicence) == "1")
                            docEdit.ChangeItensDocument(newLicence);
                        break;
                }

                Console.Clear();
                UserScreem.MainMenu();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The Document not be found or some value is not in valid format.\nOperation canceled");
                Console.ResetColor();
                UserScreem.MainMenu();
            }
        }

        public static void EditingDocumentStatus()
        {
            try
            {
                var docEdit = GeneralData.SearchOneDocument(RecivieDocCode());
                DocumentStatus status = UserScreem.ChooseStatus();
                docEdit.ChangeDocumentStatus(status);
                UserScreem.MainMenu();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The Document not be found or code is not in valid format.");
                Console.ResetColor();
                UserScreem.MainMenu();
            }
        }

        private static string CheckDocumentToConfirm(DevInDocument docCreation)
        {
            Console.Clear();
            docCreation.ScreemDocument();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Check if document is valid to confirm:\n" +
                              "1) Save");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("2) tipe anything to cancel");
            Console.ResetColor();

            return Console.ReadLine();
        }

        public static TaxType ChoosenTaxType(string value)
        {
            TaxType _taxType = TaxType.Other;

            switch (value)
            {
                case "0":
                    _taxType = TaxType.ICMS;
                    return _taxType;
                case "1":
                    _taxType = TaxType.IPI;
                    return _taxType;
                case "2":
                    _taxType = TaxType.IOF;
                    return _taxType;
                case "3":
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option\n");
                    Console.ResetColor();
                    _taxType = ChoosenTaxType(Console.ReadLine());
                    break;
            }

            return _taxType;
        }

        public static Operation ChoosenOperationType(string value)
        {
            Operation _operation = Operation.Other;

            switch (value)
            {
                case "0":
                    _operation = Operation.Industry;
                    return _operation;
                case "1":
                    _operation = Operation.Agricultural;
                    return _operation;
                case "2":
                    _operation = Operation.Metallurgical;
                    return _operation;
                case "3":
                    _operation = Operation.Technology;
                    return _operation;
                case "4":
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option\n");
                    Console.ResetColor();
                    _operation =  ChoosenOperationType(Console.ReadLine());
                    break;
            }

            return _operation;
        }

        public static DocumentStatus ChoosenStatusType(string value)
        {
            DocumentStatus status = DocumentStatus.InvalidOption;
            switch (value)
            {
                case "0":
                    return DocumentStatus.Active;
                case "1":
                    return DocumentStatus.Processing;
                case "2":
                    return DocumentStatus.Suspended;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option\n");
                    Console.ResetColor();
                    break;
            }

            return status;
        }
    }
}
