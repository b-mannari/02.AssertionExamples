using System;

namespace CodeSamplesForAssertion
{
    public class BooleanSample
    {
        public bool IsWeekDay(string dayOfWeek)
        {
            if (string.Equals(dayOfWeek, "monday", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(dayOfWeek, "tuesday", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(dayOfWeek, "wednesday", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(dayOfWeek, "thursday", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(dayOfWeek, "friday", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }
    }
}
