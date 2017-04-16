using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeGeneratorLib;
using MazeLib;
using SearchAlgorithmsLib;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            DFSMazeGenerator mazeGen = new DFSMazeGenerator();
            Maze maze = mazeGen.Generate(10,10);
            Console.WriteLine(maze.ToString());
            MazeAdapter mazeAdapter = new MazeAdapter(maze);
            BfsSearcher<Position> bfsSearcher = new BfsSearcher<Position>(new CostComperator<Position>());
            Solution<Position>solution =  bfsSearcher.Search(mazeAdapter);
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
