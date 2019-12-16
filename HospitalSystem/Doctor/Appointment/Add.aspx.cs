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

        private List<Patient> getPatients()
        {
            return AppointmentManager.GetPatients();
        }

        private string patientToString(Patient patient)
        {
            return "" + patient.PatientID + " : " + patient.FirstName + " " + patient.LastName;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null) Response.Redirect("~/Logon.aspx");

            DropDownListPatients.Items.Clear();

            List<Patient> patients = getPatients();

            if(patients.Count < 1)
            {
                DropDownListPatients.Items.Clear();
                DropDownListPatients.Items.Add("There are no patients in our records.");
                return;
            }

            foreach(Patient patient in patients)
            {
                DropDownListPatients.Items.Add(
                    patientToString(patient)
                );
            }
        }

        private int getDoctorID()
        {
            return AppointmentManager.GetDoctorByUserName(Session["user"].ToString()).DoctorID;
        }

        private DateTime getRequestedAppointmentTime()
        {
            string hemi = DropDownListTimeHemi.SelectedValue;
            int hour = Convert.ToInt32(DropDownListTimeHour.SelectedValue);
            if (hemi == "PM") hour += 12;
            int minute = Convert.ToInt32(DropDownListTimeMinute.SelectedValue);

            DateTime date = CalendarAppointmentDateSelector.SelectedDate;
            TimeSpan ts = new TimeSpan(hour, minute, 0);
            date = date + ts;

            return date;
        }

        protected void ButtonAddAppointment_Click(object sender, EventArgs e)
        {
            List<Patient> patients = getPatients();

            Patient patient = patients[DropDownListPatients.SelectedIndex];

            DateTime date = getRequestedAppointmentTime();

            AppointmentInfo appointment = new AppointmentInfo(
                TextBoxDepartment.Text, 
                patient.PatientID,
                getDoctorID(),
                date,
                TextBoxPurpose.Text
            );

            if(!AppointmentManager.IsAppointmentAvailable(appointment))
            {
                LabelAddStatus.Text = "That appointment slot is not available, please select a different time/date.";
                return;
            }

            bool scheduleSuccess = AppointmentManager.CreateAppointment(appointment);

            if(scheduleSuccess)
            {
                LabelAddStatus.Text = "Your appointment has been created.";
            } else
            {
                LabelAddStatus.Text = "There was an error while scheduling your appointment, please try again later.";
            }
        }
    }
}