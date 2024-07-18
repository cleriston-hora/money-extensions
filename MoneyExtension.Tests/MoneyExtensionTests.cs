namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void Deve_Converter_Decimal_para_Inteiro()
    {
        decimal valor = 279.98M;

        var ret = valor.ToCents();

        Assert.AreEqual(27998, ret);
    }
}