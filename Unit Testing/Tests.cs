﻿using System;
using NUnit.Framework;

namespace Unit_Testing
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Pertambahan()
        {
            int a = 200;
            int b = 100;
            int c = Count.Math.pertambahan(a, b);
            
            Assert.AreEqual(300, c);
        }
        
        [Test]
        public void Pengurangan()
        {   
            int a = 4000;
            int b = 3000;
            int c = Count.Math.pengurangan(a, b);
            
            Assert.AreEqual(1000, c);
        }
    }
}