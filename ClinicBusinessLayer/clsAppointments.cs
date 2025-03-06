using ClinicDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusinessLayer
{
    public class clsAppointments
    {
        public string PatientName { get; set; }
        public string TreatmentName { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }

        public clsAppointments()
        {
            this.PatientName = "";
            this.TreatmentName = "";
            this.Date = DateTime.Now;
            this.Time = DateTime.Now.TimeOfDay;
        }

        public clsAppointments(string patientName, string treatmentName, DateTime date, TimeSpan time)
        {
            this.PatientName = patientName;
            this.TreatmentName = treatmentName;
            this.Date = date;
            this.Time = time;
        }

        private ClinicDataAccessLayer.stAppointment IntitialAppointment()
        {
            ClinicDataAccessLayer.stAppointment newAppointment = new ClinicDataAccessLayer.stAppointment();

            newAppointment.PatientName = this.PatientName;
            newAppointment.TreatmentName = this.TreatmentName;
            newAppointment.Date = this.Date;
            newAppointment.Time = this.Time;

            return newAppointment;
        }

        public bool AddNewAppointment()
        {
            return clsAppointmentsData.AddNewAppointment(IntitialAppointment());
        }

        public static DataTable GetAllApointmentsList()
        {
            return clsAppointmentsData.GetAllApointmentsList();
        }

        public bool UpdateAppointment(int appointmentID)
        {
            return clsAppointmentsData.UpdateAppointment(appointmentID, IntitialAppointment());
        }

        public static bool DeleteAppointment(int appointmentID)
        {
            return clsAppointmentsData.DeleteAppointment(appointmentID);
        }

        public static clsAppointments GetAppointmentData(int appointmentID)
        {
            ClinicDataAccessLayer.stAppointment updateAppointmentData = new stAppointment();

            updateAppointmentData.PatientName = "";
            updateAppointmentData.TreatmentName = "";
            updateAppointmentData.Date = DateTime.Now;
            updateAppointmentData.Time = DateTime.Now.TimeOfDay;

            if (clsAppointmentsData.GetAppointmentDataByID(appointmentID, ref updateAppointmentData))
            {
                return new clsAppointments(updateAppointmentData.PatientName, updateAppointmentData.TreatmentName, updateAppointmentData.Date,
                    updateAppointmentData.Time);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAppointmentDataByName(string data)
        {
            return clsAppointmentsData.GetAppointmentDataByName(data);
        }



    }
}
