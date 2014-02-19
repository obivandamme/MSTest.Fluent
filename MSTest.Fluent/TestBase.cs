namespace MSTest.Fluent
{
    using System.Collections;

    using MSTest.Fluent.Expect;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public abstract class TestBase
    {
        protected ExpectBool Expect(bool actual)
        {
            return new ExpectBool(actual);
        }

        protected ExpectDouble Expect(double actual)
        {
            return new ExpectDouble(actual);
        }

        protected ExpectCollection Expect(ICollection actual)
        {
            return new ExpectCollection(actual);
        }

        protected ExpectFloat Expect(float actual)
        {
            return new ExpectFloat(actual);
        }

        protected ExpectObject Expect(object actual)
        {
            return new ExpectObject(actual);
        }

        protected ExpectString Expect(string actual)
        {
            return new ExpectString(actual);
        }

        protected void Failed()
        {
            Assert.Fail();
        }

        protected void IsInConclusive()
        {
            Assert.Inconclusive();
        }

        protected void ReplaceNullChars(string input)
        {
            Assert.ReplaceNullChars(input);
        }
    }
}
