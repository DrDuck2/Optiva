using System;
using System.Collections.Generic;
using System.Text;

namespace LV6_Zad3
{
    public class Car : IEquatable<Car>
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Km { get; private set; }
        public int Year { get; private set; }

        public Car(string brand, string type, int km, int year)
        {
            this.Make = brand;
            this.Model = type;
            this.Km = km;
            this.Year = year;
        }

        public override string ToString() => $"{Make} - {Model} - {Km} - {Year}";

        public override int GetHashCode() => HashCode.Combine(Make, Model, Km, Year);

        public override bool Equals(object obj)
        {
            if (obj is Car == false) return false;
            return this.Equals((Car)obj);
        }

        public bool Equals(Car other)
        {
            return this.Make == other.Make && this.Model == other.Model && this.Km == other.Km && this.Year == other.Year;
        }
    }   
}
