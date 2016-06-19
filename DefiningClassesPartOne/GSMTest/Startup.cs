using DefiningClasses;
using System;

namespace GSMTest
{
    class Startup
    {
        static void Main()
        {
            var phones = new GSM[]
            {
                     new GSM("VIBE", "Lenovo"),
                     new GSM("6", "IPhone", 1000m),
                     new GSM("Galaxy S5", "Samsung", 850m, "Jhon Jakson"),
                     new GSM("Mi5", "Xiaomi", 800m, "Natalie Klein", new Battery(BatteryType.LiIon, 250, 678)),
                     new GSM("Xperia Z1", "Sony", 700m, "Niko Tomson", new Battery(BatteryType.NiCd, 150, 222))
            };

            foreach (var gsm in phones)
            {
                Console.WriteLine(gsm.ToString());
            }
        }
    }
}
