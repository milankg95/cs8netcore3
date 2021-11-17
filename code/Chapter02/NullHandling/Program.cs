﻿using System;

#nullable enable

namespace NullHandling
{

    class Address {
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int thisCannotBeNull = 4;
            // thisCannotBeNull = null;

            int? thisCouldBeNull = null;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            thisCouldBeNull = 7;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            var address = new Address();
            address.Building = null;
            // address.City = null;
            // address.Region = null;

            string authorName = null;
            // int x = authorName.Length;

            // int?y = authorName?.Length;

            var result = authorName?.Length ?? 3;
            Console.WriteLine(result);
        }
    }
}
