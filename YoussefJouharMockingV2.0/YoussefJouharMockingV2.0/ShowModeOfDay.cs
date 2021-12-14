using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoussefJouharMockingV2._0
{
    public class ShowModeOfDay
    {
        public WorldTimeByIP worldTime_ByIP;
        public string ConvertTimeTowardsSentence(DateTime datetime) 
        {
            if (datetime.Hour >= 7 && datetime.Hour < 12)
                return "Day";

            if (datetime.Hour >= 12 && datetime.Hour < 18)
                return "Noon";

            if (datetime.Hour >= 18 && datetime.Hour < 23)
                return "Evening";

            if (datetime.Hour >= 23 && datetime.Hour < 7)
                return "Night";
            
            else
                return "Invalid data";
        }
    }
}
