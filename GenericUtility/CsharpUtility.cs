susing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manoj.GenericUtility
{
   public class CsharpUtility
    {
        public int RandomGeneratedNumber(int range)
        {
            Random random = new Random();
            return random.Next(range);
        }
        public string GetCurrentTimeAndTime()
        {
            DateAndTime datetime = DateAndTime.Now;
            string timestamp = datetime.ToString("dd MM yyyy mm hh ss");
            return timestamp;
        }
        public string GetRequiredDate(int num)
        {
            DateAndTime datetime = DateAndTime.Now;
            DateAndTime ddt = datetime.Add(num);
            string requireddate = ToString("dd MM yyyy");
            return requireddate;
        }
    }
}