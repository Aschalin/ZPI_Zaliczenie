using System;
using ConsoleApplication2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ConsoleApplicationTests
{
    [TestClass]
    public class RiverUnitTest
    {
        [TestMethod]
        public void Test1CountAlive()
        {
            int[] FishSizes = { 4, 3, 2, 1, 5 }, FishDirections = { 0, 1, 0, 0, 0 };
            Assert.AreEqual(2, River.CountAliveFishes(FishSizes, FishDirections));
        }

        [TestMethod]
        public void Test2CountAlive()
        {
            int[] FishSizes = { 4, 2, 3, 1, 5 }, FishDirections = { 0, 1, 0, 1, 0 };
            Assert.AreEqual(3, River.CountAliveFishes(FishSizes, FishDirections));
        }
        
        [TestMethod]
        public void Test3CountAlive()
        {
            int[] FishSizes = { 4, 2, 3, 1, 5 }, FishDirections = { 0, 0, 0, 0, 0 };
            Assert.AreEqual(5, River.CountAliveFishes(FishSizes, FishDirections));
        }

        [TestMethod]
        public void Test1EatUpstreamers()
        {
            int fishWeight = 3;
            Stack<int> upstreamers = new Stack<int>(new List<int> { 5, 2, 1 });

            Assert.IsFalse(River.EatUpstreamers(fishWeight,ref upstreamers));
            Assert.AreEqual(1, upstreamers.Count);
        }
        
        [TestMethod]
        public void Test2EatUpstreamers()
        {
            int fishWeight = 6;
            Stack<int> upstreamers = new Stack<int>(new List<int> { 5, 2, 1 });

            Assert.IsTrue(River.EatUpstreamers(fishWeight, ref upstreamers));
            Assert.AreEqual(0, upstreamers.Count);
        }
        
        [TestMethod]
        public void Test3EatUpstreamers()
        {
            int fishWeight = 1;
            Stack<int> upstreamers = new Stack<int>(new List<int> { 5, 2, 4 });

            Assert.IsFalse(River.EatUpstreamers(fishWeight, ref upstreamers));
            Assert.AreEqual(3, upstreamers.Count);
        }
    }
}
