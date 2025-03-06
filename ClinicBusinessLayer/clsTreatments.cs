using System;
using System.Collections.Generic;
using System.Data;
using ClinicDataAccessLayer;
using static System.Net.Mime.MediaTypeNames;


namespace ClinicBusinessLayer
{
    public class clsTreatments
    {
        public int PatientID { get; set; }
        public string ToothNum { get; set; }
        public string TreatmentType { get; set; }
        public string Notes { get; set; }
        public decimal Cost { get; set; }
        public decimal Recevied { get; set; }
        public decimal Remaining { get; set; }

        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public string Image5 { get; set; }
        public string Image6 { get; set; }
        public string Image7 { get; set; }
        public string Image8 { get; set; }
        public string Image9 { get; set; }
        public string Image10 { get; set; }
        public string Image11 { get; set; }
        public string Image12 { get; set; }

        public List<string> Images { get; set; }

        public clsTreatments()
        {
            this.PatientID = -1;
            this.ToothNum = "";
            this.TreatmentType = "";
            this.Notes = "";
            this.Cost = 0;
            this.Recevied = 0;
            this.Remaining = 0;            
        }
        public clsTreatments(int patientID, string toothNum, string treatmentType, string notes,
            decimal cost, decimal recevied, decimal remaining, List<string> images)
        {
            this.PatientID = patientID;
            this.ToothNum = toothNum;
            this.TreatmentType = treatmentType;
            this.Notes = notes;
            this.Cost = cost;
            this.Recevied = recevied;
            this.Remaining = remaining;
            this.Images = images;
        }
        public clsTreatments(int patientID, string toothNum, string treatmentType, string notes,
            decimal cost, decimal recevied, decimal remaining)
        {
            this.PatientID = patientID;
            this.ToothNum = toothNum;
            this.TreatmentType = treatmentType;
            this.Notes = notes;
            this.Cost = cost;
            this.Recevied = recevied;
            this.Remaining = remaining;
        }
        public clsTreatments(List<string> images)
        {
            this.Images = images;
        }
        
        private ClinicDataAccessLayer.stTreatmentPlan InitialNewTreatmentPlan()
        {
            ClinicDataAccessLayer.stTreatmentPlan newTreatmentPlan = new stTreatmentPlan();

            newTreatmentPlan.PatientID = this.PatientID;
            newTreatmentPlan.ToothNum = this.ToothNum;
            newTreatmentPlan.TreatmentType = this.TreatmentType;
            newTreatmentPlan.Notes = this.Notes;
            newTreatmentPlan.Cost = this.Cost;
            newTreatmentPlan.Recevied = this.Recevied;
            newTreatmentPlan.Remaining = this.Remaining;

            return newTreatmentPlan;
        }
        private ClinicDataAccessLayer.stImagesFile InitialNewImagesFile()
        {
            ClinicDataAccessLayer.stImagesFile newImagesFile = new stImagesFile();
            
            newImagesFile.Images = new List<string>();
            
            foreach (string image in this.Images)
            {
                newImagesFile.Images.Add(image);
            }            

            return newImagesFile;
        }

        public int AddNewTreatmentPlan()
        {
            ClinicDataAccessLayer.stTreatmentPlan newTreatmentPlan = InitialNewTreatmentPlan();

            return clsTreatmentsData.AddNewTreatmentPlan(newTreatmentPlan);
        }
        public static DataTable GetAllTreatmentsList()
        {
            return clsTreatmentsData.GetAllTreatmentsList();
        }

        public bool AddNewImagesFile(int treatmentID, int patientID)
        {
            ClinicDataAccessLayer.stImagesFile newImagesFile = InitialNewImagesFile();

            return clsTreatmentsData.AddNewImagesFile(treatmentID, patientID, newImagesFile);
        }

        public static List<string> GetPatientImagesFile(int treatmentID)
        {
            return clsTreatmentsData.GetPatientImagesFile(treatmentID);
        }

        public static bool DeleteTreatmentFromDatabase(int treatmentID)
        {
            return clsTreatmentsData.DeleteTreatmentFromDatabase(treatmentID);
        }

        public bool UpdateTreatmentPlan(int treatmentID)
        {
            return clsTreatmentsData.UpdateTreatmentPlan(treatmentID, InitialNewTreatmentPlan());
        }

        public static clsTreatments GetTreatmentPlan(int treatmentID)
        {
            ClinicDataAccessLayer.stTreatmentPlan treatmentPlan = new stTreatmentPlan();

            treatmentPlan.PatientID = -1;
            treatmentPlan.ToothNum = "";
            treatmentPlan.TreatmentType = "";
            treatmentPlan.Notes = "";
            treatmentPlan.Cost = 0;
            treatmentPlan.Recevied = 0;
            treatmentPlan.Remaining = 0;

            if (clsTreatmentsData.GetTreatmentPlan(treatmentID, ref treatmentPlan))
            {
                return new clsTreatments(treatmentPlan.PatientID, treatmentPlan.ToothNum, treatmentPlan.TreatmentType, treatmentPlan.Notes, treatmentPlan.Cost,
                    treatmentPlan.Recevied, treatmentPlan.Remaining);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetTreatmentInfoByName(string data)
        {
            return clsTreatmentsData.GetTreatmentInfoByName(data);
        }


    }
}
