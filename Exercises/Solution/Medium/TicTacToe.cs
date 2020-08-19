using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Medium {
   public class TicTacToe {

      /** Initialize your data structure here. */

      private int[,] verticalBoard, horizontalBooard;
      private int[] diag1, diag2;
      private int N;
      public TicTacToe(int n) {
         verticalBoard = new int[n, 2];
         horizontalBooard = new int[n, 2];
         diag1 = new int[2];
         diag2 = new int[2];
         this.N = n;
      }

      /** Player {player} makes a move at ({row}, {col}).
          @param row The row of the board.
          @param col The column of the board.
          @param player The player, can be either 1 or 2.
          @return The current winning condition, can be either:
                  0: No one wins.
                  1: Player 1 wins.
                  2: Player 2 wins. */
      public int Move(int row, int col, int player) {

         int d1r = 0, d2r = 0;
         var vr = ++verticalBoard[row, player - 1];
         var hr = ++horizontalBooard[col, player - 1];
         if (row == col) {
            d1r = ++diag1[player - 1];
         }
         if (row + col == N - 1) {
            d2r = ++diag2[player - 1];
         }

         if (d1r == N || d2r == N || vr == N || hr == N) {
            return player;
         }

         // Console.WriteLine($"{d2r} {d1r} {hr} {vr} - {player}");
         return 0;
      }
   }
}
