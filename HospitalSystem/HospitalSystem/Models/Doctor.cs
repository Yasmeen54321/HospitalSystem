using System;
using System.Collections.Generic;
using System.Text;
using HospitalSystem.Interfaces;

namespace HospitalSystem.Models
{
    //Doctor class inherits from Person class
    public class Doctor:Person, ISchedulable
    {
        public string Specialization { get; set; }

        public Doctor(int id, string name, int age, string specialization)
            : base(id, name, age)
        {
            Specialization = specialization;
        }
        //Overridden method from Person class
        public override void ShowInfo()
        {
            Console.WriteLine($"Doctor: {Name}, Specialization: {Specialization}, Age: {Age}");
        }
        //Interface implementation
        public void ScheduleAppointment()
        {
            Console.WriteLine($"Appointment schedualed with Dr. {Name}");
        }
    }
}

