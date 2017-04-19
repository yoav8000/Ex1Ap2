using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MazeLib;
namespace Commands
{
    public class JoinMazeCommand:AbstractCommand
    {

        public override string Execute(string[] args, TcpClient client)
        {
            Maze maze = Model.JoinMaze(args[0]);
            JObject mazeObj = new JObject();
            mazeObj["Name"] = maze.Name;
            mazeObj["Rows"] = maze.Rows;
            mazeObj["Cols"] = maze.Cols;          
            return JsonConvert.SerializeObject(Model.JoinMaze(args[0]));
        }


    }
}
