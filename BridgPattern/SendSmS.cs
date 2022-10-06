using System;
using System.Collections.Generic;
using System.Text;

namespace BridgPattern
{
    public class SendSmS : SendDataAbstraction
    {
        public override void Send()
        {
            Implemntor.Send("sms");
        }
    }
}
