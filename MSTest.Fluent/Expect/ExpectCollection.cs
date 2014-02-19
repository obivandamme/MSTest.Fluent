namespace MSTest.Fluent.Expect
{
    using System;
    using System.Collections;

    using MSTest.Fluent.Generic;
    using MSTest.Fluent.Not;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class ExpectCollection
    {
        internal ICollection Actual { get; private set; }

        public NotCollection Not { get; private set; }

        public ExpectCollection(ICollection actual)
        {
            this.Actual = actual;
            this.Not = new NotCollection(this);
        }

        public AndConstraint<ExpectCollection> ToContain(object element)
        {
            return this.AssertFluent(() => CollectionAssert.Contains(this.Actual, element));
        }

        public AndConstraint<ExpectCollection> ToOnlyHaveUniqueItems()
        {
            return this.AssertFluent(() => CollectionAssert.AllItemsAreUnique(this.Actual));
        }

        public AndConstraint<ExpectCollection> ToOnlyHaveNotNullItems()
        {
            return this.AssertFluent(() => CollectionAssert.AllItemsAreNotNull(this.Actual));
        }

        public AndConstraint<ExpectCollection> ToBeSubsetOf(ICollection superset)
        {
            return this.AssertFluent(() => CollectionAssert.IsSubsetOf(this.Actual, superset));
        }

        public AndConstraint<ExpectCollection> ToBeEquivalentTo(ICollection expected)
        {
            return this.AssertFluent(() => CollectionAssert.AreEquivalent(expected, this.Actual));
        }

        public AndConstraint<ExpectCollection> ToOnlyHaveItemsOfType(Type expectedType)
        {
            return this.AssertFluent(() => CollectionAssert.AllItemsAreInstancesOfType(this.Actual, expectedType));
        }

        public AndConstraint<ExpectCollection> ToEqual(ICollection expected)
        {
            return this.AssertFluent(() => CollectionAssert.AreEqual(expected, this.Actual));
        }

        public AndConstraint<ExpectCollection> ToEqual(ICollection expected, IComparer comparer)
        {
            return this.AssertFluent(() => CollectionAssert.AreEqual(expected, this.Actual, comparer));
        }

        private AndConstraint<ExpectCollection> AssertFluent(Action assert)
        {
            assert.Invoke();

            return new AndConstraint<ExpectCollection>(this);
        }
    }
}
