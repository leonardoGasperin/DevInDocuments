using DevInDocuments.Entities.Company;
using DevInDocuments.Features;

namespace DevInDocuments.Data
{
    internal class UserStream
    {
        internal static int ReceveidDocCode()
        {
            ScreamMessage.FormsMessage(15);
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
                        docCreation = ReceveidTaxValues();
                        break;
                    case "Contracts":
                        docCreation = ReceveidContractsValues();
                        break;
                    case "FuntionalitiesLicenses":
                        docCreation = ReceveidLicensesValues();
                        break;
                }

                if (CheckDocumentToConfirm(docCreation) == "1")
                {
                    docCreation.RegisterDocument(GeneralData.documentsList, docCreation);
                }
                Console.Clear();
            }
            catch
            {
                ScreamMessage.ClearRedAlert(0);
            }
        }

        public static void EditingDocument()
        {
            var docEdit = GeneralData.SearchOneDocument(ReceveidDocCode());

            try
            {
                switch (docEdit)
                {
                    case TaxInvoice:
                        var newTax = ReceveidTaxValues();
                        if (CheckDocumentToConfirm(newTax) == "1")
                            docEdit.ChangeItensDocument(newTax);
                        break;
                    case Contracts:
                        var newContract = ReceveidContractsValues();
                        if (CheckDocumentToConfirm(newContract) == "1")
                            docEdit.ChangeItensDocument(newContract);
                        break;
                    case FuntionalitiesLicenses:
                        var newLicence = ReceveidLicensesValues();
                        if (CheckDocumentToConfirm(newLicence) == "1")
                            docEdit.ChangeItensDocument(newLicence);
                        break;
                }
                Console.Clear();
            }
            catch
            {
                ScreamMessage.ClearRedAlert(0);
            }
            UserScream.MainMenu();
        }

        public static void EditingDocumentStatus()
        {
            try
            {
                var docEdit = GeneralData.SearchOneDocument(ReceveidDocCode());
                DocumentStatus status = ChooseStatus();
                docEdit.ChangeDocumentStatus(status);
            }
            catch
            {
                ScreamMessage.ClearRedAlert(1);
            }
            Console.Clear();
            UserScream.MainMenu();
        }

        private static string CheckDocumentToConfirm(DevInDocument docCreation)
        {
            Console.Clear();
            docCreation.ScreamDocument();
            ScreamMessage.YellowAlert(0);
            ScreamMessage.RedAlert(1);
            return Console.ReadLine();
        }

        public static TaxInvoice ReceveidTaxValues()
        {
            ScreamMessage.FormsMessage(0);
            string newEstablishmentName = Console.ReadLine();
            ScreamMessage.FormsMessage(1);
            string newCnpj = Console.ReadLine();
            ScreamMessage.FormsMessage(2);
            string newTotalValue = Console.ReadLine();
            ScreamMessage.FormsMessage(3);
            string newSelledProductName = Console.ReadLine();
            ScreamMessage.FormsMessage(4);
            ScreamMessage.YellowAlert(1);
            TaxType newTaxType = UserStream.ChoosenTaxType(Console.ReadLine());
            ScreamMessage.FormsMessage(5);
            string newTotalTaxValue = Console.ReadLine();

            return new TaxInvoice(GeneralData._employee.Id, newEstablishmentName, newCnpj, decimal.Parse(newTotalValue),
                                  newSelledProductName, newTaxType, decimal.Parse(newTotalTaxValue));
        }

        public static Contracts ReceveidContractsValues()
        {
            ScreamMessage.FormsMessage(0);
            string newEstablishmentName = Console.ReadLine();
            ScreamMessage.FormsMessage(1);
            string newCnpj = Console.ReadLine();
            ScreamMessage.FormsMessage(6);
            string newGoals = Console.ReadLine();
            ScreamMessage.FormsMessage(7);
            string[] newWitnessName = { "", "" };
            newWitnessName[0] = Console.ReadLine();
            ScreamMessage.FormsMessage(8);
            newWitnessName[1] = Console.ReadLine();
            ScreamMessage.FormsMessage(9);
            string year = Console.ReadLine();
            ScreamMessage.FormsMessage(10);
            string month = Console.ReadLine();
            ScreamMessage.FormsMessage(11);
            string day = Console.ReadLine();

            return new Contracts(GeneralData._employee.Id, newEstablishmentName, newCnpj, newGoals, newWitnessName,
                                 new DateTime(int.Parse(year), int.Parse(month), int.Parse(day)));
        }

        public static FuntionalitiesLicenses ReceveidLicensesValues()
        {
            ScreamMessage.FormsMessage(0);
            string newEstablishmentName = Console.ReadLine();
            ScreamMessage.FormsMessage(1);
            string newCnpj = Console.ReadLine();
            ScreamMessage.FormsMessage(12);
            string newAdress = Console.ReadLine();
            ScreamMessage.FormsMessage(13);
            ScreamMessage.YellowAlert(2);
            Operation newOperation = UserStream.ChoosenOperationType(Console.ReadLine());

            return new FuntionalitiesLicenses(GeneralData._employee.Id, newEstablishmentName, newCnpj, newAdress, newOperation);
        }

        public static DocumentStatus ChooseStatus()
        {
            ScreamMessage.FormsMessage(14);
            ScreamMessage.YellowAlert(3);
            DocumentStatus status = UserStream.ChoosenStatusType(Console.ReadLine());

            return status;
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
                    ScreamMessage.RedAlert(0);
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
                    ScreamMessage.RedAlert(0);
                    _operation =  ChoosenOperationType(Console.ReadLine());
                    break;
            }
            return _operation;
        }

        public static DocumentStatus ChoosenStatusType(string value)
        {
            DocumentStatus status;
            switch (value)
            {
                case "0":
                    return DocumentStatus.Active;
                case "1":
                    return DocumentStatus.Processing;
                case "2":
                    return DocumentStatus.Suspended;
                default:
                    ScreamMessage.RedAlert(0);
                    status = ChoosenStatusType(Console.ReadLine());
                    break;
            }
            return status;
        }
    }
}
