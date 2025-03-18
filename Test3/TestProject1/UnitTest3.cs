using LearnDLL;


namespace Test3
{
    [TestFixture]
    public class Tests
    {


        [Test]
        public void Test3()
        {
            // Проверка функциональности метода по значению, меньшему 0
            MainClass test = new MainClass(75);
            int result = test.GetDifference(-1);
            Assert.That(result, Is.EqualTo(255));

        }
    }
}