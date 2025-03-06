using System;
using System.Data;
using ClinicDataAccessLayer;


namespace ClinicBusinessLayer
{
    public class clsLabInfo
    {
        public string PatientName { get; set; }
        public string LabName { get; set; }
        public string TypeOfQuantity { get; set; }
        public string ToothNum { get; set; }
        public DateTime Date {  get; set; }

        public clsLabInfo()
        {
            this.PatientName = "";
            this.LabName = "";
            this.TypeOfQuantity = "";
            this.ToothNum = "";
            this.Date = DateTime.Now;
        }
        public clsLabInfo(string patientName, string labName, string typeOfQuantity, string toothNum, DateTime Date)
        {
            this.PatientName = patientName;
            this.LabName = labName;
            this.TypeOfQuantity = typeOfQuantity;
            this.ToothNum = toothNum;
            this.Date = Date;
        }

        public static DataTable GetAllLaboratoriesNames()
        {
            return clsLabInfoData.GetAllLaboratoriesNames();
        }

        public static DataTable GetAllLabInfoLines()
        {
            return clsLabInfoData.GetAllLabInfoLines();
        }

        private ClinicDataAccessLayer.stNewLabInfo InitialLabInfo()
        {
            ClinicDataAccessLayer.stNewLabInfo newLabInfo = new stNewLabInfo();

            newLabInfo.PatientName = this.PatientName;
            newLabInfo.LabName = this.LabName;
            newLabInfo.TypeOfQuantity = this.TypeOfQuantity;
            newLabInfo.ToothNum = this.ToothNum;
            newLabInfo.Date = this.Date;
        
            return newLabInfo;
        }

        public bool AddNewLabInfoLine()
        {
            ClinicDataAccessLayer.stNewLabInfo newLabInfo = InitialLabInfo();
            
            return clsLabInfoData.AddNewLabInfoLine(newLabInfo);
        }

        public DataTable GetLabInfoLineByPatientName(string startWith)
        {
            return clsLabInfoData.GetLabInfoLineByPatientName(startWith);
        }

        public static bool DeleteLabInfoFromDatabase(int labInfoID)
        {
            return clsLabInfoData.DeleteLabInfoFromDatabase(labInfoID);
        }
        public bool UpdateLabInfoData(int labInfoID)
        {
            return clsLabInfoData.UpdateLabInfoData(labInfoID, InitialLabInfo());
        }

        public static clsLabInfo GetLabInfoCard(int labInfoID)
        {
            ClinicDataAccessLayer.stNewLabInfo currentLabInfo = new stNewLabInfo();

            currentLabInfo.PatientName = "";
            currentLabInfo.LabName = "";
            currentLabInfo.TypeOfQuantity = "";
            currentLabInfo.ToothNum  = "";
            currentLabInfo.Date = DateTime.Now;

            if (clsLabInfoData.GetLabInfoCard(labInfoID, ref currentLabInfo))
            {
                return new clsLabInfo(currentLabInfo.PatientName, currentLabInfo.LabName, currentLabInfo.TypeOfQuantity,
                    currentLabInfo.ToothNum, currentLabInfo.Date);
            }
            else
            {
                return null;
            }
        }


    }
}
