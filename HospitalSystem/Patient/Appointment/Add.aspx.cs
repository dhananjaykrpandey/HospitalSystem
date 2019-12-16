using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalSystem.XPatients.Appointments
{
    public partial class add : System.Web.UI.Page
    {

        private List<Doctor> getDoctors()
        {
            return AppointmentManager.GetDoctors();
        }

        private string doctorToString(Doctor doctor)
        {
            return "" + doctor.DoctorID + " : " + doctor.FirstName + " " + doctor.LastName;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            LabelPatientSelected.Text = "" + DropDownListPatients.SelectedIndex;

            DropDownListPatients.Items.Clear();

            List<Doctor> doctors = getDoctors();

            if(doctors.Count < 1)
            {
                DropDownListPatients.Items.Clear();
                DropDownListPatients.Items.Add("There are no doctors in our records.");
                return;
            }

            foreach(Doctor doctor in doctors)
            {
                DropDownListPatients.Items.Add(
                    doctorToString(doctor)
                );
            }
        }

        private Tuple<string, string> getPatientName()
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
            TimeSpan ts = new TimeSpan(hour, minute, 0);
            date = date + ts;

            return date;
        }

        protected void ButtonAddAppointment_Click(object sender, EventArgs e)
        {
            List<Doctor> doctors = getDoctors();

            Doctor doctor = doctors[DropDownListPatients.SelectedIndex];

            DateTime date = getRequestedAppointmentTime();

            AppointmentInfo appointment = new AppointmentInfo(
                TextBoxDepartment.Text, 
                AppointmentManager.GetPatientID(getPatientName().Item1, getPatientName().Item2),
                doctor.DoctorID,
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