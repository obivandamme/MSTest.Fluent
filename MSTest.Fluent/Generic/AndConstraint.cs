namespace MSTest.Fluent.Generic
{
    public class AndConstraint<T>
    {
        private readonly T expect;

        public AndConstraint(T expect)
        {
            this.expect = expect;
        }

        public T And
        {
            get
            {
                return this.expect;
            }
        }
    }
}
