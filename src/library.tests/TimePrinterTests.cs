namespace library.tests;

[TestClass]
public class TimePrinterTests
{
    [DataTestMethod]
    [DataRow(DateTimeKind.Local)]
    [DataRow(DateTimeKind.Utc)]
    public void ConstructorWithValidParameters(DateTimeKind kind)
    {
        //Arrange

        //Act
        var timePrinter = new TimePrinter(kind);

        //Assert
        Assert.IsNotNull(timePrinter);
    }

    [DataTestMethod]
    [DataRow(DateTimeKind.Unspecified)]
    [ExpectedException(typeof(ArgumentException))]
    public void ConstructorWithInvalidParameters(DateTimeKind kind)
    {
        //Arrange

        //Act
        var timePrinter = new TimePrinter(kind);

        //Assert
        Assert.Fail();
    }
}