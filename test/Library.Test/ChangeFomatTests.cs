using NUnit.Framework;
using Library;

namespace DateFormat
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void ChangeFormatDateTest() // Testeamos que una fecha con el formato necesario previo a cambiar el formato,
                                           // efectivamente se cambia su formato.
        {
            string testDate = "10/11/1977";
            Assert.AreEqual("1977-11-10", ChangeFormat.ChangeTheFormat(testDate));
        }
    }
}