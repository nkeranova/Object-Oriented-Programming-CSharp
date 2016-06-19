using DefiningClasses;
using System;

namespace GSMCallHistoryTest
{
    class Startup
    {
        static void Main(string[] args)
        {
            var calls = new Call[]
            {
                new Call(DateTime.Now, TimeSpan.FromSeconds(52), "3598873629", 15),
                new Call(DateTime.Now, TimeSpan.FromSeconds(23), "3598546846", 25),
                new Call(DateTime.Now, TimeSpan.FromSeconds(45), "3597994516", 35)
            };

            var gsm = new GSM("6", "Nexus");
            gsm.AddCall(calls[0]);
            gsm.AddCall(calls[1]);
            gsm.AddCall(calls[2]);

            foreach (var call in gsm.CallHistory)
            {
                Console.WriteLine(call);
            }

            Console.WriteLine(gsm.CalculateTotalPrice(0.37m));

            gsm.DeleteCall(calls[2]);

            Console.WriteLine(gsm.CalculateTotalPrice(0.37m));

            gsm.ClearCall();

            Console.WriteLine(gsm.CalculateTotalPrice(0.37m));
        }
    }
}
