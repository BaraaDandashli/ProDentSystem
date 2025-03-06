using System;
using System.Data;
using System.Runtime.Remoting;
using ClinicDataAccessLayer;



namespace ClinicBusinessLayer
{
    public class clsLaboratories
    {
        public int LabID { get; set; }
        public string LaboratoryName { get; set; }
        public string Mobile {  get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }



        public clsLaboratories()
        {
            this.LabID = -1;
            this.LaboratoryName = "";
            this.Mobile = "";
            this.Phone = "";
            this.Address = "";
        }
        public clsLaboratories(int labID, string LabName, string Mobile, string Phone, string Address)
        {
            this.LabID = labID;
            this.LaboratoryName = LabName;
            this.Mobile = Mobile;
            this.Phone = Phone;
            this.Address = Address;
        }

        public static DataTable GetAllLaboratories()
        {
            return clsLaboratoriesData.GetAllLaboratories();
        }
               

        private ClinicDataAccessLayer.stLaboratory InitialLaboratoryData()
        {
            ClinicDataAccessLayer.stLaboratory newLaboratory = new stLaboratory();

            newLaboratory.LaboratoryName = this.LaboratoryName;
            newLaboratory.Mobile = this.Mobile;
            newLaboratory.Phone = this.Phone;
            newLaboratory.Address = this.Address;

            return newLaboratory;
        }

        public bool AddNewLaboratories()
        {
            return clsLaboratoriesData.AddNewLaboratory(InitialLaboratoryData());
        }

        public DataTable GetLabLineByLabName(string startWith)
        {
            return clsLaboratoriesData.GetLabLineByLabName(startWith);
        }

        public static clsLaboratories GetLaboratoryData(int labID)
        {
            ClinicDataAccessLayer.stLaboratory updateLaboratoryData = new stLaboratory();

            updateLaboratoryData.LaboratoryName = "";
            updateLaboratoryData.Mobile = "";
            updateLaboratoryData.Phone = "";
            updateLaboratoryData.Address = "";

            if (clsLaboratoriesData.GetLaboratoryData(labID,ref updateLaboratoryData))
            {
                return new clsLaboratories(labID,updateLaboratoryData.LaboratoryName, updateLaboratoryData.Mobile, updateLaboratoryData.Phone, updateLaboratoryData.Address);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteLaboratoryDataFromDataBase(int labID)
        {
            return clsLaboratoriesData.DeleteLaboratoryDataFromDataBase(labID);
        }

        public bool UpdateLaboratoryData(int labID)
        {
            ClinicDataAccessLayer.stLaboratory NewLaboratoryData = InitialLaboratoryData();

            return clsLaboratoriesData.UpdateLaboratoryData(labID, NewLaboratoryData);
        }

       


    }
}
