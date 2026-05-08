using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalSystem.Models
{
    //Nurse class inherits fron Person class
    public class Nurse: Person
    {
        public string Shift { get; set; }
        public Nurse(int id, string name, int age, string shift)
            :base(id, name, age)
        {
            Shift = shift;
        }
        //Overridden method
        public override void ShowInfo()
        {
            Console.WriteLine($"Nurse: {Name}, Shift: {Shift}, Age: {Age}");
        }
    }
}
