namespace MSTest.Fluent.Expect
{
    using System;

    using MSTest.Fluent.Generic;
    using MSTest.Fluent.Not;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class ExpectDouble
    {
        internal double Actual { get; private set; }

        public NotDouble Not { get; private set; }

        public ExpectDouble(double actual)
        {
            this.Actual = actual;
            this.Not = new NotDouble(this);
        }

        public AndConstraint<ExpectDouble> ToEqual(double expected)
        {
            return this.AssertFluent(() => Assert.AreEqual(expected, this.Actual));
        }

        public AndConstraint<ExpectDouble> ToEqual(double expected, string message)
        {
            return this.AssertFluent(() => Assert.AreEqual(expected, this.Actual, message));
        }

        public AndConstraint<ExpectDouble> ToEqual(double expected, string message, params object[] parameters)
        {
            return this.AssertFluent(() => Assert.AreEqual(expected, this.Actual, message, parameters));
        }

        public AndConstraint<ExpectDouble> ToEqual(double expected, double delta)
        {
            return this.AssertFluent(() => Assert.AreEqual(expected, this.Actual, delta));
        }

        public AndConstraint<ExpectDouble> ToEqual(double expected, double delta, string message)
        {
            return this.AssertFluent(() => Assert.AreEqual(expected, this.Actual, delta, message));
        }

        public AndConstraint<ExpectDouble> ToEqual(double expected, double delta, string message, params object[] parameters)
        {
            return this.AssertFluent(() => Assert.AreEqual(expected, this.Actual, delta, message, parameters));
        }

        private AndConstraint<ExpectDouble> AssertFluent(Action assert)
        {
            assert.Invoke();

            return new AndConstraint<ExpectDouble>(this);
        }
    }
}
