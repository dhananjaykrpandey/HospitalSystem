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
            return 1;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownListAppointments.Items.Clear();

            List<Appointment> appointments = AppointmentManager.GetDoctorAppointments(getDoctorID());

            foreach (Appointment appointment in appointments)
            {
                DropDownListAppointments.Items.Add(appointment.Date + " with " + appointment.Patient.FirstName + " " + appointment.Patient.LastName);
            }
        }

        protected void ButtonDeleteAppointment_Click(object sender, EventArgs e)
        {
            List<Appointment> appointments = AppointmentManager.GetDoctorAppointments(getDoctorID());

            Appointment selectedAppointment = appointments[DropDownListAppointments.SelectedIndex];

            if(AppointmentManager.DeleteAppointment(selectedAppointment.AppointmentID))
            {
                LabelDeleteStatus.Text = "The selected appointment has been cancelled.";
            } else
            {
                LabelDeleteStatus.Text = "We were unable to cancel the selected appointment, please try again later.";
            }
        }
    }
}