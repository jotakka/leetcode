using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;

namespace leetcode {
   class Program {


      private class Distance {
         public int Idx { get; set; }
         public uint DistanceQuad { get; set; }

         public Distance(int x, int y, int idx) {
            DistanceQuad = (uint)(x * x + y * y);
            Idx = idx;
         }

      }





      public class Solution {
         public void Rotate(int[][] matrix) {
            var len = matrix.Length;
            for (int j = 0; j < len; j++) {
               for (int i = 0; i < len / 2; i++) {
                  var aux1 = matrix[i][j];
                  matrix[i][j]= matrix[i][len - j - 1];
                 
                  var aux2 = matrix[i][len - j - 1];
                  matrix[i][len - j - 1] = aux1;

                  aux1 = matrix[len - i - 1][len - j - 1];
                  matrix[len - i - 1][len - j - 1] = aux2;

                  matrix[len - i - 1][j] = aux1;
               }
            }


         }
      }



      static void Main(string[] args) {
         Console.WriteLine("Hello World!");

      }
   }



   /**
    * Your TicTacToe object will be instantiated and called as such:
    * TicTacToe obj = new TicTacToe(n);
    * int param_1 = obj.Move(row,col,player);
    */

}
