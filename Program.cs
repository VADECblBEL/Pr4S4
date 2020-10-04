using System;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;

namespace Pr4S4
{
    class Program
    {
        static void Main(string[] args)
        {
            ListDictionary ld = new ListDictionary(new CaseInsensitiveComparer(CultureInfo.InvariantCulture));
            ld["Estados Unidos"] = "USA";
            ld["Canada"] = "Canada";
            ld["Espana"] = "Spain";

            Console.WriteLine(ld["Canada"]);
            Console.WriteLine(ld["Espana"]);

        }
    }
}
