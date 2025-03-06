using System;
using System.Data;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using ClinicDataAccessLayer;

namespace ClinicBusinessLayer
{
    public class clsMedicalHistory
    {
        public string M1 { get; set ; }
        public string M2 { get; set; }
        public string M3 { get; set; }
        public string M4 { get; set; }
        public string M5 { get; set; }
        public string M6 { get; set; }
        public string M7 { get; set; }
        public string M8 { get; set; }
        public string M9 { get; set; }
        public string M10 { get; set; }
        public string M11 { get; set; }
        public string M12 { get; set; }
        public string OthersMH { get; set; }

        public clsMedicalHistory()
        {
            this.M1 = "null";
            this.M2 = "null";
            this.M3 = "null";
            this.M4 = "null";
            this.M5 = "null";
            this.M6 = "null";
            this.M7 = "null";
            this.M8 = "null";
            this.M9 = "null";
            this.M10 = "null";
            this.M11 = "null";
            this.M12 = "null";
            this.OthersMH = "null";
        }
        public clsMedicalHistory(string m1, string m2, string m3, string m4, string m5, string m6, string m7, string m8, string m9, string m10, string m11, string m12, string othersMH)
        {
            this.M1 = m1;
            this.M2 = m2;
            this.M3 = m3;
            this.M4 = m4;
            this.M5 = m5;
            this.M6 = m6;
            this.M7 = m7;
            this.M8 = m8;
            this.M9 = m9;
            this.M10 = m10;
            this.M11 = m11;
            this.M12 = m12;
            this.OthersMH = othersMH;
        }
    }

    public class clsRelatedBox
    {
        public string Pregnant { get; set; }
        public string Breastfeeding { get; set; }
        public string Smoker { get; set; }
        public string Count { get; set; }
        public string OthersR { get; set; }

        public clsRelatedBox()
        {
            this.Pregnant = "null";
            this.Breastfeeding = "null";
            this.Smoker = "null";
            this.Count = "null";
            this.OthersR = "null";
        }

        public clsRelatedBox(string pregnant, string breastfeeding, string smoker, string count, string othersR)
        {
            this.Pregnant = pregnant;
            this.Breastfeeding = breastfeeding;
            this.Smoker = smoker;
            this.Count = count;
            this.OthersR = othersR;
        }
    }

    public class clsPatients
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public clsMedicalHistory medicalHistory;
        public clsRelatedBox relatedBox;

