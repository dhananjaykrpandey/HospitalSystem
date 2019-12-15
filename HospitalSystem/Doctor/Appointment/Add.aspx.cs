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
            return new List<Patient>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ListBoxPatients.Items.Clear();

            List<Patient> patients = getPatients();

            if(patients.Count < 1)
            {
                ListBoxPatients.Items.Clear();
                ListBoxPatients.Items.Add("There are no patients in our records.");
                return;
            }

            foreach(Patient patient in patients)
            {
                ListBoxPatients.Items.Add(patient.ToString());
            }
        }

        private Tuple<string, string> getDoctorName()
        {
            return new Tuple<string, string>("mr", "doctor");
        }

        private DateTime getRequestedAppointmentTime()
        {
            string hemi = DropDownListTimeHemi.SelectedValue;
            int hour = Convert.ToInt32(DropDownListTimeHour.SelectedValue);
            if (hemi == "PM") hour += 12;
            int minute = Convert.ToInt32(DropDownListTimeMinute.SelectedValue);

            DateTime date = CalendarAppointmentDateSelector.SelectedDate;
            date = date.AddHours(hour);
            date = date.AddMinutes(minute);

            return date;
        }

        protected void ButtonAddAppointment_Click(object sender, EventArgs e)
        {
            List<Patient> patients = getPatients();
            
            Patient patient = patients[ListBoxPatients.GetSelectedIndices()[0]];
            DateTime date = getRequestedAppointmentTime();

            AppointmentInfo appointment = new AppointmentInfo(
                TextBoxDepartment.Text, 
                patient.PatientID, 
                AppointmentManager.GetDoctorID(getDoctorName().Item1, getDoctorName().Item2), 
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