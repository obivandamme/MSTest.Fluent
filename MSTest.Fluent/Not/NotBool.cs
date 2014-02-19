namespace MSTest.Fluent.Not
{
    using System;

    using MSTest.Fluent.Expect;
    using MSTest.Fluent.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class NotBool
    {
        private readonly ExpectBool epect;

        public NotBool(ExpectBool epect)
        {
            this.epect = epect;
        }

        public AndConstraint<ExpectBool> ToBeTrue()
        {
            return this.AssertFluent(() => Assert.IsFalse(this.epect.Actual));
        }

        public AndConstraint<ExpectBool> ToBeTrue(string message)
        {
            return this.AssertFluent(() => Assert.IsFalse(this.epect.Actual, message));
        }

        public AndConstraint<ExpectBool> ToBeTrue(string message, params object[] parameters)
        {
            return this.AssertFluent(() => Assert.IsFalse(this.epect.Actual, message, parameters));
        }

        public AndConstraint<ExpectBool> ToBeFalse()
        {
            return this.AssertFluent(() => Assert.IsTrue(this.epect.Actual));
        }

        public AndConstraint<ExpectBool> ToBeFalse(string message)
        {
            return this.AssertFluent(() => Assert.IsTrue(this.epect.Actual, message));
        }

        public AndConstraint<ExpectBool> ToBeFalse(string message, params object[] parameters)
        {
            return this.AssertFluent(() => Assert.IsTrue(this.epect.Actual, message, parameters));
        }

        private AndConstraint<ExpectBool> AssertFluent(Action assert)
        {
            assert.Invoke();

            return new AndConstraint<ExpectBool>(this.epect);
        }
    }
}
