namespace MSTest.Fluent.Expect
{
    using System;

    using MSTest.Fluent.Generic;
    using MSTest.Fluent.Not;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class ExpectObject
    {
        internal object Actual { get; private set; }

        public NotObject Not { get; private set; }

        public ExpectObject(object actual)
        {
            this.Actual = actual;
            this.Not = new NotObject(this);
        }

        public AndConstraint<ExpectObject> ToEqual(object expected)
        {
            return this.AssertFluent(() => Assert.AreEqual(expected, this.Actual));
        }

        public AndConstraint<ExpectObject> ToEqual(object expected, string message)
        {
            return this.AssertFluent(() => Assert.AreEqual(expected, this.Actual, message));
        }

        public AndConstraint<ExpectObject> ToEqual(object expected, string message, params object[] parameters)
        {
            return this.AssertFluent(() => Assert.AreEqual(expected, this.Actual, message, parameters));
        }

        public AndConstraint<ExpectObject> ToBe(object expected)
        {
            return this.AssertFluent(() => Assert.AreSame(expected, this.Actual));
        }

        public AndConstraint<ExpectObject> ToBe(object expected, string message)
        {
            return this.AssertFluent(() => Assert.AreSame(expected, this.Actual, message));
        }

        public AndConstraint<ExpectObject> ToBe(object expected, string message, params object[] parameters)
        {
            return this.AssertFluent(() => Assert.AreSame(expected, this.Actual, message, parameters));
        }

        public AndConstraint<ExpectObject> ToBeNull()
        {
            return this.AssertFluent(() => Assert.IsNull(this.Actual));
        }

        public AndConstraint<ExpectObject> ToBeNull(string message)
        {
            return this.AssertFluent(() => Assert.IsNull(this.Actual, message));
        }

        public AndConstraint<ExpectObject> ToBeNull(string message, params object[] parameters)
        {
            return this.AssertFluent(() => Assert.IsNull(this.Actual, message, parameters));
        }

        public AndConstraint<ExpectObject> ToBeInstanceOfType(Type expectedType)
        {
            return this.AssertFluent(() => Assert.IsInstanceOfType(this.Actual, expectedType));
        }

        public AndConstraint<ExpectObject> ToBeInstanceOfType(Type expectedType, string message)
        {
            return this.AssertFluent(() => Assert.IsInstanceOfType(this.Actual, expectedType, message));
        }

        public AndConstraint<ExpectObject> ToBeInstanceOfType(Type expectedType, string message, params object[] parameters)
        {
            return this.AssertFluent(() => Assert.IsInstanceOfType(this.Actual, expectedType, message, parameters));
        }

        private AndConstraint<ExpectObject> AssertFluent(Action assert)
        {
            assert.Invoke();

            return new AndConstraint<ExpectObject>(this);
        }
    }
}
