namespace GSMConsoleApp
{
    using System;
    using System.Collections.Generic;

    using GSM;

    public static class GSMTest
    {     
        public static void Test()
        {
            Console.WriteLine("----START TEST GSM-------");

            List<GSM> someGSMs = CreateGSMs();

            foreach (var gsm in someGSMs)
            {
                Console.WriteLine(gsm);
                Console.WriteLine();
            }

            Console.WriteLine(GSM.IPhone4SInfo);
            Console.WriteLine();
        }

        private static List<GSM> CreateGSMs()
        {
            List<GSM> gsms = new List<GSM>();

            GSM oldNokia = new GSM("3310", "Nokia", 100.23M, "Bat Gosho");
            oldNokia.Battery = new Battery("oldOne", BatteryType.NiMH, 70, 2.5);

            GSM samsungGalaxy = new GSM("GalaxyS5Mini", "Samsung", 345.00M, "Nacepena Batka");
            samsungGalaxy.Battery = new Battery("oldOne", BatteryType.LiIon, 45, 4.2);
            samsungGalaxy.Display = new Display(720, 1280, 16000000);

            GSM chinaPhone = new GSM("chine_phone_12", "China GSM Factory", 50M, "Beden Student");

            gsms.Add(oldNokia);
            gsms.Add(samsungGalaxy);
            gsms.Add(chinaPhone);

            return gsms;
        }
    }
}
