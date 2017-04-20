using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace ServerProject
{
    class Player
    {
        private TcpClient client;

        public Player(TcpClient tcpClient)
        {
            this.client = tcpClient;
        }

        public TcpClient Client
        {
            get
            {
                return this.client;
            }
        }


    }
}
