using System;
using System.Collections.Generic;
using System.Text;

namespace BridgPattern
{
    public abstract class SendDataAbstraction
    {
        public IImplementor Implemntor { get; set; }
        public    abstract void Send();
    }
}
