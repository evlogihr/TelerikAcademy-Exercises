using MobilePhoneLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var gsm = new GSM("M8", "HTC", 100.0m, "Ivan", new Battery { Model = "asdf", HoursIdle = 100 }, new Display());
            gsm.CallHistory.Add(new Call() { Duration = 10000000, DialedPhone = "niama takuv nomer" });

            for (int i = 0; i < 10; i++)
            {
                gsm.AddCall(new Call()
                {
                    DialedPhone = "000" + i,
                    Duration = (uint)(i + 1) * 120
                });
            }

            var maxCall = new Call();
            foreach (Call call in gsm.CallHistory)
            {
                Console.WriteLine(call);
                if (maxCall.Duration < call.Duration)
                    maxCall = call;
            }

            Console.WriteLine(gsm.CalculateTotalCost(0.37m));
            gsm.DeleteCall(maxCall);
            Console.WriteLine(gsm.CalculateTotalCost(0.37m));


            // Console.WriteLine(gsm);
            // Console.WriteLine(GSM.IPhone4S);


        }
    }
}
