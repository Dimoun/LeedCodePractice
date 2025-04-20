using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BackTrack
{
    public class LeetCode_51
    {
        List<IList<string>> res = new List<IList<string>>();
        public IList<IList<string>> SolveNQueens(int n)
        {
            char[][] resList = new char[n][];

            for (int i = 0; i < n; i++)
            {
                resList[i] = new char[n];
                for (int j = 0; j < n; j++)
                {
                    resList[i][j] = '.';
                }
            }
            BackTracking(n, 0, resList);
            return res;
        }

        public void BackTracking(int n, int row, char[][] list)
        {
            if (row == n)
            {
                res.Add(list.Select(x => new string(x)).ToList());
                return;
            }

            for (int col = 0; col < n; col++)
            {
                if (IsValid(row, col, list, n))
                {
                    list[row][col] = 'Q';
                    BackTracking(n, row + 1, list);
                    list[row][col] = '.';
                }
            }
        }
        public bool IsValid(int row, int col, char[][] list, int n)
        {
            for (int i = 0; i < row; i++)
            {
                if (list[i][col] == 'Q')
                    return false;
            }

            for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (list[i][j] == 'Q')
                    return false;
            }
            for (int i = row - 1, j = col + 1; i >= 0 && j < n; i--, j++)
            {
                if (list[i][j] == 'Q')
                    return false;
            }

            return true;
        }
    }
}
