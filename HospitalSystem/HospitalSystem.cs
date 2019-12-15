using System;

namespace HospitalSystem
{
    public class Appointment
    {
        private string department, patient, doctor, purpose;
        private DateTime timeslot;

        public Appointment(string department, string patient,
            string doctor, DateTime timeslot, string purpose)
        {
            this.department = department;
            this.patient = patient;
            this.doctor = doctor;
            this.timeslot = timeslot;
            this.purpose = purpose;
        }

        public string Department
        {
            get
            {
                return department;
            }
        }

        public string Patient
        {
            get
            {
                return patient;
            }
        }

        public string Doctor
        {
            get
            {
                return doctor;
            }
        }

        public DateTime TimeSlot
        {
            get
            {
                return timeslot;
            }
        }

        public override string ToString()
        {
            return String.Format(
                "For {0}, with {1} in department {2}, at {3}",
                patient,
                doctor,
                department,
                timeslot
            );
        }
    }

    public abstract class Person
    {
        private
            string First_Name { get; set; }
            string Last_Name { get; set; }

        public Person(string firstname, string lastname)
        {
            First_Name = firstname;
            Last_Name = lastname;
        }
    }
    public class Doctor : Person
    {
        private
            int DoctorID { get; }
            String Location { get; set; }
            string Email { get; set; }
            String Department { get; set; }
            User UserLoginName { get; set; }

        public Doctor(string firstname, string lastname, string location, string email, string department, User userloginname) : base(firstname, lastname)
        {
            Location = location;
            Email = email;
            Department = department;
            UserLoginName = userloginname;
        }
    }
    public class MedicationList
    {
        private
            int MedicationListID { get; }
            string Description { get; set; }
            Patient PatientID { get; set; }

        public MedicationList(string description, Patient patient)
        {
            Description = description;
            PatientID = patient;
        }
    }
    public class Message
    {
        private
            int MessageID { get; }
            Person MessageTO { get; set; }
            Person MessageFROM { get; set; }
            DateTime Date { get; set; }
            string message { get; set; }

        public Message(Person messageto, Person messagefrom, DateTime date, string message)
        {
            MessageTO = messageto;
            MessageFROM = messagefrom;
            Date = date;
            this.message = message;

        }
    }
    public class Patient : Person
    {
        private
            int PatientID { get; }
            Doctor DoctorID { get; set; }
            string Address { get; set; }
            string Phone { get; set; }
            string Email { get; set; }
            User UserLoginName { get; set; }
            MedicationList MedicationListID { get; set; }
            Test TestID { get; set; }

        public Patient(string firstname, string lastname, Doctor doctor, string address, string phone, string email, User userloginname, MedicationList medicationlist, Test test) : base(firstname, lastname)
        {
            DoctorID = doctor;
            Address = address;
            Phone = phone;
            Email = email;
            UserLoginName = userloginname;
            MedicationListID = medicationlist;
            TestID = test;
        }
    }
    public class Test
    {
        private
            int TestID { get; }
            Patient PatientID { get; set; }
            string TestResults { get; set; }
            Doctor DoctorID { get; set; }

        public Test(Patient patient, string results, Doctor doctor)
        {
            PatientID = patient;
            TestResults = results;
            DoctorID = doctor;
        }
    }
    public class User
    {
        private
            int UserID { get; }
            string UserLoginName { get; set; }
            string UserLoginPass { get; set; }
            string UserLoginType { get; set; }

        public User(string userloginname, string userloginpass, string userlogintype)
        {
            UserLoginName = userloginname;
            UserLoginPass = userloginpass;
            UserLoginType = userlogintype;
        }
    }
}