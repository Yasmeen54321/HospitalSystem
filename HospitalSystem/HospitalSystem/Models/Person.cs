using System;
using System.Collections.Generic;
using System.Text;
using HospitalSystem.Utilies;

namespace HospitalSystem.Models
{
    //Abstract base class for person in hospital
    public abstract class Person
    {
        //Private Fields for encapsulation 
        private string _name;
        private int _age;

        //Read only property
        public int Id { get; }

        //Property with Validation 
        public string Name { get { return _name; }
            set {
                if (string.IsNullOrWhiteSpace(value)){
                    throw new ArgumentException("Name connent be empty.");
                }
                _name = value; 
            }
        }
        //Property with Validation 
        public int Age {
             get {return _age; }
            set { if (!HospitalStats.ValidateAge(value))
                { throw new ArgumentException("Invalid age."); }
            _age = value; }
        }
        //Constructor
        protected Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        //Abstract method for polymorphism
        public abstract void ShowInfo();
    }
}
