using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCISES
            Exercise ClassesExercise = new Exercise();
            ClassesExercise.Name = "ClassesExercise";
            ClassesExercise.Language = "C#";

            Exercise ListsExercises = new Exercise();
            ListsExercises.Name = "ListsExercises";
            ListsExercises.Language = "C#";

            Exercise Dictionaries = new Exercise();
            Dictionaries.Name = "Dictionaries";
            Dictionaries.Language = "C#";

            Exercise Sets = new Exercise();
            Sets.Name = "Sets";
            Sets.Language = "C#";

            // COHORT   
            Cohort Cohort1 = new Cohort();

            Cohort Cohort2 = new Cohort();

            Cohort Cohort3 = new Cohort();

            Cohort Cohort4 = new Cohort();

            // STUDENT
            Student Mary = new Student();
            Mary.FirstName = "Mary";
            Mary.LastName = "Remo";
            Mary.SlackHandle = "maryremo";

            Student Asia = new Student();
            Asia.FirstName = "Asia";
            Asia.LastName = "Carter";
            Asia.SlackHandle = "asiacarter";

            Student Ash = new Student();
            Ash.FirstName = "Ash";
            Ash.LastName = "Prakash";
            Ash.SlackHandle = "ashprakash";

            Student Cole = new Student();
            Cole.FirstName = "Cole";
            Cole.LastName = "Bryant";
            Cole.SlackHandle = "colebryant";

            //  Student List
            Cohort1.Students = new List<Student>();
            Cohort2.Students = new List<Student>();
            Cohort3.Students = new List<Student>();

            Cohort1.Students.Add(Cole);
            Cohort2.Students.Add(Ash);
            Cohort3.Students.Add(Asia);
            Cohort3.Students.Add(Mary);

            // INSTRUCTOR
            Instructor Steve = new Instructor();
            Steve.FirstName = "Steve";
            Steve.LastName = "Brownlee";
            Steve.SlackHandle = "SteveBrownlee";

            Instructor Jisie = new Instructor();
            Jisie.FirstName = "Jisie";
            Jisie.LastName = "David";
            Jisie.SlackHandle = "JisieDavid";

            Instructor Andy = new Instructor();
            Andy.FirstName = "Andy";
            Andy.LastName = "Collins";
            Andy.SlackHandle = "AndyCollins";

            // Instructor List
            Cohort1.Instructors = new List<Instructor>();
            Cohort2.Instructors = new List<Instructor>();
            Cohort3.Instructors = new List<Instructor>();

            Cohort1.Instructors.Add(Steve);
            Cohort2.Instructors.Add(Jisie);
            Cohort3.Instructors.Add(Andy);

            // Cohort List
            List<Cohort> Cohorts = new List<Cohort>();

            Cohorts.Add(Cohort1);
            Cohorts.Add(Cohort2);
            Cohorts.Add(Cohort3);

            Steve.Assign(Cole, Dictionaries);
            Steve.Assign(Cole, ListsExercises);
            Andy.Assign(Asia, Dictionaries);
            Andy.Assign(Asia, ListsExercises);
            Andy.Assign(Mary, Dictionaries);
            Andy.Assign(Mary, ListsExercises);
            Jisie.Assign(Ash, Dictionaries);
            Jisie.Assign(Ash, ListsExercises);
           
        }
    }
}
