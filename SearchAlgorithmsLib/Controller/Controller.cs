using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using View;
using Commands;
using System.Net.Sockets;

namespace Controller
{
    class Controller:IController
    {
        private IModel model;
        private IController controller;
        private Dictionary<string, ICommand> commands;

        public Controller()
        {
            this.model = new Model.Model();
            commands = new Dictionary<string, ICommand>();
            commands.Add("generate", new Commands.GenerateMazeCommand(model));
            commands.Add("solve", new SolveMazeCommand(model));
            commands.Add("start", new StartCommand(model));
            commands.Add("join", new JoinMazeCommand(model));

        }


        public string ExecuteCommand(string commandLine, TcpClient client)
        {
            string[] arr = commandLine.Split(' ');
            string commandKey = arr[0];
            if (!commands.ContainsKey(commandKey))
                return "Command not found";
            string[] args = arr.Skip(1).ToArray();
            ICommand command = commands[commandKey];
            return command.Execute(args, client);
        }
    }


}
}
