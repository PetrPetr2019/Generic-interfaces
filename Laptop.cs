﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StaffSport
{
    class Laptop : ISwitchable<int>
    {
        public void SwitchTVOf()
        {
            Console.WriteLine("Laptop OF");
        }

        public void SwitchTVOn()
        {
            Console.WriteLine("Laptop ON");
        }
    }
}