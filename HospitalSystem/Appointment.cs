using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

        public string Department {
            get {
                return department;
            }
        }

        public string Patient {
            get {
                return patient;
            }
        }

        public string Doctor {
            get {
                return doctor;
            }
        }

        public DateTime TimeSlot {
            get {
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
}