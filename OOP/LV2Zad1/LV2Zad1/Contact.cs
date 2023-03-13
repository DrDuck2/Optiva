using System;
using System.Collections.Generic;
using System.Text;

namespace LV2Zad1
{
    class Contact
    {
        private string name;
        private string surname;
        private int phoneNumber;
        private string email;


        public Contact()
        {
            this.name = "Dominik";
            this.surname = "Vidovic";
            this.phoneNumber = 031290053;
            this.email = "dvidovic1@ferit.hr";
        }
        public Contact(string name, string surname, int phoneNumber, string email)
        {
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Surname
        {
            get { return this.surname; }
            set { this.surname = value; }
        }

        public int PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string GetDisplay()
        {
            return $"Name = {name}, Surname= {surname}, Phone number = {phoneNumber}, Email address = {email}";
        }
    }
}
