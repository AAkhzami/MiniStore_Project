using MiniStoreDB_DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace MiniStoreDB_Business_Layer
{
    public class clsCategories
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int? CategoryID { get; set; }
        public string Name { get; set; }

        public clsCategories()
        {
            this.CategoryID = 0;
            this.Name = null;
            Mode = enMode.AddNew;
        }
        private clsCategories(int categoryid, string name)
        {
            this.CategoryID = categoryid;
            this.Name = name;
            Mode = enMode.Update;
        }

        public static clsCategories Find(int CategoryID)
        {
            string Name = null;

            bool IsFound = clsCategoriesData.GetCategoriesInfoByID(CategoryID, ref Name);
            if (IsFound)
            {
                return new clsCategories(CategoryID, Name);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewCategories()
        {
            this.CategoryID = clsCategoriesData.AddNewCategories(this.Name);
            return (this.CategoryID != null);
        }

        private bool _UpdateCategories()
        {
            return clsCategoriesData.UpdateCategoriesInfoByID(this.CategoryID ?? -1, this.Name);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCategories())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateCategories();
            }
            return false;
        }

        public static bool DeleteCategories(int CategoryID)
        {
            return clsCategoriesData.DeleteCategoriesByID(CategoryID);
        }

        public static DataTable GetAllCategories()
        {
            return clsCategoriesData.GetAllCategories();
        }

    }
}
