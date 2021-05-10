using Microsoft.VisualStudio.TestTools.UnitTesting;
using AttributeTestApp;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod("���ϱ� �׽�Ʈ")]
        public void TestMethod1()
        {
            MyClass myClass = new MyClass();
            int a = 3;
            int b = 5;
            var result = myClass.Plus(a,b);

            Assert.AreEqual(8, result); // �׽�Ʈ ���
        }

        [TestMethod("������ �׽�Ʈ")]
        public void PrintTest()
        {
            MyClass myClass = new MyClass();
            int a = 10, b = 3;
            var result = myClass.Divide(a, b);
            var expected = 3;
            Assert.AreEqual(expected, result);
        }
    }
}
