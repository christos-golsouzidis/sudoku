using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace sudoku3._2
{
    public class Grid
    {
        [DllImport("sudolib.dll")]
        public static extern IntPtr CPP_Creategrid();
        [DllImport("sudolib.dll")]
        public static extern void CPP_Deletegrid(IntPtr _grid);
        [DllImport("sudolib.dll")]
        public static extern IntPtr CPP_Fillgrid(IntPtr _grid);
        [DllImport("sudolib.dll")]
        public static extern IntPtr CPP_Removedigits(IntPtr _grid, int retries);
        [DllImport("sudolib.dll")]
        public static extern IntPtr CPP_Emptygrid(IntPtr _grid);
        [DllImport("sudolib.dll")]
        public static extern IntPtr CPP_Solveit(IntPtr _grid);
        [DllImport("sudolib.dll")]
        public static extern uint CPP_Createrandomsequence(IntPtr _grid, long seed);
        [DllImport("sudolib.dll")]
        public static extern bool CPP_Check4collision(IntPtr _grid, int x, int y);


        public IntPtr _grid;
        public IntPtr _addr;
        public byte[] vector = new byte[81];
        public string puzzleid;

        public Grid()
        {
            _grid = CPP_Creategrid();
        }
        ~Grid()
        {
            CPP_Deletegrid(_grid);
        }

        public void FillGrid()
        {
            _addr = CPP_Fillgrid(_grid);
            Marshal.Copy(_addr, vector, 0, 81);
        }

        public void RemoveDigits()
        {
            _addr = CPP_Removedigits(_grid, 64);
            Marshal.Copy(_addr, vector, 0, 81);
        }

        public void EmptyGrid()
        {
            _addr = CPP_Emptygrid(_grid);
            Marshal.Copy(_addr, vector, 0, 81);
        }

        public void SolveIt()
        {
            _addr = CPP_Solveit(_grid);
            Marshal.Copy(_addr, vector, 0, 81);
        }

        public int CountClues()
        {
            int clues = 0;
            foreach (int c0 in vector)
            {
                if (c0 != 0)
                    clues++;
            }
            return clues;
        }

        public void CreateRandomSequence(long seed)
        {
            puzzleid = CPP_Createrandomsequence(_grid, seed).ToString("X");
        }



    }


}
