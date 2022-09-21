using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using IRemoteEMS;
using CRemoteEMS;

namespace RemoteServerEMS
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpChannel ch = new HttpChannel(123);
            ChannelServices.RegisterChannel(ch);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(CRemote), "db_oper", WellKnownObjectMode.Singleton);
            Console.WriteLine("Remote server is now ready");
            Console.Read();
        }
    }
}
