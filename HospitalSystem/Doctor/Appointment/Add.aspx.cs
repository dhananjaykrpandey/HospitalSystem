using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalSystem.XDoctors.Appointments
{
    public partial class add : System.Web.UI.Page
    {
        private class Doctor {
            public override String ToString()
            {
                return "doctor";
            }
        }
        private List<Doctor> getDoctors()
        {
            return new List<Doctor>();
        }

        private String getAppointeeType()
        {
            return "Doctor";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            LabelDesiredAppointee.Text = getAppointeeType() + ":"; 
        }

        protected void ButtonAddAppointment_Click(object sender, EventArgs e)
        {

        }
    }
}