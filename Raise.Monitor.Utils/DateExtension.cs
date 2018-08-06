using System;

namespace Raise.Monitor.Tools {
    public static class DateExtension {
        public static DateTime ToEarlyMorning(this DateTime dateTime) {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 23, 59, 59);
        }
    }
}
