using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
  public class Logger {
      private Dictionary<string, int> dict = new Dictionary<string, int>();

      private const int MIN_TIME_REPEAT = 10;

      public Logger() {

      }

      /** Returns true if the message should be printed in the given timestamp, otherwise returns false.
          If this method returns false, the message will not be printed.
          The timestamp is in seconds granularity. */
      public bool ShouldPrintMessage(int timestamp, string message) {

         if (dict.ContainsKey(message)) {
            if (timestamp - dict[message] < MIN_TIME_REPEAT) {
               return false;
            } else {
               dict[message] = timestamp;
               return true;
            }
         } else {
            dict.Add(message, timestamp);
            return true;
         }
      }
   }
}
