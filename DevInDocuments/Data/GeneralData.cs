﻿using DevInDocuments.Entities.Company;
using DevInDocuments.Entities.Person;
using DevInDocuments.Features;

namespace DevInDocuments.Data
{
    internal class GeneralData
    {
        public static List<DevInDocument> documentsList;
        public static Employee _employee;

        public static void InitializeList()
        {
            documentsList = new List<DevInDocument>();
        }

        public static void InitializeMenu(Employee employee)
        {
            _employee = employee;
        }
    
        public static void SearchByStatus(DocumentStatus value)
        {
            foreach(var item in documentsList)
            {
                if (item.DocumentStatus == value)
                    item.ScreemDocument();
            }
        }

        public static DevInDocument SearchOneDocument(int code)
        {
            foreach (var doc in GeneralData.documentsList)
            {
                if (doc.DocumentCode == code)
                {
                    ScreemMessage.ClearGreenAlert(0);
                    return doc;
                }
            }
            ScreemMessage.ClearRedAlert(1);
            return null;
        }
    }
}
