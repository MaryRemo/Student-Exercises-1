using System;
using System.Collections.Generic;

namespace StudentExercises
{
   public class Exercise
    {
         public Exercise(string exerciseName, string exerciseLang) {
            Name = exerciseName;
            Language = exerciseLang;

        }

        public string Name { get; set;}
        public string Language { get; set;}

    }
}