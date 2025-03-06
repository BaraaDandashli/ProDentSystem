using System;
using System.Data;
using ClinicDataAccessLayer;


namespace ClinicBusinessLayer
{
    public class clsPrescriptions
    {
        public string PatientName { get; set; }
        public string DrugName { get; set; }
        public string Quantity { get; set; }
        public string Details { get; set; }
        public string Timing { get; set; }
        public DateTime Date {  get; set; }

        public clsPrescriptions()
        {
            this.PatientName = "";
            this.DrugName = "";
            this.Quantity = "";
            this.Details = "";
            this.Timing = "";
            this.Date = DateTime.Now;
        }
        public clsPrescriptions(string patientName, string drugName, string quantity, string details, string timing, DateTime date)
        {
            this.PatientName = patientName;
            this.DrugName = drugName;
            this.Quantity = quantity;
            this.Details = details;
            this.Timing = timing;
            this.Date = date;
        }




        private ClinicDataAccessLayer.stNewPrescription InitialNewPrescription()
        {
            ClinicDataAccessLayer.stNewPrescription newPrescription = new stNewPrescription();

            newPrescription.PatientName = this.PatientName;
            newPrescription.DrugName = this.DrugName;
            newPrescription.Quantity = this.Quantity;
            newPrescription.Details = this.Details;
            newPrescription.Timing = this.Timing;
            newPrescription.Date = this.Date;

            return newPrescription;
        }

        public bool AddNewPrescription()
        {
            ClinicDataAccessLayer.stNewPrescription newPrescription = InitialNewPrescription();

            return clsPrescriptionsData.AddNewPrescription(newPrescription);
        }

        public static DataTable GetAllPrescriptions()
        {
            return clsPrescriptionsData.GetAllPrescriptions();
        }

        public DataTable GetPrescriptionByPatientName(string startWith)
        {
            return clsPrescriptionsData.GetPrescriptionByPatientName(startWith);
        }

        public static bool DeletePrescriptionFromDatabase(int PrescriptionID)
        {
            return clsPrescriptionsData.DeletePrescriptionFromDatabase(PrescriptionID);
        }
        public bool UpdatePrescription(int PrescriptionID)
        {
            return clsPrescriptionsData.UpdatePrescription(PrescriptionID, InitialNewPrescription());
        }

        public static clsPrescriptions GetPrescriptionCard(int PrescriptionID)
        {
            ClinicDataAccessLayer.stNewPrescription currentPrescription = new stNewPrescription();

            currentPrescription.PatientName = "";
            currentPrescription.DrugName = "";
            currentPrescription.Quantity = "";
            currentPrescription.Timing = "";
            currentPrescription.Details = "";
            currentPrescription.Date = DateTime.Now;


            if (clsPrescriptionsData.GetPrescriptionCard(PrescriptionID, ref currentPrescription))
            {
                return new clsPrescriptions(currentPrescription.PatientName, currentPrescription.DrugName, currentPrescription.Quantity,
                    currentPrescription.Details, currentPrescription.Timing, currentPrescription.Date);
            }
            else
            {
                return null;
            }
        }


    }
}
