namespace MSTest.Fluent.Not
{
    using System;
    using System.Collections;

    using MSTest.Fluent.Expect;
    using MSTest.Fluent.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class NotCollection
    {
        private readonly ExpectCollection expect;

        public NotCollection(ExpectCollection expect)
        {
            this.expect = expect;
        }

        public AndConstraint<ExpectCollection> ToContain(object element)
        {
            return this.AssertFluent(() => CollectionAssert.DoesNotContain(this.expect.Actual, element));
        }

        public AndConstraint<ExpectCollection> ToBeSubsetOf(ICollection superset)
        {
            return this.AssertFluent(() => CollectionAssert.IsNotSubsetOf(this.expect.Actual, superset));
        }

        public AndConstraint<ExpectCollection> ToBeEquivalentTo(ICollection expected)
        {
            return this.AssertFluent(() => CollectionAssert.AreNotEquivalent(expected, this.expect.Actual));
        }

        public AndConstraint<ExpectCollection> ToEqual(ICollection expected)
        {
            return this.AssertFluent(() => CollectionAssert.AreNotEqual(expected, this.expect.Actual));
        }

        public AndConstraint<ExpectCollection> ToEqual(ICollection expected, IComparer comparer)
        {
            return this.AssertFluent(() => CollectionAssert.AreNotEqual(expected, this.expect.Actual, comparer));
        }

        private AndConstraint<ExpectCollection> AssertFluent(Action assert)
        {
            assert.Invoke();

            return new AndConstraint<ExpectCollection>(this.expect);
        }
    }
}
