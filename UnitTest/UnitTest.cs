using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TestNUnit;

namespace UnitTest
{
    [TestFixture]
    public class NUnit
    {
        MyTest test = null;
        [SetUp]
        public void Initialize()
        {
            test = new MyTest();
        }
        [TearDown]
        public void CleanUp()
        {
            test = null;
        }
        [Test]
        public void Addition()
        {
            Assert.AreEqual(5, test.Add(2, 3));
        }
        [Test]
        [Ignore("Ignore a Test")]
        public void Substraction()
        {
            Assert.AreEqual(0, test.Substract(2, 2));

        }
        [TestCase(3, Description = "Teste de Divis�o")]
        [TestCase(1,Description = "Teste de Divis�o")]
        [TestCase(0, Description = "Teste de Divis�o por Zero",ExpectedException = typeof(DivideByZeroException))]
        public void Divide(int divid)
        {
            Assert.AreEqual(1, test.Devide(3, divid));
        }

        [Test(Description = "Multiplica��o")]
        public void Multiply()
        {
            Assert.AreEqual(4, test.Multiply(2, 2));
        }

        [Category("Iteration2")]
        [Test(Description = "Teste de Fun��o")]
        public void Function()
        {
            Assert.AreEqual(8,test.Function(4,2));
        }
    }
}