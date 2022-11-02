namespace DevInDocuments.Data
{
    internal static class UserStream
    {
        public static void SearchOneDocument(int code)
        {
            foreach(var doc in GeneralData.documentsList)
            {
                if (doc.DocumentCode == code)
                    doc.ScreemDocument();
            }
        }

        public static void RegisteringDocument()
        {

        }

        public static void EditingDocument()
        {

        }
    }
}
