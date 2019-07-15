﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWithVIP.GangOfFour.Structural.FactoryMethod
{
    public class Mobile : IProduct
    {
        private double _price;

        public string SayHi()
        {
            return "I am Mobile.";
        }

        public void SetPrice(double price)
        {
           _price = price;
        }
    }
}
