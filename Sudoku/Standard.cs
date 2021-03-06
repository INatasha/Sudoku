﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    [Serializable]
    public class Standard : Sudoku
    {
        /// <summary>
        /// PuzzleGrid, PuzzleSolver and PuzzleGenerator 
        /// are used to generate a starting state of the grid,
        /// to implement the algorithm for solving the starting grid
        /// and to check if the blanked grid has a unique solution
        /// </summary>
        public PuzzleGrid puzzleGrid;
        public PuzzleSolver puzzleSolver;
        public PuzzleGenerator puzzleGenerator;
        public static int[,] scheme = new int[,]{{0,0,0,1,1,1,2,2,2},
                                    {0,0,0,1,1,1,2,2,2},
                                    {0,0,0,1,1,1,2,2,2},
                                    {3,3,3,4,4,4,5,5,5},
                                    {3,3,3,4,4,4,5,5,5},
                                    {3,3,3,4,4,4,5,5,5},
                                    {6,6,6,7,7,7,8,8,8},
                                    {6,6,6,7,7,7,8,8,8},
                                    {6,6,6,7,7,7,8,8,8}};


        /// <summary>
        /// Return object of type Standard:Sudoku
        /// </summary>
        /// <param name="diff">Difficulty of Sudoku</param>
        public Standard(Difficulty diff): base (diff)
        {
            base.scheme = scheme;
            puzzleGrid = new PuzzleGrid();
            puzzleSolver = new PuzzleSolver();
            puzzleGenerator = new PuzzleGenerator(diff);

            puzzleGenerator.InitGrid();
            
            base.solution = puzzleGenerator.SolutionGrid.Grid;
            base.mask = puzzleGenerator.PermaGrid.Grid;//check for negative values 
            userGrid.Initialize();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    mask[i, j] = -mask[i, j];
                    userGrid[i, j] = mask[i, j];
                }
            }
        }

    }
}
