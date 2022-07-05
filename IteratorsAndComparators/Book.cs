using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    class Book
    {
        public string Title { get; set; }
        public int Age { get; set; }
        public List<string> Authors { get; set; }

        public Book(string title, int age, params string[] authors)
        {
            this.Title = title;
            this.Age = age;
            this.Authors = authors.ToList();
        }
    }
}
