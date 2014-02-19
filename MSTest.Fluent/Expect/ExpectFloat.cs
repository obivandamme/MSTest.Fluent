namespace MSTest.Fluent.Expect
{
    using System;

    using MSTest.Fluent.Generic;
    using MSTest.Fluent.Not;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class ExpectFloat
    {
        internal float Actual { get; private set; }

        public NotFloat Not { get; private set; }

        public ExpectFloat(float actual)
        {
            this.Actual = actual;
            this.Not = new NotFloat(this);
        }

        public AndConstraint<ExpectFloat> ToEqual(float expected)
        {
            return this.AssertFluent(() => Assert.AreEqual(expected, this.Actual));
        }

        public AndConstraint<ExpectFloat> ToEqual(float expected, string message)
        {
            return this.AssertFluent(() => Assert.AreEqual(expected, this.Actual, message));
        }

        public AndConstraint<ExpectFloat> ToEqual(float expected, string message, params object[] parameters)
        {
            return this.AssertFluent(() => Assert.AreEqual(expected, this.Actual, message, parameters));
        }

        public AndConstraint<ExpectFloat> ToEqual(float expected, float delta)
        {
            return this.AssertFluent(() => Assert.AreEqual(expected, this.Actual, delta));
        }

        public AndConstraint<ExpectFloat> ToEqual(float expected, float delta, string message)
        {
            return this.AssertFluent(() => Assert.AreEqual(expected, this.Actual, delta, message));
        }

        public AndConstraint<ExpectFloat> ToEqual(float expected, float delta, string message, params object[] parameters)
        {
            return this.AssertFluent(() => Assert.AreEqual(expected, this.Actual, delta, message, parameters));
        }

        private AndConstraint<ExpectFloat> AssertFluent(Action assert)
        {
            assert.Invoke();

            return new AndConstraint<ExpectFloat>(this);
        }
    }
}
