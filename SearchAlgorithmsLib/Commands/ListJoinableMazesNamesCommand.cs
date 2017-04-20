using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Model;

namespace Commands
{
    public class ListJoinableMazesNamesCommand: AbstractCommand
    {
        public ListJoinableMazesNamesCommand(IModel model):base(model){ }


        public override string Execute(string[] args, TcpClient client = null)
        {
            return  JsonConvert.SerializeObject(Model.GetNamesOfJoinableMazes());
        }


    }
}
