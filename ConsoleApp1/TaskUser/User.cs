using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskUser
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        internal enum RegistrationMonth {January = 1, February, March, April, May, June, July, August, September, October, November, December};
        public RegistrationMonth registrationMonth {  get; set; }
        private string _pin;
        public string PIN 
        { 
            get => _pin; 
            set
            {
                if (value.PinCheck())
                {
                    _pin = value;
                }
                else
                {
                    Console.WriteLine("Invalid PIN. The PIN must be 7 characters long and contain only uppercase letters and digits.");
                };
            }
        }
        public User(string name, string surname, RegistrationMonth registrationMonth, string pin)
        {
            Name = name;
            Surname = surname;
            this.registrationMonth = registrationMonth;
            PIN = pin;
        }
        public void GetDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"RegistrationTime(Month): {registrationMonth}");
            Console.WriteLine($"Password: {PIN}");
        }
    }
}
