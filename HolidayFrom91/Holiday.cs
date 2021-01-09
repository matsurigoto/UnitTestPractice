﻿using System;

namespace HolidayFrom91
{
    public class Holiday
    {
        public string SayHello()
        {
            var today = GetToday();
            if (today.Month == 12 && (today.Day == 25 || today.Day == 24))
            {
                return "Merry Xmas";
            }
            return "Today is not Xmas";
        }

        protected virtual DateTime GetToday()
        {
            return DateTime.Today;
        }
    }
}
