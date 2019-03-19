using System;
using System.Collections.Generic;

namespace StudentExercises
{
   public class Instructor
    {
           public Instructor(string firstName, string lastName, string slackHandle, string cohortNumber) {
            FirstName = firstName;
           LastName = lastName;
           SlackHandle = slackHandle;
           CohortNumber = CohortNumber;

        }
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string SlackHandle { get; set;}
        public string CohortNumber { get; set;}
        public List<Exercise> Exercises { get; set;}
        public void Assign(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);
            Console.WriteLine($"{FirstName} assigned {exercise.Name} to {student.FirstName}");
        }
        
    }

}