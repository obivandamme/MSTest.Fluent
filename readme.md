# MSTest.Fluent #

Provides a test base class that wraps MSTest assertions in an expect-syntax and provides a chaining mechanism for multiple assertions on the same object

## Features

- _MSTest.Fluent.TestBase_ class that holds the Expect-Method to start your fluent assertions
- Allows chaining of assertions using a fluent syntax

## Example

  public class MyTests : MSTest.Fluent.TestBase
  {
    [TestMethod]
    public void MyTest()
    {
      var actual = 5
      
      Expect(actual).ToEqual(5);
    }
  }