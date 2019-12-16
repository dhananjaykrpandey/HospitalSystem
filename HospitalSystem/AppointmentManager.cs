using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HospitalSystem
{
    public class AppointmentManager
    {

        /**
         * Get an appointment by its associated appointment ID
         * 
         * @param appointmentID the id of the appointment to retrieve
         * @returns the associated appointment, otherwise null
         */
        public static Appointment GetAppointmentByID(int appointmentID)
        {

            HospitalSystemEntities1 entities = new HospitalSystemEntities1();

            HospitalSystem.Appointment appointment = (from appt in entities.Appointments where appt.AppointmentID == appointmentID select appt).First();

            return appointment;
        }

        public static Appointment GetAppointmentID(AppointmentInfo appointment)
        {
            HospitalSystemEntities1 entities = new HospitalSystemEntities1();

            List<HospitalSystem.Appointment> matches = (
                from appt in entities.Appointments
                where
                    appt.DoctorID == appointment.DoctorID && 
                    appt.PatientID == appointment.PatientID &&
                    appt.Time == appointment.TimeSlot
                select appt).ToList();

            return matches.First();
        }

        /**
         * Checks if a given appointment is available, based on 
         * doctor chosen and timeslot
         * 
         * @param appointment Appointment object representing desired
         *  appointment information
         * @returns true if there is a slot open at that time with that
         *  doctor, otherwise false
         */
        public static bool IsAppointmentAvailable(AppointmentInfo appointment)
        {
            HospitalSystemEntities1 entities = new HospitalSystemEntities1();

            List<HospitalSystem.Appointment> appointments =
                (from appt in entities.Appointments
                where (appt.DoctorID == appointment.DoctorID) && (appt.Time != appointment.TimeSlot)
                select appt).ToList();

            return appointments.Count == 0;
        }

        /**
         * Creates an appointment in the database with the information 
         * given in the provided Appointment object
         * 
         * @param appointment Appointment object representing appointment
         *  information
         * @returns true on success, false on failure
         */
        public static bool CreateAppointment(AppointmentInfo appointment)
        {
            HospitalSystemEntities1 entities = new HospitalSystemEntities1();
            
            Appointment appt = new Appointment();
            appt.Date = appointment.TimeSlot;
            appt.Time = appointment.TimeSlot;
            appt.PatientID = appointment.PatientID;
            appt.DoctorID = appointment.DoctorID;
            appt.Purpose = appointment.Purpose;
            appt.VisitSummary = "";

            entities.Appointments.Add(appt);

            entities.SaveChanges();

            return true;
        }

        /**
         * Deletes the appointment corresponding with the given Appointment
         * object, if one exists
         * 
         * @param appointment Appointment object representing the information
         *  of the appointment that is desired to be deleted
         * @returns true on success, false on failure
         */
        public static bool DeleteAppointment(int appointmentID)
        {
            HospitalSystemEntities1 entities = new HospitalSystemEntities1();

            List<Appointment> matched = (from appt in entities.Appointments where appt.AppointmentID == appointmentID select appt).ToList();

            if (matched.Count < 1) return false;

            entities.Appointments.Remove(matched.First());
            entities.SaveChanges();

            return true;
        }

        /**
         * Get all the appointments for the given patient 
         * 
         * @param patientID id of the patient to retrieve the appointments
         *  of
         * @returns List of Appointment objects representing the scheduled 
         *  appointments of the given patient
         */
        public static List<Appointment> GetPatientAppointments(int patientID)
        {
            HospitalSystemEntities1 entities = new HospitalSystemEntities1();

            return (
                from appt in entities.Appointments
                where
                    appt.PatientID == patientID
                select appt
            ).ToList();
        }

        /**
         * Get all the appointments for the given doctor 
         * 
         * @param doctorID id of the doctor to retrieve the appointments
         *  of
         * @returns List of Appointment objects representing the scheduled 
         *  appointments of the given doctor
         */
        public static List<Appointment> GetDoctorAppointments(int doctorID)
        {
            HospitalSystemEntities1 entities = new HospitalSystemEntities1();

            return (
                from appt in entities.Appointments
                where
                    appt.DoctorID == doctorID
                select appt
            ).ToList<Appointment>();
        }

        public static int GetPatientID(string firstName, string lastName)
        {
            HospitalSystemEntities1 entities = new HospitalSystemEntities1();

            List<Patient> patients = (
                from patient in entities.Patients
                where
                    patient.FirstName == firstName &&
                    patient.LastName == lastName
                select patient
            ).ToList();

            if (patients.Count < 1) return 0;

            return patients.First().PatientID;
        }

        public static int GetDoctorID(string firstName, string lastName)
        {
            HospitalSystemEntities1 entities = new HospitalSystemEntities1();

            List<Doctor> doctors = (
                from doctor in entities.Doctors
                where
                    doctor.FirstName == firstName &&
                    doctor.LastName == lastName
                select doctor
            ).ToList();

            if (doctors.Count < 1) return 0;

            return doctors.First().DoctorID;
        }

        public static List<Patient> GetPatients()
        {
            HospitalSystemEntities1 entities = new HospitalSystemEntities1();

            return entities.Patients.ToList();
        }

        public static List<Doctor> GetDoctors()
        {
            HospitalSystemEntities1 entities = new HospitalSystemEntities1();

            return entities.Doctors.ToList();
        }
    }
}