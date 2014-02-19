namespace MSTest.Fluent.Not
{
    using System;

    using MSTest.Fluent.Expect;
    using MSTest.Fluent.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class NotObject
    {
        private readonly ExpectObject expect;

        public NotObject(ExpectObject expect)
        {
            this.expect = expect;
        }

        public AndConstraint<ExpectObject> ToEqual(object notExpected)
        {
            return this.AssertFluent(() => Assert.AreNotEqual(notExpected, this.expect.Actual));
        }

        public AndConstraint<ExpectObject> ToEqual(object notExpected, string message)
        {
            return this.AssertFluent(() => Assert.AreNotEqual(notExpected, this.expect.Actual, message));
        }

        public AndConstraint<ExpectObject> ToEqual(object notExpected, string message, params object[] parameters)
        {
            return this.AssertFluent(() => Assert.AreNotEqual(notExpected, this.expect.Actual, message, parameters));
        }

        public AndConstraint<ExpectObject> ToBeNull()
        {
            return this.AssertFluent(() => Assert.IsNotNull(this.expect.Actual));
        }

        public AndConstraint<ExpectObject> ToBeNull(string message)
        {
            return this.AssertFluent(() => Assert.IsNotNull(this.expect.Actual, message));
        }

        public AndConstraint<ExpectObject> ToBeNull(string message, params object[] parameters)
        {
            return this.AssertFluent(()=> Assert.IsNotNull(this.expect, message, parameters));
        }

        public AndConstraint<ExpectObject> ToBe(object notExpected)
        {
            return this.AssertFluent(() => Assert.AreNotSame(notExpected, this.expect.Actual));
        }

        public AndConstraint<ExpectObject> ToBe(object notExpected, string message)
        {
            return this.AssertFluent(() => Assert.AreNotSame(notExpected, this.expect.Actual, message));
        }

        public AndConstraint<ExpectObject> ToBe(object notExpected, string message, params object[] parameters)
        {
            return this.AssertFluent(() => Assert.AreNotSame(notExpected, this.expect, message, parameters));
        }

        public AndConstraint<ExpectObject> ToBeInstanceOfType(Type wrongType)
        {
            return this.AssertFluent(() => Assert.IsNotInstanceOfType(this.expect.Actual, wrongType));
        }

        public AndConstraint<ExpectObject> ToBeInstanceOfType(Type wrongType, string message)
        {
            return this.AssertFluent(() => Assert.IsNotInstanceOfType(this.expect, wrongType, message));
        }

        public AndConstraint<ExpectObject> ToBeInstanceOfType(Type wrongType, string message, params object[] parameters)
        {
            return this.AssertFluent(() => Assert.IsNotInstanceOfType(this.expect, wrongType, message, parameters));
        }

        private AndConstraint<ExpectObject> AssertFluent(Action assert)
        {
            assert.Invoke();

            return new AndConstraint<ExpectObject>(this.expect);
        }
    }
}
