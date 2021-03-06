﻿using System;
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
            return AppointmentManager.GetDoctorByUserName(Session["user"].ToString()).DoctorID;
        }

        private void displayAppointments()
        {
            DropDownListAppointments.Items.Clear();

            List<Appointment> appointments = AppointmentManager.GetDoctorAppointments(getDoctorID());

            if (appointments.Count < 1)
            {
                DropDownListAppointments.Items.Add("You do not currently have any appointments");
                return;
            }

            foreach (Appointment appointment in appointments)
            {
                DropDownListAppointments.Items.Add(appointment.Date + " with " + appointment.Patient.FirstName + " " + appointment.Patient.LastName);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null) Response.Redirect("~/Logon.aspx");

            displayAppointments();
        }

        protected void ButtonDeleteAppointment_Click(object sender, EventArgs e)
        {
            List<Appointment> appointments = AppointmentManager.GetDoctorAppointments(getDoctorID());

            if (appointments.Count < 1) return;

            Appointment selectedAppointment = appointments[DropDownListAppointments.SelectedIndex];

            if(AppointmentManager.DeleteAppointment(selectedAppointment.AppointmentID))
            {
                LabelDeleteStatus.Text = "The selected appointment has been cancelled.";
            } else
            {
                LabelDeleteStatus.Text = "We were unable to cancel the selected appointment, please try again later.";
            }

            displayAppointments();
        }
    }
}