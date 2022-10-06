using System;
using System.Collections.Generic;
using System.Text;

namespace BridgPattern
{
    class ThirdParty : IImplementor
    {
        public void Send(string method)
        {
            Console.WriteLine("sending.." + method + "ThirdParty");
        }
    }
}
