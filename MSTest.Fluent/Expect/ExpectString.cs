namespace MSTest.Fluent.Expect
{
    using System;
    using System.Globalization;
    using System.Text.RegularExpressions;

    using MSTest.Fluent.Generic;
    using MSTest.Fluent.Not;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class ExpectString
    {
        internal string Actual { get; private set; }

        public NotString Not { get; private set; }

        public ExpectString(string actual)
        {
            this.Actual = actual;
            this.Not = new NotString(this);
        }

        public AndConstraint<ExpectString> ToEqual(string expected)
        {
            return this.AssertFluent(() => Assert.AreEqual(expected, this.Actual));
        }

        public AndConstraint<ExpectString> ToEqual(string expected, string message)
        {
            return this.AssertFluent(() => Assert.AreEqual(expected, this.Actual, message));
        }

        public AndConstraint<ExpectString> ToEqual(string expected, string message, params object[] parameters)
        {
            return this.AssertFluent(() => Assert.AreEqual(expected, this.Actual, message, parameters));
        }

        public AndConstraint<ExpectString> ToEqual(string expected, bool ignoreCase)
        {
            return this.AssertFluent(() => Assert.AreEqual(expected, this.Actual, ignoreCase));
        }

        public AndConstraint<ExpectString> ToEqual(string expected, bool ignoreCase, string message)
        {
            return this.AssertFluent(() => Assert.AreEqual(expected, this.Actual, ignoreCase, message));
        }

        public AndConstraint<ExpectString> ToEqual(string expected, bool ignoreCase, string message, params object[] parameters)
        {
            return this.AssertFluent(()=> Assert.AreEqual(expected, this.Actual, ignoreCase, message, parameters));
        }

        public AndConstraint<ExpectString> ToEqual(string expected, bool ignoreCase, CultureInfo culture)
        {
            return this.AssertFluent(() => Assert.AreEqual(expected, this.Actual, ignoreCase, culture));
        }

        public AndConstraint<ExpectString> ToEqual(string expected, bool ignoreCase, CultureInfo culture, string message)
        {
            return this.AssertFluent(() => Assert.AreEqual(expected, this.Actual, ignoreCase, culture, message));
        }

        public AndConstraint<ExpectString> ToEqual(
            string expected, bool ignoreCase, CultureInfo culture, string message, params object[] parameters)
        {
            return this.AssertFluent(() => Assert.AreEqual(expected, this.Actual, ignoreCase, culture, message, parameters));
        }

        public AndConstraint<ExpectString> ToContain(string substring)
        {
            return this.AssertFluent(() => StringAssert.Contains(this.Actual, substring));
        }

        public AndConstraint<ExpectString> ToEndWith(string substring)
        {
            return this.AssertFluent(() => StringAssert.EndsWith(this.Actual, substring));
        }

        public AndConstraint<ExpectString> ToStartWith(string substring)
        {
            return this.AssertFluent(() => StringAssert.StartsWith(this.Actual, substring));
        }

        public AndConstraint<ExpectString> ToMatch(Regex regex)
        {
            return this.AssertFluent(() => StringAssert.Matches(this.Actual, regex));
        }

        private AndConstraint<ExpectString> AssertFluent(Action assert)
        {
            assert.Invoke();

            return new AndConstraint<ExpectString>(this);
        }
    }
}
