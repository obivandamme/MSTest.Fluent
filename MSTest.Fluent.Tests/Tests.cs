using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest.Fluent.Tests
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    [TestClass]
    public class Tests : TestBase
    {
        [TestMethod]
        public void Bool()
        {
            Expect(true).ToBeTrue().And.Not.ToBeFalse();
            Expect(false).ToBeFalse().And.Not.ToBeTrue();
        }

        [TestMethod]
        public void Double()
        {
            Expect(1.0).ToEqual(1.0)
                .And.ToEqual(1.1, 0.2)
                .And.Not.ToEqual(2.0)
                .And.Not.ToEqual(2.0, 0.2);
        }

        [TestMethod]
        public void Float()
        {
            Expect(1f).ToEqual(1f)
                .And.ToEqual(1.1f, 0.2f)
                .And.Not.ToEqual(2f)
                .And.Not.ToEqual(2f, 0.2f);
        }

        [TestMethod]
        public void Object()
        {
            object nullObject = null;
            var o = new Object();
            var o2 = new object();

            Expect(o).ToBe(o)
                .And.ToBeInstanceOfType(typeof(Object))
                .And.Not.ToBeNull()
                .And.Not.ToBe(o2);

            Expect(nullObject).ToBeNull().And.Not.ToBeInstanceOfType(typeof(Object));
        }

        [TestMethod]
        public void String()
        {
            Expect("string").ToEqual("string")
                .And.Not.ToEqual("not string")
                .And.ToContain("ri")
                .And.ToEndWith("ng")
                .And.ToStartWith("st")
                .And.ToMatch(new Regex(@"^[a-zA-Z]+$"))
                .And.Not.ToMatch(new Regex(@"^[0-9]+$"))
                .And.Not.ToBeNull();
            string s = null;
            Expect(s).ToBeNull();
        }

        [TestMethod]
        public void Collection()
        {
            var collection = new List<int> { 1, 2, 3, 4, 5 };
            var superset = new List<int> { 1, 2, 3, 4, 5, 6 };

            Expect(collection).ToBeEquivalentTo(collection)
                .And.ToBeSubsetOf(superset)
                .And.ToContain(1)
                .And.ToEqual(new List<int> { 1, 2, 3, 4, 5 })
                .And.ToOnlyHaveItemsOfType(typeof(int))
                .And.ToOnlyHaveNotNullItems()
                .And.ToOnlyHaveUniqueItems();
        }

        [TestMethod]
        public void NotCollection()
        {
            var collection = new List<int> { 1, 2, 3, 4, 5 };
            var superset = new List<int> { 1, 2, 3, 4, 5, 6 };

            Expect(collection).Not.ToBeEquivalentTo(superset)
                .And.Not.ToContain(6)
                .And.Not.ToEqual(superset);

            Expect(superset).Not.ToBeSubsetOf(collection);
        }
    }
}
