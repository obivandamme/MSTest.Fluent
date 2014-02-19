namespace MSTest.Fluent.Not
{
    using System;

    using MSTest.Fluent.Expect;
    using MSTest.Fluent.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class NotDouble
    {
        private readonly ExpectDouble expect;

        public NotDouble(ExpectDouble actual)
        {
            this.expect = actual;
        }

        public AndConstraint<ExpectDouble> ToEqual(double notExpected)
        {
            return this.AssertFluent(() => Assert.AreNotEqual(notExpected, this.expect.Actual));
        }

        public AndConstraint<ExpectDouble> ToEqual(double notExpected, string message)
        {
            return this.AssertFluent(() => Assert.AreNotEqual(notExpected, this.expect.Actual, message));
        }

        public AndConstraint<ExpectDouble> ToEqual(double notExpected, string message, params object[] parameters)
        {
            return this.AssertFluent(() => Assert.AreNotEqual(notExpected, this.expect.Actual, message, parameters));
        }

        public AndConstraint<ExpectDouble> ToEqual(double notExpected, double delta)
        {
            return this.AssertFluent(() => Assert.AreNotEqual(notExpected, this.expect.Actual, delta));
        }

        public AndConstraint<ExpectDouble> ToEqual(double notExpected, double delta, string message)
        {
            return this.AssertFluent(() => Assert.AreNotEqual(notExpected, this.expect.Actual, delta, message));
        }

        public AndConstraint<ExpectDouble> ToEqual(double notExpected, double delta, string message, params object[] parameters)
        {
            return this.AssertFluent(() => Assert.AreNotEqual(notExpected, this.expect.Actual, delta, message, parameters));
        }

        private AndConstraint<ExpectDouble> AssertFluent(Action assert)
        {
            assert.Invoke();

            return new AndConstraint<ExpectDouble>(this.expect);
        }
    }
}
