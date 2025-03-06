using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicDataAccessLayer;

namespace ClinicBusinessLayer
{
    public class clsLoginSettings
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Mobile {  get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }
        public DateTime Date {  get; set; }

        public enum enPermissions
        {
            eAll = -1, eLaboratoryInfo = 1,eLabsList = 2, ePrescriptions = 4,eAddPatient = 8,
            eListPatients = 16,eTreatmentPlan = 32 , eTreatments = 64 ,eAppointments = 128,eAccounts = 256,
            eSettings = 512
        }

        public clsLoginSettings()
        {
            this.UserID = -1;
            this.Name = "";
            this.Mobile = "";
            this.UserName = "";
            this.Password = "";
            this.Permissions = -1;
            this.Date = DateTime.Now;
        }
        public clsLoginSettings(int userID, string name, string mobile, string userName, string password, int permissions)
        {
            this.UserID = userID;
            this.Name = name;
            this.Mobile = mobile;
            this.UserName = userName;
            this.Password = password;
            this.Permissions = permissions;
        }

        public clsLoginSettings(int userID, string name, string userName, string password, int permissions)
        {
            this.UserID = userID;
            this.Name = name;
            this.UserName = userName;
            this.Password = password;
            this.Permissions = permissions;
        }

        public bool CheckAccessPermission(enPermissions permission)
        {
            if (this.Permissions == (int)enPermissions.eAll)
            {
                return true;
            }
            if ((permission & (enPermissions)this.Permissions) == permission)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private ClinicDataAccessLayer.stUserInfo InitialUserInfo()
        {
            ClinicDataAccessLayer.stUserInfo userInfo = new stUserInfo();

            userInfo.Name = this.Name;
            userInfo.Mobile = this.Mobile;
            userInfo.UserName = this.UserName;
            userInfo.Password = this.Password;
            userInfo.Permissions = this.Permissions;

            return userInfo;
        }

        public bool AddNewUser()
        {
            return clsLoginSettingsData.AddNewUser(InitialUserInfo());
        }

        public static DataTable GetAllUsers()
        {
            return clsLoginSettingsData.GetAllUsers();
        }
        public static clsLoginSettings GetUserInfo(int userID)
        {
            ClinicDataAccessLayer.stUserInfo userInfo = new stUserInfo();

            userInfo.Name = "";
            userInfo.Mobile = "";
            userInfo.UserName = "";
            userInfo.Password = "";
            userInfo.Permissions = -1;

            if (clsLoginSettingsData.GetUserInfo(ref userInfo, userID))
            {
                return new clsLoginSettings(userID, userInfo.Name, userInfo.Mobile, userInfo.UserName, userInfo.Password,
                    userInfo.Permissions);
            }
            else
            {
                return null;
            }
        }

        public static clsLoginSettings Find(int userID)
        {
            ClinicDataAccessLayer.stUserInfo userInfo = new stUserInfo();

            userInfo.Name = "";
            userInfo.UserName = "";
            userInfo.Password = "";
            userInfo.Permissions = 0;

            if (clsLoginSettingsData.Find(ref userInfo, userID))
            {
                return new clsLoginSettings(userID, userInfo.Name, userInfo.UserName, userInfo.Password, userInfo.Permissions);
            }
            else
            {
                return null;
            }
        }

        public bool UpdateUserInfo(int userID)
        {
            return clsLoginSettingsData.UpdateUserInfo(userID, InitialUserInfo());
        }

        public static bool DeleteUserFromDataBase(int userID)
        {
            return clsLoginSettingsData.DeleteUser(userID);
        }

        public static int IsUserExist(string userName,string password)
        {
            return clsLoginSettingsData.IsUserExist(userName, password);
        }
        

        public static bool BackupDatabase(string fileName, string filePath)
        {
            return clsDataBaseBackup.BackupDatabase(fileName, filePath);
        }
        public static bool RestoreDatabase(string backupFilePath)
        {
            return clsDataBaseBackup.RestoreDatabase(backupFilePath);
        }


    }
}
