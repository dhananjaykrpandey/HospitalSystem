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
            HospitalSystemEntities1 dbcontext = new HospitalSystemEntities1();

            var patients = from data in dbcontext.Patients
                             where data.DoctorID.Equals("$$$")
                             select data;

            foreach (Patient patient in patients)
            {
                ListBox1.Items.Add(patient.ToString());
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HospitalSystemEntities1 dbcontext = new HospitalSystemEntities1();

            var patients = from data in dbcontext.Patients
                           where data.DoctorID.Equals("$$$")
                           where data.PatientID.Equals(TextBox1)
                           select data;

            foreach (Patient patient in patients)
            {
                ListBox1.Items.Add(patient.ToString());
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HospitalSystemEntities1 dbcontext = new HospitalSystemEntities1();

            var patients = from data in dbcontext.Patients
                           where data.DoctorID.Equals("$$$") &&
                           data.FirstName.Equals(TextBox2.Text) &&
                           data.LastName.Equals(TextBox3.Text)
                           select data;

            foreach (Patient patient in patients)
            {
                ListBox1.Items.Add(patient.ToString());
            }
        }
    }
}