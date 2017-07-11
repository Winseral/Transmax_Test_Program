using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Transmax_Programming_Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Only the 4 Students this would need additional code is you want to add more studetns
            Student[] student = new Student[4];

            //To install data into the existing StudentInput.text file
            /*Student Bundy = new Student("BUNDY", "TERESSA", 88);
            Student Smith = new Student("SMITH", "ALLAN", 70);
            Student King = new Student("KING", "MADISON",88);
            Student Smith1 = new Student("SMITH", "FRANCIS", 85);
            student.Add(Bundy);
            student.Add(Smith);
            student.Add(King);
            student.Add(Smith1);*/

            LoadFile(student);

            Console.WriteLine("Original Data");
            Console.WriteLine();
            foreach (Student s in student)
            {
                Console.WriteLine("{0},{1},{2}",s.LastName, s.FirstName, s.Score);
            }

            //sort Student List by score
            List<Student> sortedStudentsscore = student.OrderByDescending(o => o.Score).ToList();

            Console.WriteLine();
            Console.WriteLine("Sorted Data");
            Console.WriteLine();

            foreach (Student s in sortedStudentsscore)
            {
                Console.WriteLine("{0},{1},{2}", s.LastName, s.FirstName, s.Score);
            }

            //Ran once to save file
            //SaveFile1(student);

            SaveFile(sortedStudentsscore);

            Console.ReadLine();
        }

        //helper methods(two different methods of reading or writing string data from text file)
        public static void LoadFile(Student[] student)
        {
            try
            {
                int count = 0;
                List<string> lines = File.ReadAllLines(@"../StudentInputs.txt").ToList();

                foreach (var line in lines)
                {
                    string[] entries = line.Split(',');

                    student[count] = new Student(entries[0], entries[1], uint.Parse(entries[2]));

                    //Console.WriteLine(student[count]);
                    count += 1;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Loading Text file Error - {0}", e.Message);
            }
        }

        public static void SaveFile(List<Student> sortedStudentsscore)
        {
            try
            {
                FileStream fs = new FileStream(@"../student-graded.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                foreach (Student s in sortedStudentsscore)
                {
                    sw.WriteLine("{0},{1},{2}", s.LastName, s.FirstName, s.Score);
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Saving Text file Error - {0}", e.Message);

            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Data Saved - student-graded.txt");
            }

        }

        //run once to save the data to StudentInputs.txt file
        /*public static void SaveFile1(Student[] student)
        {
            try
            {
                FileStream fs = new FileStream(@"../StudentInputs.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                foreach (Student s in student)
                {
                    sw.WriteLine("{0},{1},{2}", s.LastName, s.FirstName, s.Score);
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Saving Text file Error - {0}", e.Message);

            }

        }*/

    }

   
}
