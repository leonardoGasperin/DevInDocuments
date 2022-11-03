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

        public static void RegisteringDocument(DevInDocument docCreation, int employeeId)
        {
            switch (docCreation)
            {
                case TaxInvoice:
                    docCreation.RegisterDocument(GeneralData.documentsList, RecivieingTaxValues(employeeId));
                    break;
                case Contracts:
                    docCreation.RegisterDocument(GeneralData.documentsList, RecivieingContractsValues(employeeId));
                    break;
                case FuntionalitiesLicenses:
                    docCreation.RegisterDocument(GeneralData.documentsList, RecivieingLicensesValues(employeeId));
                    break;
            }
        }

        public static void EditingDocument(int employeeId)
        {
            var docEdit = SearchOneDocument(RecivieDocCode());

            switch (docEdit)
            {
                case TaxInvoice:
                    docEdit.ChangeItensDocument(RecivieingTaxValues(employeeId));
                    break;
                case Contracts:
                    docEdit.ChangeItensDocument(RecivieingContractsValues(employeeId));
                    break;
                case FuntionalitiesLicenses:
                    docEdit.ChangeItensDocument(RecivieingLicensesValues(employeeId));
                    break;
            }

            docEdit.ScreemDocument();
        }

        public static TaxInvoice RecivieingTaxValues(int employeeId)
        {
            Console.WriteLine("Enter with establishment name:");
            string newEstablishmentName = Console.ReadLine();
            Console.WriteLine("Enter with CNPJ:");
            string newCnpj = Console.ReadLine();
            Console.WriteLine("Enter with total value price:");
            string newTotalValue = Console.ReadLine();
            Console.WriteLine("Enter with selled product name:");
            string newSelledProductName = Console.ReadLine();
            Console.WriteLine("Enter with tax type:");
            string newTaxType = Console.ReadLine();
            Console.WriteLine("Enter with total tax value percentage:");
            string newTotalTaxValue = Console.ReadLine();

            return new TaxInvoice(employeeId, newEstablishmentName, newCnpj, decimal.Parse(newTotalValue),
                                  newSelledProductName, TaxType.Other, decimal.Parse(newTotalTaxValue));
        }

        public static Contracts RecivieingContractsValues(int employeeId)
        {
            Console.WriteLine("Enter with establishment name:");
            string newEstablishmentName = Console.ReadLine();
            Console.WriteLine("Enter with CNPJ:");
            string newCnpj = Console.ReadLine();
            Console.WriteLine("Enter with the goals:");
            string newGoals = Console.ReadLine();
            Console.WriteLine("Enter with witnesses names:");
            string[] newWitnessName = {"", ""};
            Console.WriteLine("witnesses 1 names:");
            newWitnessName[0] = Console.ReadLine();
            Console.WriteLine("witnesses 2 names:");
            newWitnessName[1] = Console.ReadLine();
            Console.WriteLine("Enter with an expiration date:");
            Console.WriteLine("Enter with year:");
            string year = Console.ReadLine();
            Console.WriteLine("Enter with month:");
            string month = Console.ReadLine();
            Console.WriteLine("Enter with date:");
            string day = Console.ReadLine();

            return new Contracts(employeeId, newEstablishmentName, newCnpj, newGoals, newWitnessName, new DateTime(int.Parse(year), int.Parse(month), int.Parse(day)));
        }

        public static FuntionalitiesLicenses RecivieingLicensesValues(int employeeId)
        {
            Console.WriteLine("Enter with new establishment name:");
            string newEstablishmentName = Console.ReadLine();
            Console.WriteLine("Enter with new CNPJ:");
            string newCnpj = Console.ReadLine();
            Console.WriteLine("Enter with the adress:");
            string newAdress = Console.ReadLine();
            Console.WriteLine("Enter with the operation:");
            string newOperation = Console.ReadLine();

            return new FuntionalitiesLicenses(employeeId, newEstablishmentName, newCnpj, newAdress, Operation.Other);
        }
    }
}
