using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Net.Sockets;

namespace Commands
{
    public abstract class AbstractCommand : ICommand
    {
        private IModel model;

        public AbstractCommand(IModel model)
        {
            this.model = model;
        }


        public IModel Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public abstract string Execute(string[] args, TcpClient client = null);
    }
}
