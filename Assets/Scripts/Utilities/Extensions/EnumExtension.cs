using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Lunar.Utilities
{
    public static class EnumExtension
    {
        public static int ToInt<T>(this T priority) where T : Enum
        {
            return Convert.ToInt32(priority);
        }
        public static T GetMaxValue<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T)).Cast<T>().Max();
        }

        public static int GetMaxIntValue<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T)).Cast<int>().Max();
        }

        public static T GetMinValue<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T)).Cast<T>().Min();
        }
        
        public static int GetMinIntValue<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T)).Cast<int>().Min();
        }
    }
}

