using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalSystem.appointments
{
    public partial class view : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int patientID = 0;

            List<Appointment> appointments = AppointmentManager.GetPatientAppointments(patientID);

            foreach(Appointment appointment in appointments)
            {
                ListBox1.Items.Add(appointment.ToString());
            }
        }

        /**
         * Returns true if the currently logged in individual is a doctor
         * 
         * @returns True if current logged in person is a doctor
         */
        private bool isDoctorLoggedIn()
        {
            return false;
        }

        /**
         * Returns true if the currently logged in individual is a patient
         * 
         * @returns True if current logged in person is a patient
         */
        private bool isPatientLoggedIn()
        {
            return false;
        }

        /**
         * Returns the name of the current logged in individual
         * 
         * @return name of logged in individual
         */
        private string getName()
        {
            return "Joe Smith";
        }
    }
}