/*
 * File: NunitTemplate.cs
 * Unit: COS20007 Object Oriented Programming
 * Institution: Swinburne University of Technology
 */

using System;
using System.Collections.Generic;
using NUnit.Framework; //Don't forget this.
using SwinAdventure;

namespace TestProject1 //This should match your NUnit test project name.
{
    [TestFixture]
    public class UnitTest1 //Rename this appropriately.
    {
        /// <summary>
        /// FIELDS
        /// Declare the fields you are going to use to access the objects you are testing here.
        /// </summary>
        private IdentifiableObject _identifiers;
        private IdentifiableObject _identifiers2;
        [SetUp]
        public void SetUp()
        {
            _identifiers = new IdentifiableObject(new string[] { "id1", "id2" });
            _identifiers2 = new IdentifiableObject(new string[] {null});
        }

        /// <summary>
        /// TESTS
        /// Use these methods to run tests with only one scenario.
        /// Remember to name your test methods appropriately.
        /// </summary>
        //For Example:
        [Test]
        public void TestObjectExists()
        {

            Assert.IsTrue(_identifiers.AreYou("id2"));
            Assert.IsFalse(_identifiers.AreYou("id3"));
            Assert.IsTrue(_identifiers.AreYou("Id2"));
            Assert.IsTrue(_identifiers.AreYou(_identifiers.FirstId));
            Assert.AreEqual("", _identifiers2.FirstId);
            _identifiers.AddIdentifier("bob");
            Assert.IsTrue(_identifiers.AreYou("BoB"));

        }

    }
}