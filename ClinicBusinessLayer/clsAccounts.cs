using ClinicDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusinessLayer
{
    public class clsAccounts
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }

        public clsAccounts()
        {
            ItemID = -1;
            ItemName = "";
            Price = 0;
        }
        public clsAccounts(int itemID,string itemName,decimal price)
        {
            ItemID = itemID;
            ItemName = itemName;
            Price = price;
        }


        public static DataTable GetAllAccounts()
        {
            return clsAccountsData.GetAllAccounts();
        }

        public static decimal GetTotalAmount()
        {
            return clsAccountsData.GetTotalAmount();
        }

        public static DataTable GetPatientAccountsByName(string data)
        {
            return clsAccountsData.GetPatientAccountsByName(data);
        }

        private ClinicDataAccessLayer.stFees InitialNewFee()
        {
            ClinicDataAccessLayer.stFees fee = new stFees();

            fee.ItemName = this.ItemName;
            fee.Price = this.Price;

            return fee;
        }



        ///Fees\\\
        public bool AddNewItem()
        {
            return clsAccountsData.AddNewItem(InitialNewFee());
        }
        public static DataTable GetAllItemsInFees()
        {
            return clsAccountsData.GetAllItemsInFees();
        }
        public static DataTable GetAllFeesBetweenTwoDate(string start, string end)
        {
            return clsAccountsData.GetAllFeesBetweenTwoDate(start, end);
        }
        public static clsAccounts GetItemDataByID(int itemID)
        {
            ClinicDataAccessLayer.stFees updateFee = new stFees();

            updateFee.ItemID = itemID;
            updateFee.ItemName = "";
            updateFee.Price = 0;

            if (clsAccountsData.GetItemDataByID(itemID, ref updateFee))
            {
                return new clsAccounts(updateFee.ItemID, updateFee.ItemName, updateFee.Price);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteItemFromFees(int itemID)
        {
            return clsAccountsData.DeleteItemFromFees(itemID);
        }
        public bool UpdateItemInFees(int itemID)
        {
            return clsAccountsData.UpdateItemInFees(itemID, InitialNewFee());
        }
        public static decimal GetTotalFees()
        {
            return clsAccountsData.GetTotalFees();
        }
        public static decimal GetTotalFeesBetweenTwoDate(string start, string end)
        {
            return clsAccountsData.GetTotalFeesBetweenTwoDate(start, end);
        }
    }

}
