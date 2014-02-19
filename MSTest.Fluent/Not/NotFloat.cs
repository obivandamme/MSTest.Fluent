namespace MSTest.Fluent.Not
{
    using System;

    using MSTest.Fluent.Expect;
    using MSTest.Fluent.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class NotFloat
    {
        private readonly ExpectFloat expect;

        public NotFloat(ExpectFloat expect)
        {
            this.expect = expect;
        }

        public AndConstraint<ExpectFloat> ToEqual(float notExpected)
        {
            return this.AssertFluent(() => Assert.AreNotEqual(notExpected, this.expect.Actual));
        }

        public AndConstraint<ExpectFloat> ToEqual(float notExpected, string message)
        {
            return this.AssertFluent(() => Assert.AreNotEqual(notExpected, this.expect.Actual, message));
        }

        public AndConstraint<ExpectFloat> ToEqual(float notExpected, string message, params object[] parameters)
        {
            return this.AssertFluent(() => Assert.AreNotEqual(notExpected, this.expect.Actual, message, parameters));
        }

        public AndConstraint<ExpectFloat> ToEqual(float notExpected, float delta)
        {
            return this.AssertFluent(() => Assert.AreNotEqual(notExpected, this.expect.Actual, delta));
        }

        public AndConstraint<ExpectFloat> ToEqual(float notExpected, float delta, string message)
        {
            return this.AssertFluent(() => Assert.AreNotEqual(notExpected, this.expect.Actual, delta, message));
        }

        public AndConstraint<ExpectFloat> ToEqual(float notExpected, float delta, string message, params object[] parameters)
        {
            return this.AssertFluent(() => Assert.AreNotEqual(notExpected, this.expect.Actual, delta, message, parameters));
        }

        private AndConstraint<ExpectFloat> AssertFluent(Action assert)
        {
            assert.Invoke();

            return new AndConstraint<ExpectFloat>(this.expect);
        }
    }
}
