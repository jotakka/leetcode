using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   public class NQueens {

      private int ROWS = 8, COLS = 8;
      private int[,] isUnderAtaclBoard;

      public int TotalNQueens(int n) {
         ROWS = n;
         COLS = n;
         isUnderAtaclBoard = new int[n, n];

         return queenBackTracking();

      }

      public int queenBackTracking(int row = 0, int count = 0) {

         for (int j = 0; j < COLS; j++) {
            if (!IsUnderAtack(row, j)) {

               InsertQueen(row, j);
               if (row == ROWS - 1) {
                  count++;
               } else {
                  count = queenBackTracking(row + 1, count);
               }

               RemoveQueen(row, j);
            }
         }

         return count;
      }

      private void InsertQueen(int x, int y) {
         insertOrRemove(x, y, +1);
      }

      private void RemoveQueen(int x, int y) {
         insertOrRemove(x, y, -1);
      }

      private void insertOrRemove(int x, int y, int val) {
         int i, j;
         var valXY = isUnderAtaclBoard[x, y];
         for (i = 0; i < COLS; i++) {
            isUnderAtaclBoard[i, y] += val;
         }

         for (i = x, j = y; i < ROWS && j < COLS; i++, j++) {
            isUnderAtaclBoard[i, j] += val;
         }
         for (i = x, j = y; i >= 0 && j >= 0; i--, j--) {
            isUnderAtaclBoard[i, j] += val;
         }

         for (i = x, j = y; i < ROWS && j >= 0; i++, j--) {
            isUnderAtaclBoard[i, j] += val;
         }
         for (i = x, j = y; i >= 0 && j < COLS; i--, j++) {
            isUnderAtaclBoard[i, j] += val;
         }

         isUnderAtaclBoard[x, y] = valXY + val;
      }




      public bool IsUnderAtack(int x, int y) {
         return isUnderAtaclBoard[x, y] > 0;
      }


   }
}
