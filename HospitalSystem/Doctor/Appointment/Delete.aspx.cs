using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalSystem.XDoctors.Appointments
{
    public partial class delete : System.Web.UI.Page
    {

        private int getDoctorID()
        {
            return 0;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ListBoxAppointments.Items.Clear();

            List<Appointment> appointments = AppointmentManager.GetPatientAppointments(getDoctorID());

            foreach (Appointment appointment in appointments)
            {
                ListBoxAppointments.Items.Add(appointment.ToString());
            }
        }

        protected void ButtonDeleteAppointment_Click(object sender, EventArgs e)
        {
            List<Appointment> appointments = AppointmentManager.GetPatientAppointments(getDoctorID());

            Appointment selectedAppointment = appointments[ListBoxAppointments.SelectedIndex];

            if(AppointmentManager.DeleteAppointment(selectedAppointment))
            {
                LabelDeleteStatus.Text = "The selected appointment has been cancelled.";
            } else
            {
                LabelDeleteStatus.Text = "We were unable to cancel the selected appointment, please try again later.";
            }
        }
    }
}