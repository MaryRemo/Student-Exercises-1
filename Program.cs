using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    class CohortRoster {
    public string CohortNumber {get; set;}
    public int StudentCount {get; set;}
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCISES
            
            Exercise ClassesExercise = new Exercise("ClassesExercise", "C#");

            Exercise ListsExercises = new Exercise("ListsExercises","C#");

            Exercise Dictionaries = new Exercise("Dictionaries", "C#");

            Exercise Sets = new Exercise("Sets", "C#");

             List<Exercise> exercises = new List<Exercise>() {
                ClassesExercise,
                ListsExercises,
                Dictionaries,
                Sets
            };

            // COHORT   
            Cohort Cohort1 = new Cohort();

            Cohort Cohort2 = new Cohort();

            Cohort Cohort3 = new Cohort();

            Cohort Cohort4 = new Cohort();

            List<Cohort> cohorts = new List<Cohort>() {
                Cohort1,
                Cohort2,
                Cohort3,
                Cohort4
            };


            // STUDENT
            Student Mary = new Student("Mary", "Remo", "maryremo", "Cohort1");

            Student Asia = new Student("Asia", "Carter", "asiacarter", "Cohort2");

            Student Ash = new Student("Ash", "Prakash", "ash", "Cohort3");

            Student Cole = new Student("Cole", "Bryant", "colebryant", "Cohort4");

            List<Student> students = new List<Student>() {
                Mary,
                Asia,
                Ash,
                Cole
            };

            // INSTRUCTOR
             Instructor Jisie = new Instructor("Jisie", "David", "@jisie", "Cohort1");
            Instructor Andy = new Instructor("Andy", "Collins", "@aNDY", "Cohort2");
            Instructor Steve = new Instructor("Steve", "Brownlee", "@steve", "Cohort3");
            List<Instructor> instructors = new List<Instructor>(){
                Jisie,
                Andy,
                Steve
            };

            Steve.Assign(Cole, Dictionaries);
            Steve.Assign(Cole, ListsExercises);
            Andy.Assign(Asia, Dictionaries);
            Andy.Assign(Asia, ListsExercises);
            Andy.Assign(Mary, Dictionaries);
            Andy.Assign(Mary, ListsExercises);
            // Jisie.Assign(Ash, Dictionaries);
            // Jisie.Assign(Ash, ListsExercises);


            List<Exercise> JSExercises = ( from exercise in exercises
            where exercise.Language == "Javascript"
            select exercise).ToList();

             List<Student> Cohort2Students = (from student in students
            where student.CohortNumber == "Cohort2"
            select student
            ).ToList();
            Console.WriteLine(Cohort2Students);

             List<Instructor> Cohort3Instructor = (from instructor in instructors
            where instructor.CohortNumber == "Cohort3"
            select instructor).ToList();
           
           List<Student> StudentsByLastName = (from student in students
            orderby student.LastName
            select student).ToList();

            List<Student> StudentWithoutExercises = (from student in students
                where student.Exercises.Count() == 0
                select student).ToList();

             List<Student> StudentWithMostExercises = (from student in students
                orderby student.Exercises.Count descending
                select student).ToList();

              List<CohortRoster> StudentsInCohort = (from student in students
                group student.FirstName by student.CohortNumber into cohortRoster
                select new CohortRoster {
                CohortNumber = cohortRoster.Key,
                StudentCount = cohortRoster.Count()
                }).ToList();
            }
        }
    }
}

