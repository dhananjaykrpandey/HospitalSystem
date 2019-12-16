using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalSystem
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null) Response.Redirect("~/Logon.aspx");

            Patient curentuser = AppointmentManager.GetPatientByUserName(Session["user"].ToString());

            HospitalSystemEntities1 dbcontext = new HospitalSystemEntities1();

            var medications = (from data in dbcontext.MedicationLists
                              where data.PatientID.ToString().Equals(curentuser.PatientID.ToString())
                              select data).ToList();

            foreach (MedicationList med in medications)
            {
                ListBox1.Items.Add(med.Description.ToString());
            }

            var testresults = (from data in dbcontext.Tests
                              where data.PatientID.ToString().Equals(curentuser.PatientID.ToString())
                              select data).ToList();

            foreach (Test test in testresults)
            {
                ListBox2.Items.Add(test.TestResults.ToString());
            }
        }
    }
}