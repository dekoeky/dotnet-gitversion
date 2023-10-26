namespace library.tests;

[TestClass]
public class Feature2Tests
{
    [TestMethod]
    public void FeatureName()
    {
        //Arrange
        var feature = new Feature2() as IFeature;

        //Act
        var name = feature.Name;

        //Assert
        Assert.IsFalse(string.IsNullOrEmpty(name));
    }
}
