using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16a_Inheritance.Practice
{
    public class Detail : Notification
    {
        public void Viettel()
        {
            Console.WriteLine(" * Viettel Hotline 18008098 operates 24/7, always ready to listen and answer all customer questions in the most thoughtful way. *");
        }
        public void Mobfifone()
        {
            Console.WriteLine("* Mobifone switchboard phone number to receive customer complaints and complaints: 1800 1090 *");
        }
        public void Vinaphone()
        {
            Console.WriteLine("* Working hours: Switchboard 18001091 branches 1, 2, 3 serve 24h/7; Branches 4 and 5 serve from 7:00 a.m. to 9:00 p.m. daily and every day of the year. Free for VinaPhone subscribers and VNPT subscribers. *");
        }
    }
}
