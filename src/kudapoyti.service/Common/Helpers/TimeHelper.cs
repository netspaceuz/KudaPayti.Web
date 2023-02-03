using kudapoyti.Service.Common.Constants;

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
