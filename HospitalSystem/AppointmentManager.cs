using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
            return new Appointment(
                "department", 
                "patient name", 
                "doctor name", 
                new DateTime(), 
                "purpose"
            );
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
        public static bool IsAppointmentAvailable(Appointment appointment)
        {
            return false;
        }

        /**
         * Creates an appointment in the database with the information 
         * given in the provided Appointment object
         * 
         * @param appointment Appointment object representing appointment
         *  information
         * @returns true on success, false on failure
         */
        public static bool CreateAppointment(Appointment appointment)
        {
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
        public static bool DeleteAppointment(Appointment appointment)
        {
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
            return new List<Appointment>();
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
            return new List<Appointment>();
        }
    }
}