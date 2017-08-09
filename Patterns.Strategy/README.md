# Strategy pattern

This pattern is used to create a family of interchangeable algorithms from which the required process is chosen at runtime.

## Partial type name role hint
This technique resolves a strategy using a naming convention. You agree on a naming convetion and you resolve stored strategies using a factory like method.

`ResponderSelector` has a list of candidates, `List<IResponder> _candidates`. You select a candidate from the `Select` method.

```
public IResponder Select(HttpStatusCode code)
{
    return (from item in _candidates
        let t = item.GetType()
        where t.Name.StartsWith(code.ToString(), StringComparison.InvariantCultureIgnoreCase)
        select item).Single();
}
```

The naming convention here is the status code enum. We create classes that start with the enum name, for example `OkResponder`, `NotFoundResponder` or `InternalServerErrorResponder`.

These classes implement the `IResponder` interface.

#### OkResponder
```
public class OkResponder: IResponder
{
    public string Content()
    {
        return "Ok_Result";
    }
}
```
Rest of the `IResponder`'s implement the Content method and return a result in the same way, just for the sake of simplicity over these samples.

#### Test
```
[TestCase(typeof(OkResponder), HttpStatusCode.OK, "Ok_Result")]
[TestCase(typeof(NotFoundResponder), HttpStatusCode.NotFound, "NotFound_Result")]
[TestCase(typeof(InternalServerErrorResponder), HttpStatusCode.InternalServerError, "InternalServerError_Result")]
public void ReturnsOkResponderForOkCode(Type type, HttpStatusCode code, string expected)
{
    // Arrange
    var selector = new ResponderSelector(_mocks);

    // Act
    var result = selector.Select(code);

    // Assert
    IsInstanceOf(type, result);
    AreEqual(expected, result.Content());
}

```