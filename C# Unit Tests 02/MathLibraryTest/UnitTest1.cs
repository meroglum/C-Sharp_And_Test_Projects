﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;
using System;
using MathLibrary;

namespace MathLibraryTest
{
    /// <summary>
    /// Lecture notes.
    /// </summary>
    // https://www.c-sharpcorner.com/article/a-basic-introduction-of-unit-test-for-beginners/

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            BasicMath math = new BasicMath();
            double result = math.Add(10, 10);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void Test_SubstractMethod()
        {
            BasicMath math = new BasicMath();
            double result = math.Substract(12, 10);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Test_DivideMethod()
        {
            BasicMath math = new BasicMath();
            double result = math.Divide(100, 2);
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void Test_MultiplyMethod()
        {
            BasicMath math = new BasicMath();
            double result = math.Multiply(11, 2);
            Assert.AreEqual(22, result);
        }
    }
}
