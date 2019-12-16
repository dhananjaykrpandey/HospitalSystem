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

            HospitalSystemEntities1 dbcontext = new HospitalSystemEntities1();

            var medications = from data in dbcontext.MedicationLists
                              where data.PatientID.Equals(App)
                              select data;

            foreach (MedicationList med in medications)
            {
                ListBox1.Items.Add(med.ToString());
            }

            var testresults = from data in dbcontext.MedicationLists
                              where data.PatientID.Equals(1)
                              select data;

            foreach (MedicationList test in testresults)
            {
                ListBox2.Items.Add(testresults.ToString());
            }
        }
    }
}