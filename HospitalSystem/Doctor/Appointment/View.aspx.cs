using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalSystem.XDoctors.Appointments
{
    public partial class view : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null) Response.Redirect("~/Logon.aspx");

            int patientID = 0;

            List<Appointment> appointments = AppointmentManager.GetPatientAppointments(patientID);

            foreach(Appointment appointment in appointments)
            {
                ListBoxAppointments.Items.Add(appointment.ToString());
            }
        }

        /**
         * Returns true if the currently logged in individual is a doctor
         * 
         * @returns True if current logged in person is a doctor
         */
        protected bool isDoctorLoggedIn()
        {
            return false;
        }

        /**
         * Returns true if the currently logged in individual is a patient
         * 
         * @returns True if current logged in person is a patient
         */
        protected bool isPatientLoggedIn()
        {
            return false;
        }

        /**
         * Returns the name of the current logged in individual
         * 
         * @return name of logged in individual
         */
        protected string getName()
        {
            return "Joe Smith";
        }
    }
}