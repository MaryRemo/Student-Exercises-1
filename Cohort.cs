using System;
using System.Collections.Generic;

namespace StudentExercises
{
   public class Cohort
    {

        public string CohortName { get; set;}
        public List<Student> Students { get; set;}
        public List<Instructor> Instructors { get; set;}
        public Cohort() {
        Students = new List<Student>();
        Instructors = new List<Instructor>();
        }
    }
}