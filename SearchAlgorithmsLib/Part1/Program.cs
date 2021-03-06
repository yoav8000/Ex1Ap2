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
            string json = @"{
                'Name': 'mymaze',
                'Maze':                '0001010001010101110101010000010111111101000001000111010101110001010001011111110100000000011111111111',
                'Rows': 10,
                'Cols': 10,
                'Start': {
                    'Row': 0,
                    'Col': 4
                },
                'End': {
                    'Row': 0,
                    'Col': 0
                }
            }";

            Maze maze = Maze.FromJSON(json);

            DFSMazeGenerator mazeGen = new DFSMazeGenerator();
           // Maze maze = mazeGen.Generate(10,10);
            Console.WriteLine(maze.ToString());
            MazeAdapter mazeAdapter = new MazeAdapter(maze);
            SearchAlgorithmFactory<Position> factory = new SearchAlgorithmFactory<Position>();
            ISearcher<Position> bfsSearcher = factory.GetSearchAlgorithm("bfs");
            ISearcher<Position> dfsSearcher = factory.GetSearchAlgorithm("dfs");
            Solution<Position>solution1 =  bfsSearcher.Search(mazeAdapter);
            SolutionAdapter solutionAd1 = new SolutionAdapter(solution1, "bla");
            Solution<Position> solution2 = dfsSearcher.Search(mazeAdapter);
            SolutionAdapter solutionAd2 = new SolutionAdapter(solution2, "bla");

            string a = solutionAd1.ToJson();


            Console.WriteLine("the bfs solved the maze int {0}",solution1.NodesEvaluated);
            Console.WriteLine("the dfs solved the maze int {0}", solution2.NodesEvaluated);
            Console.ReadKey();
        }
    }
}
