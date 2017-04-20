using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Model;
using MazeLib;

namespace Commands
{
    public class GenerateMazeCommand : AbstractCommand
    {
        public GenerateMazeCommand(IModel model):base(model)
        {}

        public override string Execute(string[] args, TcpClient client)
        {
            string name = args[0];
            int rows = int.Parse(args[1]);
            int cols = int.Parse(args[2]);
            Maze maze = Model.GenerateteSinglePlayerMaze(name, rows, cols);
            return maze.ToJSON();
        }
    }
}
