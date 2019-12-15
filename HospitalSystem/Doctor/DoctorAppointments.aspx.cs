using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalSystem
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private int getDoctorID()
        {
            return 0;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ListBoxAppointments.Items.Clear();

            int doctorID = getDoctorID();

            List<Appointment> appointments = AppointmentManager.GetDoctorAppointments(doctorID);

            if(appointments.Count < 1)
            {
                ListBoxAppointments.Items.Add("You do not currently have any scheduled appointments.");
                return;
            }

            foreach (Appointment appointment in appointments)
            {
                ListBoxAppointments.Items.Add(appointment.ToString());
            }
        }
    }
}