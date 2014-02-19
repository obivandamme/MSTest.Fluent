namespace MSTest.Fluent.Expect
{
    using System;

    using MSTest.Fluent.Generic;
    using MSTest.Fluent.Not;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class ExpectBool
    {
        internal bool Actual { get; private set; }

        public NotBool Not { get; private set; }

        public ExpectBool(bool actual)
        {
            this.Actual = actual;
            this.Not = new NotBool(this);
        }

        public AndConstraint<ExpectBool> ToBeTrue()
        {
            return this.AssertFluent(() => Assert.IsTrue(this.Actual));
        }

        public AndConstraint<ExpectBool> ToBeTrue(string message)
        {
            return this.AssertFluent(() => Assert.IsTrue(this.Actual, message));
        }

        public AndConstraint<ExpectBool> ToBeTrue(string message, params object[] parameters)
        {
            return this.AssertFluent(() => Assert.IsTrue(this.Actual, message, parameters));
        }

        public AndConstraint<ExpectBool> ToBeFalse()
        {
            return this.AssertFluent(() => Assert.IsFalse(this.Actual));
        }

        public AndConstraint<ExpectBool> ToBeFalse(string message)
        {
            return this.AssertFluent(() => Assert.IsFalse(this.Actual, message));
        }

        public AndConstraint<ExpectBool> ToBeFalse(string message, params object[] parameters)
        {
            return this.AssertFluent(() => Assert.IsFalse(this.Actual, message, parameters));
        }

        private AndConstraint<ExpectBool> AssertFluent(Action assert)
        {
            assert.Invoke();

            return new AndConstraint<ExpectBool>(this);
        }
    }
}
