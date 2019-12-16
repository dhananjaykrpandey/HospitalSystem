using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalSystem
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        private Doctor getLoggedInDoctor()
        {
            return AppointmentManager.GetDoctorByUserName(Session["user"].ToString());
        }

        private List<Patient> getPatients()
        {
            return AppointmentManager.GetPatients();
        }
        
        private List<Message> getMessages()
        {
            HospitalSystemEntities1 entities = new HospitalSystemEntities1();

            Doctor doctor = getLoggedInDoctor();

            return (
                from message in entities.Messages
                where
                    message.MessageTO == doctor.FirstName + " " + doctor.LastName
                select message).ToList();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null) Response.Redirect("~/Logon.aspx");

            List<Patient> patients = getPatients();
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
            if(patients.Count < 1)
            {
                DropDownListPatient.Items.Add("This hospital has no patients on record.");
            } else
            {
                foreach (Patient patient in patients)
                {
                    DropDownListPatient.Items.Add(
                        patient.FirstName + " " + patient.LastName
                    );
                }
            }
        }

        private bool sendMessage(Doctor doctor, Patient patient, string content)
        {
            HospitalSystemEntities1 entities = new HospitalSystemEntities1();

            Message msg = new Message();
            msg.MessageFROM = doctor.FirstName + " " + doctor.LastName;
            msg.MessageTO = patient.FirstName + " " + patient.LastName;
            msg.Message1 = content;
            msg.Date = new DateTime();

            entities.Messages.Add(msg);
            entities.SaveChanges();

            return true;
        }

        protected void ButtonSendMessage_Click(object sender, EventArgs e)
        {
            string content = TextBoxMessageContent.Text;
            List<Patient> patients = getPatients();

            Patient selectedPatient = patients[DropDownListPatient.SelectedIndex];
            Doctor doctor = getLoggedInDoctor();

            if(sendMessage(doctor, selectedPatient, content))
            {
                LabelSentStatus.Text = "Message successfully sent.";
            } else
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