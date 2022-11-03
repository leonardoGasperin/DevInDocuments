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
    }
}
