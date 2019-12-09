using System;

namespace HospitalSystem
{
    public class Appoinment
    {
        private
            int AppointmentID { get; }
            Patient PatientID { get; set; }
            Doctor DoctorID { get; set; }
            string Purpose { get; set; }
            DateTime timestamp { get; set; }
            string VisitSummary { get; set; }
    }

    public class Person
    {
        private
            string First_Name { get; set; }
            string Last_Name { get; set; }
    }
    public class Doctor : Person
    {
        private
            int DoctorID { get; }
            Location LocationID { get; set; }
            string Email { get; set; }
            Department DepartmentID { get; set; }
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
    public class Location {
        private
            int LocationID { get; }
            string Description { get; set; }
    }
    public class Department
    {
        private
            int DepartmentID { get; }
            string Description { get; set; }
    }
}