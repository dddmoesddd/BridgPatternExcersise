using System;
using System.Collections.Generic;
using System.Text;

namespace BridgPattern
{
    class SendEmail : SendDataAbstraction
    {
        public override void Send()
        {
            Implemntor.Send("Email");
        }
    }
}
