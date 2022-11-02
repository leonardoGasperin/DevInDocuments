using DevInDocuments.Entities.Company;
using DevInDocuments.Entities.Person;
using System.Reflection;

namespace DevInDocuments.Data
{
    internal static class GeneralData
    {
        public static List<DevInDocument> documentsList;

        public static void InitializeList()
        {
            documentsList = new List<DevInDocument>();
        }
        public static List<TaxInvoice> GeneratingTaxInvoiceList()
        {
            List<TaxInvoice> taxInvoiceList = new List<TaxInvoice>();
            foreach (var taxInvoice in documentsList)
            {
                if (taxInvoice is TaxInvoice)
                    taxInvoiceList.Add((TaxInvoice)taxInvoice);
            }
            return taxInvoiceList;
        }

        public static List<FuntionalitiesLicenses> GeneratingLicensesList()
        {
            List<FuntionalitiesLicenses> licensesList = new List<FuntionalitiesLicenses>();
            foreach (var licenses in documentsList)
            {
                if (licenses is FuntionalitiesLicenses)
                    licensesList.Add((FuntionalitiesLicenses)licenses);
            }
            return licensesList;
        }
    }
}
