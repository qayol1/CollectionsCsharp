﻿using System;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;

namespace LookupCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Make the dictionary case insensitive 
                ListDictionary list = new ListDictionary(new CaseInsensitiveComparer(CultureInfo.InvariantCulture));

                // Add some items
                list["Estados Unidos"] = "United States of America";
                list["Canadá"] = "Canada";
                list["España"] = "Spain";

                // Show the results 
                Console.WriteLine(list["españa"]);
                Console.WriteLine(list["CANADÁ"]);
                Console.Read();
            }
        }
    }
}
