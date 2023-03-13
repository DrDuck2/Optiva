using System;
using System.Collections.Generic;
using System.Text;

namespace LV7Rpuuuun
{
    public class Book : IItem
    {
        public double Price { get; private set; }
        public string Title { get; private set; }

        public Book(double price,string title)
        {
            this.Price = price;
            this.Title = title;
        }
        public override string ToString()
        {
            return "Book: " + this.Title +
            Environment.NewLine + " -> Price: " + this.Price;
        }
        public double Accept(IVisitor visitor) { return visitor.Visit(this); }
    }
}
