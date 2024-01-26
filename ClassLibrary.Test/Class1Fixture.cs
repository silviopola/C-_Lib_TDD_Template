using NUnit.Framework;

namespace ClassLibrary.Test
{
    public class Class1Fixture
    {
        private readonly Class1 _class1;

        public Class1Fixture()
        {
            _class1 = new Class1();
        }

        [Test]
        public void Method1_returns_result()
        {
            var result = _class1.Method1(true);
            
            Assert.That(result, Is.EqualTo(true));
        }
    }
}
