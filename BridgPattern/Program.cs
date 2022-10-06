using System;

namespace BridgPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var sendData = new SendEmail();
            sendData.Implemntor = new ThirdParty();
            sendData.Send();
            Console.ReadLine();
            ////
            ///
            var seneData = new SendSmS();
            seneData.Implemntor = new WebService();
            seneData.Send();
            Console.ReadLine();

        }
    }
}
