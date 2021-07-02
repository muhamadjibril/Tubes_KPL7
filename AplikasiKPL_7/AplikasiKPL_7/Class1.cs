using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiKPL_7
{
    class Class1
    {
            public enum Username { test, dzaky, arya, jibril, isan };
            public static string[] password = { "test", "dzaky123", "arya123", "jibril123", "isan123" };

            public static string getPassword(Username username)
            {
                return password[(int)username];
            }
    }
}
