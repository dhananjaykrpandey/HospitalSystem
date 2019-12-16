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
            LabelPatientSelected.Text = "" + DropDownListPatients.SelectedIndex;

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

        private Tuple<string, string> getDoctorName()
        {
            //string fullname = Session["UserLoginName"].ToString();
            string fullname = "Maya Moore";

            string first = fullname.Split(' ')[0];
            string last = fullname.Split(' ')[1];

            return new Tuple<string, string>(first, last);
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

            Patient patient = patients[DropDownListPatients.SelectedIndex];

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