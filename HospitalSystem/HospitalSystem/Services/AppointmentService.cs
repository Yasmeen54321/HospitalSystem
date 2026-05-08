using System;
using System.Collections.Generic;
using System.Text;
using HospitalSystem.Models;
using HospitalSystem.Events;

namespace HospitalSystem.Services
{
    //Service responsible for managing appointments
    public class AppointmentService
    {
        // Event triggered when appointment is created
        public event NotificationHandler? AppointmentCreated;

        public void CreateAppointment(Patient patient, Doctor doctor)
        {
            Console.WriteLine(
                $"Appointment created for patient {patient.Name} with Dr. {doctor.Name}"
            );

            // Trigger Event notification
            AppointmentCreated?.Invoke(
                $"Notification: Appointment booked successfully for {patient.Name}"
            );
        }
    }
}
