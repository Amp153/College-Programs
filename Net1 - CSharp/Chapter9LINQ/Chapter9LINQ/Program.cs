using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter9LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
        {
           new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
           new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
           new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
           new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
           new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
           new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
           new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
           new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
           new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
           new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
           new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
           new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91} }
        };
            // Create the query.
            // The first line could also be written as "var studentQuery ="
            var studentQuery =
                from student in students
                where student.Scores[0] >= 90 && student.Scores[0] <= 95
                orderby student.First
                select student;

            foreach (var s in studentQuery)
                Console.WriteLine(s.First);

            var studentQuery2 =
                from student in students
                group student by student.Last[0];

            foreach (var studentGroup in studentQuery2)
            {
                Console.WriteLine(studentGroup.Key);
                foreach (Student student in studentGroup)
                {
                    Console.WriteLine("   {0}, {1}",
                              student.Last, student.First);
                }
            }

            //display the students in order by their IDs
            var sq =
                from student in students
                orderby student.ID descending
                select student;

            foreach (var s in sq)
                Console.WriteLine(s.ID + " " + s.First + " " + s.Last);

            //how many students are there
            var sc =
                from student in students
                select student;
            Console.WriteLine(sc.Count());

          /*  string sentence;
            string[] words;

            Console.WriteLine("Enter a sentence with no punctuation");
            sentence = Console.ReadLine();
            words = sentence.Split();

            var results =
                from word in words
                let lWord = word.ToLower()
                orderby lword
                select lword;

            foreach (var r in results.Distinct())
                Console.WriteLine(r);

            Console.ReadKey();*/
        }
    }
      public class Student
        {
            public string First { get; set; }
            public string Last { get; set; }
            public int ID { get; set; }
            public List<int> Scores;
        }

        // Create a data source by using a collection initializer.
        
}
