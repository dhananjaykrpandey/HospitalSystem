using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalSystem
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {        

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            Doctor doc = AppointmentManager.GetDoctorByUserName(Session["user"].ToString());
       
            HospitalSystemEntities1 dbcontext = new HospitalSystemEntities1();

            var patients = (from data in dbcontext.Patients
                             where data.DoctorID.Equals(doc.DoctorID)
                             select data).ToList();

            foreach (Patient patient in patients)
            {
                ListBox1.Items.Add("ID: " + patient.PatientID + " ,First Name:" + patient.FirstName + " ,Last Name:" + patient.LastName + " ,Email:" + patient.Email
                    + " ,Phone: " + patient.Phone + " ,Meds:" + patient.MedicationList.Description + " ,Test Results: " + patient.TestID);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            Doctor doc = AppointmentManager.GetDoctorByUserName(Session["user"].ToString());

            HospitalSystemEntities1 dbcontext = new HospitalSystemEntities1();

            var patients = (from data in dbcontext.Patients
                           where data.DoctorID.Equals(doc.DoctorID)
                           where data.PatientID.ToString().Equals(TextBox1.Text)
                           select data).ToList();

            foreach (Patient patient in patients)
            {
                ListBox1.Items.Add("ID: " + patient.PatientID + " ,First Name:" + patient.FirstName + " ,Last Name:" + patient.LastName + " ,Email:" + patient.Email
                    + " ,Phone: " + patient.Phone + " ,Meds:" + patient.MedicationList.Description + " ,Test Results: " + patient.TestID);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            Doctor doc = AppointmentManager.GetDoctorByUserName(Session["user"].ToString());

            HospitalSystemEntities1 dbcontext = new HospitalSystemEntities1();

            var patients = (from data in dbcontext.Patients
                           where data.DoctorID.Equals(doc.DoctorID) &&
                           data.FirstName.Equals(TextBox2.Text) &&
                           data.LastName.Equals(TextBox3.Text)
                           select data).ToList();

            foreach (Patient patient in patients)
            {
                ListBox1.Items.Add("ID: " + patient.PatientID + " ,First Name:" + patient.FirstName + " ,Last Name:" + patient.LastName + " ,Email:" + patient.Email
                    + " ,Phone: " + patient.Phone + " ,Meds:" + patient.MedicationList.Description + " ,Test Results: " + patient.TestID);
            }
        }
    }
}