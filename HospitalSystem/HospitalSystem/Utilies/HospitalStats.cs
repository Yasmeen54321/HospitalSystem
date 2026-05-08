using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalSystem.Utilies
{
    //Static class for statistcs and validation 
    public static class HospitalStats
    {
        public static int TotalPeople { get; private set; }
        //Increase total number of people
        public static void AddPerson()
        { TotalPeople++; }
        //validate age range
        public static bool ValidateAge(int age)
        {
            return age > 0 && age < 120;
        }
    }
}
