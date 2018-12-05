using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace StudentsInfo
{
    public class Student : IComparable<Student>
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("test")]
        public string Test { get; set; }

        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        [JsonProperty("mark")]
        public int Mark { get; set; }

 


        public Student(string name, string test, DateTime date, int mark)
        {
            Name = name;
            Test = test;
            Date = date;
            Mark = mark;
        }


        public Student(string name) : this(name, null, DateTime.Today, 0) { }

        public Student() : this(null, null, DateTime.Today, 0) { }



        public int CompareTo(Student other)
        {
            if (other == null)
            {
                return 1;
            }

            return Mark.CompareTo(other.Mark);
        }

        public string[] ToArrayString()
        {
            string[] str = { Name, Test, Date.Value.ToString("yyyy.MM.dd"), Mark.ToString() };
            return str; 
        }
    }
}
