using System;
using System.Collections.Generic;
using System.Linq;
using HospitalSystem.Models;
using HospitalSystem.Services;
using HospitalSystem.Utilies;
namespace HospitalSystem
{
    internal class Program
    {
        static List<Person> people = new List<Person>();//Store all people objects in one list -Polymorphism)
        static void Main(string[] args)
        {
            AppointmentService appointmentService = new AppointmentService();

            // Subscribe to Event
            appointmentService.AppointmentCreated += ShowNotification;

            bool running = true;
            while (running)//Loop to use function of system
            {
                Console.WriteLine("\n===== Hospital Management System =====");
                Console.WriteLine("1. Add Doctor");
                Console.WriteLine("2. Add Patient");
                Console.WriteLine("3. Add Nurse");
                Console.WriteLine("4. Show All People");
                Console.WriteLine("5. Create Appointment");
                Console.WriteLine("6. Show Total People");
                Console.WriteLine("0. Exit");

                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                try
                {
                    switch (choice)
                    {
                        case "1":
                            AddDoctor();
                            break;

                        case "2":
                            AddPatient();
                            break;

                        case "3":
                            AddNurse();
                            break;

                        case "4":
                            ShowAllPeople();
                            break;

                        case "5":
                            CreateAppointment(appointmentService);
                            break;

                        case "6":
                            Console.WriteLine($"Total People: {HospitalStats.TotalPeople}");
                            break;

                        case "0":
                            running = false;
                            break;

                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
        static void AddDoctor()//method to add doctor
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Specialization: ");
            string specialization = Console.ReadLine();

            Doctor doctor = new Doctor(id, name, age, specialization);

            people.Add(doctor);
            HospitalStats.AddPerson();

            Console.WriteLine("Doctor added successfully.");
        }
        static void AddPatient()//method to add Patient
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Disease: ");
            string disease = Console.ReadLine();

            Patient patient = new Patient(id, name, age, disease);

            people.Add(patient);
            HospitalStats.AddPerson();

            Console.WriteLine("Patient added successfully.");
        }
        static void AddNurse()//method to add Nurse
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Shift: ");
            string shift = Console.ReadLine();

            Nurse nurse = new Nurse(id, name, age, shift);

            people.Add(nurse);
            HospitalStats.AddPerson();

            Console.WriteLine("Nurse added successfully.");
        }
        static void ShowAllPeople()//method to show all People
        {
            Console.WriteLine("\n--- People Information ---");

            foreach (Person person in people)
            {
                person.ShowInfo();
            }
        }
        static void CreateAppointment(AppointmentService service)//method to create a pointment between doctor and patient
        {
            Doctor doctor = people.OfType<Doctor>().FirstOrDefault();
            Patient patient = people.OfType<Patient>().FirstOrDefault();

            if (doctor == null || patient == null)
            {
                Console.WriteLine("You need at least one doctor and one patient.");
                return;
            }

            service.CreateAppointment(patient, doctor);
        }

    
    // Event Handler Method
    static void ShowNotification(string message)
        {
            Console.WriteLine(message);
        }
    }
}
