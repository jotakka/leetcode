using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class DayOfTheWeek {
      public static string dayOfTheWeek(int day, int month, int year) {
         var date = new DateTime(year,month,day);
         return date.DayOfWeek.ToString();
      }
   }
}