        public int PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName { get; set; }
        public string Age { get; set; }
        public string BirthDate { get; set; }
        public string Gendor {  get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Career { get; set; }
        public string Address { get; set; }
        public DateTime DateNow { get; set; }

        public string M1 { get; set; }
        public string M2 { get; set; }
        public string M3 { get; set; }
        public string M4 { get; set; }
        public string M5 { get; set; }
        public string M6 { get; set; }
        public string M7 { get; set; }
        public string M8 { get; set; }
        public string M9 { get; set; }
        public string M10 { get; set; }
        public string M11 { get; set; }
        public string M12 { get; set; }
        public string OthersMH { get; set; }

        public string Pregnant { get; set; }
        public string Breastfeeding { get; set; }
        public string Smoker { get; set; }
        public string Count { get; set; }
        public string OthersR { get; set; }

        public clsPatients(int patientID,string fullName, string age)
        {
            this.PatientID = patientID;
            this.FullName = fullName;
            this.Age = age;
        }

        public clsPatients()
        {
            this.PatientID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.BirthDate = "";
            this.Gendor = "";
            this.Mobile = "";
            this.Phone = "";
            this.Career = "";
            this.Address = "";
            this.DateNow = DateTime.Now;

            this.M1 = "";
            this.M2 = "";
            this.M3 = "";
            this.M4 = "";
            this.M5 = "";
            this.M6 = "";
            this.M7 = "";
            this.M8 = "";
            this.M9 = "";
            this.M10 = "";
            this.M11 = "";
            this.M12 = "";
            this.OthersMH = "";

            this.Pregnant = "";
            this.Breastfeeding = "";
            this.Smoker = "";
            this.Count = "";
            this.OthersR = "";      
            
            
        }


        public clsPatients(int patientID, string firstName, string lastName, string birthDate, string gendor, string mobile
            , string phone, string career, string address)
        {
            this.PatientID = patientID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.Gendor = gendor;
            this.Mobile = mobile;
            this.Phone = phone;
            this.Career = career;
            this.Address = address;
            this.DateNow = DateTime.Now;

            Mode = enMode.Update;
        }

        public clsPatients(int patientID, string firstName, string lastName, string birthDate, string gendor, string mobile
            , string phone, string career, string address,string m1, string m2, string m3, string m4, string m5,
            string m6, string m7, string m8, string m9, string m10, string m11, string m12, string othersMH)
        {
            this.PatientID = patientID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.Gendor = gendor;
            this.Mobile = mobile;
            this.Phone = phone;
            this.Career = career;
            this.Address = address;
            this.DateNow = DateTime.Now;

            this.M1 = m1;
            this.M2 = m2;
            this.M3 = m3;
            this.M4 = m4;
            this.M5 = m5;
            this.M6 = m6;
            this.M7 = m7;
            this.M8 = m8;
            this.M9 = m9;
            this.M10 = m10;
            this.M11 = m11;
            this.M12 = m12;
            this.OthersMH = othersMH;

            Mode = enMode.Update;
        }

        public clsPatients(int patientID, string firstName, string lastName, string birthDate, string gendor, string mobile
            , string phone, string career, string address, string pregnant, string breastfeeding, string smoker, string count, string othersR)
        {
            this.PatientID = patientID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.Gendor = gendor;
            this.Mobile = mobile;
            this.Phone = phone;
            this.Career = career;
            this.Address = address;
            this.DateNow = DateTime.Now;

            this.Pregnant = pregnant;
            this.Breastfeeding = breastfeeding;
            this.Smoker = smoker;
            this.Count = count;
            this.OthersR = othersR;

            Mode = enMode.Update;
        }

        public clsPatients(int patientID, string firstName, string lastName, string birthDate, string gendor, string mobile
            , string phone, string career, string address, string m1, string m2, string m3, string m4, string m5,
            string m6, string m7, string m8, string m9, string m10, string m11, string m12, string othersMH,
            string pregnant, string breastfeeding, string smoker, string count, string othersR)
        {
            this.PatientID = patientID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.Gendor = gendor;
            this.Mobile = mobile;
            this.Phone = phone;
            this.Career = career;
            this.Address = address;
            this.DateNow = DateTime.Now;

            this.M1 = m1;
            this.M2 = m2;
            this.M3 = m3;
            this.M4 = m4;
            this.M5 = m5;
            this.M6 = m6;
            this.M7 = m7;
            this.M8 = m8;
            this.M9 = m9;
            this.M10 = m10;
            this.M11 = m11;
            this.M12 = m12;
            this.OthersMH = othersMH;

            this.Pregnant = pregnant;
            this.Breastfeeding = breastfeeding;
            this.Smoker = smoker;
            this.Count = count;
            this.OthersR = othersR;

            Mode = enMode.Update;
        }

        public clsPatients(string m1, string m2, string m3, string m4, string m5,
            string m6, string m7, string m8, string m9, string m10, string m11, string m12, string othersMH)
        {
            this.M1 = m1;
            this.M2 = m2;
            this.M3 = m3;
            this.M4 = m4;
            this.M5 = m5;
            this.M6 = m6;
            this.M7 = m7;
            this.M8 = m8;
            this.M9 = m9;
            this.M10 = m10;
            this.M11 = m11;
            this.M12 = m12;
            this.OthersMH = othersMH;
        }

        public clsPatients(string pregnant, string breastfeeding, string smoker, string count, string othersR)
        {
            this.Pregnant = pregnant;
            this.Breastfeeding = breastfeeding;
            this.Smoker = smoker;
            this.Count = count;
            this.OthersR = othersR;
        }

        private ClinicDataAccessLayer.stGeneralInfo InitialGeneralInfo()
        {
            ClinicDataAccessLayer.stGeneralInfo patient = new stGeneralInfo();

            patient.patientID = this.PatientID;
            patient.FirstName = this.FirstName;
            patient.LastName = this.LastName;
            patient.BirthDate = this.BirthDate;
            patient.Gendor = this.Gendor;
            patient.Mobile = this.Mobile;
            patient.Phone = this.Phone;
            patient.Career = this.Career;
            patient.Address = this.Address;

            return patient;
        }
        private ClinicDataAccessLayer.stMedicalHistory InitialMedicalHistory()
        {
            ClinicDataAccessLayer.stMedicalHistory MedicalHistory = new stMedicalHistory();

            MedicalHistory.M1 = this.M1;
            MedicalHistory.M2 = this.M2;
            MedicalHistory.M3 = this.M3;
            MedicalHistory.M4 = this.M4;
            MedicalHistory.M5 = this.M5;
            MedicalHistory.M6 = this.M6;
            MedicalHistory.M7 = this.M7;
            MedicalHistory.M8 = this.M8;
            MedicalHistory.M9 = this.M9;
            MedicalHistory.M10 = this.M10;
            MedicalHistory.M11 = this.M11;
            MedicalHistory.M12 = this.M12;
            MedicalHistory.OthersMH = this.OthersMH;

            return MedicalHistory;
        }
        private ClinicDataAccessLayer.stRelatedBox InitialRelatedBox()
        {
            ClinicDataAccessLayer.stRelatedBox RelatedBox = new stRelatedBox();

            RelatedBox.Pregnant = this.Pregnant;
            RelatedBox.Breastfeeding = this.Breastfeeding;
            RelatedBox.Smoker = this.Smoker;
            RelatedBox.Count = this.Count;
            RelatedBox.Others_R = this.OthersR;

            return RelatedBox;
        }




        public int _AddNewPatient(bool isHaveMedicalHistory, bool isHaveRelatedBox)
        {
            this.PatientID = clsPatientData.AddNewPatient(InitialGeneralInfo(), InitialMedicalHistory(), InitialRelatedBox(), isHaveMedicalHistory, isHaveRelatedBox);
            
            return this.PatientID;
        }

        public bool AddNewMedicalHistory(int patientID)
        {
            return clsPatientData._AddNewMedicalHistory(InitialMedicalHistory(), patientID);
        }
        public bool AddNewRelatedBox(int patientID)
        {
            return clsPatientData._AddNewRelatedBox(InitialRelatedBox(), patientID);
        }

        public static DataTable GetAllPatients()
        {
            return clsPatientData.GetAllPatients();
        }

        public static DataTable GetPatientInfo(string data)
        {
            char firstChar = data[0];

            if (char.IsLetter(firstChar))
            {
                return clsPatientData.GetPatientInfoByName(data);
            }
            else
            {
                return clsPatientData.GetPatientInfoByMobileNumber(data);
            }
        }


        public static clsPatients Find(string data)
        {
            ClinicDataAccessLayer.stPatientCard patientCard = new stPatientCard();

            char firstChar = data[0];

            patientCard.FullName = "";
            patientCard.Age = "";

            //if (clsPatientData.GetPatientCardByPatientID(ref patientCard, fullName))
            //{
            //    return new clsPatients(patientCard.PatientID, patientCard.FullName, patientCard.Age);
            //}
            //else
            //{
            //    return null;
            //}

            if (char.IsLetter(firstChar))
            {
                if (clsPatientData.GetPatientCardByPatientName(ref patientCard, data))
                {
                    return new clsPatients(patientCard.PatientID, patientCard.FullName, patientCard.Age);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                patientCard.PatientID = int.Parse(data);

                if (clsPatientData.GetPatientCardByPatientID(ref patientCard))
                {
                    return new clsPatients(patientCard.PatientID, patientCard.FullName, patientCard.Age);
                }
                else
                {
                    return null;
                }                               
            }
        }


        public static clsPatients GetMedicalHistory(int patientID)
        {
            ClinicDataAccessLayer.stMedicalHistory medicalHistory = new stMedicalHistory();

            medicalHistory.M1 = "";
            medicalHistory.M2 = "";
            medicalHistory.M3 = "";
            medicalHistory.M4 = "";
            medicalHistory.M5 = "";
            medicalHistory.M6 = "";
            medicalHistory.M7 = "";
            medicalHistory.M8 = "";
            medicalHistory.M9 = "";
            medicalHistory.M10 = "";
            medicalHistory.M11 = "";
            medicalHistory.M12 = "";
            medicalHistory.OthersMH = "";

            if (clsPatientData.GetMedicalHistory(patientID,ref medicalHistory))
            {
                return new clsPatients(medicalHistory.M1, medicalHistory.M2, medicalHistory.M3, medicalHistory.M4, medicalHistory.M5,
                    medicalHistory.M6, medicalHistory.M7, medicalHistory.M8, medicalHistory.M9, medicalHistory.M10, medicalHistory.M11, medicalHistory.M12, medicalHistory.OthersMH);                
            }
            else
            {
                return null;
            }
        }

        public static clsPatients GetRelatedBox(int patientID)
        {
            ClinicDataAccessLayer.stRelatedBox relatedBox= new stRelatedBox();

            relatedBox.Pregnant = "";
            relatedBox.Breastfeeding = "";
            relatedBox.Smoker = "";
            relatedBox.Count = "";
            relatedBox.Others_R = "";


            if (clsPatientData.GetRelatedBox(patientID, ref relatedBox))
            {
                return new clsPatients(relatedBox.Pregnant, relatedBox.Breastfeeding, relatedBox.Smoker, relatedBox.Count, relatedBox.Others_R);
            }
            else
            {
                return null;
            }
        }

        public static clsPatients GetGeneralInfo(int patientID)
        {
            ClinicDataAccessLayer.stGeneralInfo updateGeneralInfo = new stGeneralInfo();
            
            updateGeneralInfo.patientID = patientID;
            updateGeneralInfo.FirstName = "";
            updateGeneralInfo.LastName = "";
            updateGeneralInfo.BirthDate = "";
            updateGeneralInfo.Gendor = "";
            updateGeneralInfo.Mobile = "";
            updateGeneralInfo.Phone = "";
            updateGeneralInfo.Career = "";
            updateGeneralInfo.Address = "";

            if (clsPatientData.GetGeneralInfo(ref updateGeneralInfo))
            {
                return new clsPatients(updateGeneralInfo.patientID, updateGeneralInfo.FirstName, updateGeneralInfo.LastName, updateGeneralInfo.BirthDate,
                    updateGeneralInfo.Gendor, updateGeneralInfo.Mobile, updateGeneralInfo.Phone, updateGeneralInfo.Career, updateGeneralInfo.Address);
            }
            else
            {
                return null;
            }
        }

        public static bool DeletePatientFromDataBase(int patientID)
        {
            return clsPatientData.DeletePatientFromDataBase(patientID);
        }

        public bool UpdateGeneralInfo(int patientID)
        {
            return clsPatientData.UpdateGeneralInfo(patientID, InitialGeneralInfo());
        }
        public bool UpdateMedicalHistory(int patientID)
        {
            return clsPatientData.UpdateMedicalHistory(patientID, InitialMedicalHistory());
        }
        public bool UpdateRelatedBox(int relatedBoxID)
        {
            return clsPatientData.UpdateRelatedBox(relatedBoxID, InitialRelatedBox());
        }



    }
}
