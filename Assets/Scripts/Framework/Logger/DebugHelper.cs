using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Lunar.Core
{
    public static class DebugHelper
    {
        public static void Test(params object[] objects)
        {
            var message = string.Join(", ", objects.ToList().Where(v => v != null));
            Debug.Log(message);
        }
    }
}

