using LearnDLL;


namespace Test2
{
    [TestFixture]
    public class Tests
    {


        [Test]
        public void Test2()
        {
            // Проверка функциональности метода по значению, большему 255
            MainClass test = new MainClass(25);
            int result = test.GetDifference(256);
            Assert.That(result, Is.EqualTo(0));

        }
    }
}