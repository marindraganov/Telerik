namespace GSMConsoleApp
{
    using System;

    using GSM;

    public static class GSMCallHistoryTest
    {
        public static void Test()
        {
            Console.WriteLine("------START TEST GSM_CALL_HISTORY------");
            GSM myGSM = new GSM("StrongPhone4", "Evolveo");
            
            AddSomeCalls(myGSM);
            ListCalls(myGSM);

            Console.WriteLine("Remove call from position 2\n");
            myGSM.DeleteCall(2);
            ListCalls(myGSM);

            decimal price = 0.37M;
            Console.WriteLine("Price for calls in the history based on {0}$/min = {1}$\n", price, myGSM.CalculateCallsPrice(price));

            Console.WriteLine("Clear calls\n");
            myGSM.ClearHistory();
            ListCalls(myGSM);
        }

        public static void AddSomeCalls(GSM gsm)
        {
            gsm.AddCall(new DateTime(2015, 1, 10, 2, 23, 15), "0883 215 215", 340);
            gsm.AddCall(new DateTime(2015, 1, 12, 20, 33, 54), "0899 111 222", 125);
            gsm.AddCall(new DateTime(2015, 1, 23, 15, 10, 2), "02 1234567", 222);
            gsm.AddCall(new DateTime(2015, 2, 14, 23, 12, 15), "0900 12 13", 119);
        }

        public static void ListCalls(GSM gsm)
        {
            Console.WriteLine("{0} call history:", gsm.Model);

            if (gsm.CallHistory.Count == 0)
            {
                Console.WriteLine("call history is empty");
            }

            for (int i = 0; i < gsm.CallHistory.Count; i++)
            {
                Call currCall = gsm.CallHistory[i];
                DateTime currDate = currCall.CallDate;
                Console.WriteLine("{0}. {1}:{2} {3}h:{4}m {5}  duration: {6}sec",
                    i, currDate.Day, currDate.Month, currDate.Hour, 
                    currDate.Minute, currCall.DialedPhoneNumber, currCall.Duration);
            }
            
            Console.WriteLine();
        }
    }
}
