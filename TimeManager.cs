using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts
{
    public static class TimeManager
    {
        public delegate void TickHandler();
        public static TickHandler TickEvent;

        private const int tickInterval = 1000; // ms


        private static async void StartTicking()
        {
            while (true)
            {
                await Task.Delay(tickInterval);
                TickEvent();
            }
        }
        

    }
}
