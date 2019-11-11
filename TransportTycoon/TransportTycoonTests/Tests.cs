using NUnit.Framework;
using System;
using System.Linq;
using TransportTycoon;

namespace TransportTycoonTests
{
    public class Tests
    {
        [TestCase("A", 5u)]
        [TestCase("AB", 5u)]
        [TestCase("BB", 5u)]
        [TestCase("ABB", 7u)]
        [TestCase("AABABBAB", 29u)]
        [TestCase("AAAABBBB", 29u)]
        [TestCase("BBBBAAAA", 49u)]
        public void Delivery(string destinations, uint timeInHours)
        {
            // Arrange
            var world = new World(destinations.Select(x => x.ToString()));

            // Act
            world.Deliver();

            // Assert
            Assert.AreEqual(TimeSpan.FromHours(timeInHours), world.CurrentTime);
        }
    }
}