using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalSystem
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private Patient getLoggedInPatient()
        {
            return AppointmentManager.GetPatientByUserName(Session["user"].ToString());
        }

        private List<Doctor> getDoctors()
        {
            return AppointmentManager.GetDoctors();
        }

        private List<Message> getMessages()
        {
            HospitalSystemEntities1 entities = new HospitalSystemEntities1();

            Patient patient = getLoggedInPatient();

            return (
                from message in entities.Messages
                where
                    message.MessageTO == patient.FirstName + " " + patient.LastName
                select message).ToList();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null) Response.Redirect("~/Logon.aspx");

            List<Doctor> doctors = getDoctors();
            List<Message> messages = getMessages();

            ListBoxMessages.Items.Clear();
            DropDownListMessages.Items.Clear();
            if (messages.Count < 1)
            {
                ListBoxMessages.Items.Add("You have no messages.");
                DropDownListMessages.Items.Add("You have no messages.");
            }
            else
            {
                foreach (Message message in messages)
                {
                    ListBoxMessages.Items.Add(
                        message.MessageFROM + ": " + message.Message1
                    );
                    DropDownListMessages.Items.Add(
                        message.MessageFROM + ": " + message.Message1
                    );
                }
            }

            ListBoxMessages.DataBind();
            DropDownListMessages.DataBind();

            DropDownListPatient.Items.Clear();
            if (doctors.Count < 1)
            {
                DropDownListPatient.Items.Add("This hospital has no patients on record.");
            }
            else
            {
                foreach (Doctor doctor in doctors)
                {
                    DropDownListPatient.Items.Add(
                        doctor.FirstName + " " + doctor.LastName
                    );
                }
            }
        }

        private bool sendMessage(Doctor doctor, Patient patient, string content)
        {
            HospitalSystemEntities1 entities = new HospitalSystemEntities1();

            Message msg = new Message();
            msg.MessageFROM = patient.FirstName + " " + patient.LastName;
            msg.MessageTO = doctor.FirstName + " " + doctor.LastName;
            msg.Message1 = content;
            msg.Date = new DateTime();

            entities.Messages.Add(msg);
            entities.SaveChanges();

            return true;
        }

        protected void ButtonSendMessage_Click(object sender, EventArgs e)
        {
            string content = TextBoxMessageContent.Text;
            List<Doctor> doctors = getDoctors();

            Doctor selectedDoctor = doctors[DropDownListPatient.SelectedIndex];
            Patient patient = getLoggedInPatient();

            if (sendMessage(selectedDoctor, patient, content))
            {
                LabelSentStatus.Text = "Message successfully sent.";
            }
            else
            {
                LabelSentStatus.Text = "There was an error sending your message, please try again later.";
            }
        }

        protected void ButtonDeleteMessage_Click(object sender, EventArgs e)
        {
            HospitalSystemEntities1 entities = new HospitalSystemEntities1();
            List<Message> messages = getMessages();

            Message selected = messages[DropDownListMessages.SelectedIndex];

            entities.Messages.Attach(selected);
            entities.Messages.Remove(selected);
            entities.SaveChanges();

            ListBoxMessages.Items.Clear();
            DropDownListMessages.Items.Clear();
            if (messages.Count < 1)
            {
                ListBoxMessages.Items.Add("You have no messages.");
                DropDownListMessages.Items.Add("You have no messages.");
            }
            else
            {
                foreach (Message message in messages)
                {
                    ListBoxMessages.Items.Add(
                        message.MessageFROM + ": " + message.Message1
                    );
                    DropDownListMessages.Items.Add(
                        message.MessageFROM + ": " + message.Message1
                    );
                }
            }

            ListBoxMessages.DataBind();
            DropDownListMessages.DataBind();
        }

        protected void DropDownListPatient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}