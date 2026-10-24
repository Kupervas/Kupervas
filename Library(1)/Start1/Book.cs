using System;
using System.Collections.Generic;
using System.Text;

namespace Start1
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; set; }
        public int Id { get;  set;}
        public Book(string title, string author, int year, bool isAvailable)
        {
            Title = title;
            Author = author;
            Year = year;
            IsAvailable = isAvailable;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($" ID:{Id} | Title: {Title}, Author: {Author}, Year: {Year}, Available: {IsAvailable},");
        }
    }
}
