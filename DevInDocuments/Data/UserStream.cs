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

        public static DevInDocument SearchOneDocument(int code)
        {
            foreach (var doc in GeneralData.documentsList)
            {
                if (doc.DocumentCode == code)
                {
                    return doc;
                }
            }

            return DocNotFound();
        }

        public static DevInDocument DocNotFound()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The Document not be found or code must be only interger.\nTry again");
            Console.ResetColor();
            return SearchOneDocument(RecivieDocCode());
        }

        public static void RegisteringDocument(DevInDocument docCreation)
        {
            Console.WriteLine(docCreation.GetType().Name);
            switch (docCreation.GetType().Name)
            {
                case "TaxInvoice":
                    Console.WriteLine("YYYYY");
                    docCreation = UserScreem.RecivieingTaxValues();
                    docCreation.RegisterDocument(GeneralData.documentsList, docCreation);
                    Console.Clear();
                    docCreation.ScreemDocument();
                    break;
                case "Contracts":
                    docCreation = UserScreem.RecivieingContractsValues();
                    docCreation.RegisterDocument(GeneralData.documentsList, docCreation);
                    Console.Clear();
                    docCreation.ScreemDocument();
                    break;
                case "FuntionalitiesLicenses":
                    docCreation = UserScreem.RecivieingLicensesValues();
                    docCreation.RegisterDocument(GeneralData.documentsList, docCreation);
                    Console.Clear();
                    docCreation.ScreemDocument();
                    break;
            }
        }

        public static void EditingDocument()
        {
            var docEdit = SearchOneDocument(RecivieDocCode());

            switch (docEdit)
            {
                case TaxInvoice:
                    docEdit.ChangeItensDocument(UserScreem.RecivieingTaxValues());
                    break;
                case Contracts:
                    docEdit.ChangeItensDocument(UserScreem.RecivieingContractsValues());
                    break;
                case FuntionalitiesLicenses:
                    docEdit.ChangeItensDocument(UserScreem.RecivieingLicensesValues());
                    break;
            }

            Console.Clear();
            docEdit.ScreemDocument();
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
                    Console.WriteLine("Invalid option, please try again\n");
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
                    Console.WriteLine("Invalid option, please try again\n");
                    Console.ResetColor();
                    _operation =  ChoosenOperationType(Console.ReadLine());
                    break;
            }

            return _operation;
        }
    }
}
