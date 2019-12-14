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
    }
    public class Doctor : Person
    {
        private
            int DoctorID { get; }
            String LocationID { get; set; }
            string Email { get; set; }
            String DepartmentID { get; set; }
            User UserLoginName { get; set; }
    }
    public class MedicationList
    {
        private
            int MedicationListID { get; }
            string description { get; set; }
            Patient PatientID { get; set; }
    }
    public class Message
    {
        private
            int MessageID { get; }
            User MessageTO { get; set; }
            User MessageFROM { get; set; }
            DateTime date { get; set; }
            string message { get; set; }
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
    }
    public class Test
    {
        private
            int TestID { get; }
            Patient PatientID { get; set; }
            string TestResults { get; set; }
            Doctor DoctorID { get; set; }
    }
    public class User
    {
        private
            int UserID { get; }
            string UserLoginName { get; set; }
            string UserLoginPass { get; set; }
            string UserLoginType { get; set; }
    }
}