using LearnDLL;


namespace Test3
{
    [TestFixture]
    public class Tests
    {


        [Test]
        public void Test3()
        {
            // �������� ���������������� ������ �� ��������, �������� 0
            MainClass test = new MainClass(75);
            int result = test.GetDifference(-1);
            Assert.That(result, Is.EqualTo(255));

        }
    }
}