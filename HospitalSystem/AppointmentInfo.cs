using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalSystem
{
    public class AppointmentInfo
    {
        private string department, purpose;
        private int doctorID, patientID;
        private DateTime timeslot;

        public AppointmentInfo(string department, int patientID,
            int doctorID, DateTime timeslot, string purpose)
        {
            this.department = department;
            this.patientID = patientID;
            this.doctorID = doctorID;
            this.timeslot = timeslot;
            this.purpose = purpose;
        }

        public string Department {
            get {
                return department;
            }
        }

        public string Purpose {
            get {
                return purpose;
            }
        }

        public int PatientID {
            get {
                return patientID;
            }
        }

        public int DoctorID {
            get {
                return doctorID;
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
                patientID,
                doctorID,
                department,
                timeslot
            );
        }
    }
}