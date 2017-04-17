﻿using System;
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
            Maze maze = mazeGen.Generate(50,50);
            Console.WriteLine(maze.ToString());
            MazeAdapter mazeAdapter = new MazeAdapter(maze);
            SearchAlgorithmFactory<Position> factory = new SearchAlgorithmFactory<Position>();
            ISearcher<Position> bfsSearcher = factory.GetSearchAlgorithm("bfs");
            ISearcher<Position> dfsSearcher = factory.GetSearchAlgorithm("dfs");
            ISearcher<Position> ffsSearcher = factory.GetSearchAlgorithm("sfs");
            //            DfsSearcher<Position> dfsSearcher = new DfsSearcher<Position>();
            Solution<Position>solution =  bfsSearcher.Search(mazeAdapter);
            Solution<Position> solution1 = dfsSearcher.Search(mazeAdapter);
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
