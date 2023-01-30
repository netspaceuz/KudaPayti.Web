using kudapoyti.Service.Common.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kudapoyti.Service.Common.Helpers
{
    public class TimeHelper
    {
        public static DateTime GetCurrentServerTime()
        {
            var time = DateTime.UtcNow;
            return DateTime.UtcNow.AddHours(TimeConstants.UTC);
        }
    }
}
