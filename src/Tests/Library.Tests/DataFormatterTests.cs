using TestDateFormat;
namespace Library.Tests;


public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ChangeFormatTest1()
    {
        string fechaPrueba = "22/08/2003";
        string fechaCambiada = DateFormatter.ChangeFormat(fechaPrueba);
        Assert.AreEqual(fechaCambiada, "2003-08-22");
    }

    [Test]
        public void ChangeFormatTest2()
    {
        string fechaPrueba = "";
        string fechaCambiada = DateFormatter.ChangeFormat(fechaPrueba);
        Assert.AreEqual(fechaCambiada, "");
    }

    [Test]
        public void ChangeFormatTest3()
    {
        string fechaPrueba = "22/2003/08";
        string fechaCambiada = DateFormatter.ChangeFormat(fechaPrueba);
        Assert.AreEqual(fechaCambiada, "Formato invalido.");
    }
}