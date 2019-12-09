using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalSystem.appointments
{
    public partial class delete : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            int patientID = 0;

            List<Appointment> appointments = AppointmentManager.GetPatientAppointments(patientID);

            foreach (Appointment appointment in appointments)
            {
                ListBoxAppointments.Items.Add(appointment.ToString());
            }
        }

        protected void ButtonDeleteAppointment_Click(object sender, EventArgs e)
        {

        }
    }
}