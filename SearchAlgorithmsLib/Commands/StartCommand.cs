using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    public class StartCommand:AbstractCommand
    {


        public override string Execute(string[] args, TcpClient client = null)
        {
            string mazeName = args[0];
            int rows = 0;
            int cols = 0;
            try
            {
              rows = Convert.ToInt32(args[1]);
                cols = Convert.ToInt32(args[2]);
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Input string is not a sequence of digits.");
            }
            return Model.GenerateMultiPlayerMaze(mazeName, rows, cols).ToJSON();
            
        }

    }
}
