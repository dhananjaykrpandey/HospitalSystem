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

            HospitalSystemEntities entities = new HospitalSystemEntities();

            HospitalSystem.Appointment appointment = (from appt in entities.Appointments where appt.AppointmentID == appointmentID select appt).First();

            return appointment;
        }

        public static Appointment GetAppointmentID(AppointmentInfo appointment)
        {
            HospitalSystemEntities entities = new HospitalSystemEntities();

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
            HospitalSystemEntities entities = new HospitalSystemEntities();

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
            HospitalSystemEntities entities = new HospitalSystemEntities();

            Appointment appt = new Appointment(
                appointment.PatientID,
                appointment.DoctorID, 
                appointment.Purpose, 
                appointment.TimeSlot,
                appointment.TimeSlot, 
                ""
            );

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
            HospitalSystemEntities entities = new HospitalSystemEntities();

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
            HospitalSystemEntities entities = new HospitalSystemEntities();

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
        public static List<HospitalSystem.Appointment> GetDoctorAppointments(int doctorID)
        {
            HospitalSystemEntities entities = new HospitalSystemEntities();

            return (
                from appt in entities.Appointments
                where
                    appt.DoctorID == doctorID
                select appt
            ).ToList<HospitalSystem.Appointment>();
        }

        public static int GetPatientID(string firstName, string lastName)
        {
            HospitalSystemEntities entities = new HospitalSystemEntities();

            List<Patient> patients = (
                from patient in entities.Patients
                where
                    patient.First_Name == firstName &&
                    patient.Last_Name == lastName
                select patient
            ).ToList();

            if (patients.Count < 1) return 0;

            return patients.First().PatientID;
        }

        public static int GetDoctorID(string firstName, string lastName)
        {
            HospitalSystemEntities entities = new HospitalSystemEntities();

            List<Doctor> doctors = (
                from doctor in entities.Doctors
                where
                    doctor.First_Name == firstName &&
                    doctor.Last_Name == lastName
                select doctor
            ).ToList();

            if (doctors.Count < 1) return 0;

            return doctors.First().DoctorID;
        }
    }
}