namespace MSTest.Fluent.Not
{
    using System;
    using System.Globalization;
    using System.Text.RegularExpressions;

    using MSTest.Fluent.Expect;
    using MSTest.Fluent.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class NotString
    {
        private readonly ExpectString expect;

        public NotString(ExpectString expect)
        {
            this.expect = expect;
        }

        public AndConstraint<ExpectString> ToEqual(string notExpected)
        {
            return this.AssertFluent(() => Assert.AreNotEqual(notExpected, this.expect.Actual));
        }

        public AndConstraint<ExpectString> ToEqual(string notExpected, string message)
        {
            return this.AssertFluent(() => Assert.AreNotEqual(notExpected, this.expect.Actual, message));
        }

        public AndConstraint<ExpectString> ToEqual(string notExpected, string message, params object[] parameters)
        {
            return this.AssertFluent(() => Assert.AreNotEqual(notExpected, this.expect.Actual, message, parameters));
        }

        public AndConstraint<ExpectString> ToEqual(string notExpected, bool ignoreCase)
        {
            return this.AssertFluent(() => Assert.AreNotEqual(notExpected, this.expect.Actual, ignoreCase));
        }

        public AndConstraint<ExpectString> ToEqual(string notExpected, bool ignoreCase, string message)
        {
            return this.AssertFluent(() => Assert.AreNotEqual(notExpected, this.expect.Actual, ignoreCase, message));
        }

        public AndConstraint<ExpectString> ToEqual(string notExpected, bool ignoreCase, string message, params object[] parameters)
        {
            return this.AssertFluent(() => Assert.AreNotEqual(notExpected, this.expect.Actual, ignoreCase, message, parameters));
        }

        public AndConstraint<ExpectString> ToEqual(string notExpected, bool ignoreCase, CultureInfo culture)
        {
            return this.AssertFluent(() => Assert.AreNotEqual(notExpected, this.expect.Actual, ignoreCase, culture));
        }

        public AndConstraint<ExpectString> ToEqual(string notExpected, bool ignoreCase, CultureInfo culture, string message)
        {
            return this.AssertFluent(() => Assert.AreNotEqual(notExpected, this.expect.Actual, ignoreCase, culture, message));
        }

        public AndConstraint<ExpectString> ToEqual(string notExpected, bool ignoreCase, CultureInfo culture, string message, params object[] parameters)
        {
            return this.AssertFluent(() => Assert.AreNotEqual(notExpected, this.expect.Actual, ignoreCase, culture, message, parameters));
        }

        public AndConstraint<ExpectString> ToMatch(Regex regex)
        {
            return this.AssertFluent(() => StringAssert.DoesNotMatch(this.expect.Actual, regex));
        }

        private AndConstraint<ExpectString> AssertFluent(Action assert)
        {
            assert.Invoke();

            return new AndConstraint<ExpectString>(this.expect);
        } 
    }
}
