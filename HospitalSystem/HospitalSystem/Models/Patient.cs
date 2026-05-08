using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalSystem.Models
{
    //Patient class inherits fron Person class
    public class Patient:Person
    {
        public string Disease { get; set; }
        public Patient (int id, string name, int age, string disease)
            :base(id, name,age)
        {
            Disease = disease;
        }
        //Overridden method
        public override void ShowInfo()
        {
            Console.WriteLine($"Patient: {Name}, Disease: {Disease}, Age: {Age}");
        }
    }
}
