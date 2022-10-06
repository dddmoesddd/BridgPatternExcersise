using System;
using System.Collections.Generic;
using System.Text;

namespace BridgPattern
{
    class WebService : IImplementor
    {
        public void Send(string method)
        {
            Console.WriteLine("sending.."+method+"vie webservice");
        }
    }
}
