using leetcode.Exercises.Solution.Easy;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;


public class Solution {
   public string ReverseWords(string s) {
      var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

      for (int i = 0; i < words.Length; i++) {
         
         words[i] = new string(words[i].Reverse().ToArray());
      }

      return string.Join(" ",words);
   }
}

