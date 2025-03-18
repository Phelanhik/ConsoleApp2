using LearnDLL;


namespace Test1
{
    [TestFixture]
    public class Tests
    {


        [Test]
        public void Test1()
        {
            // Проверка функциональности метода по значениям в интервале от 0 до 255
            MainClass test = new MainClass(100);
            for (int i = 0; i <= 255; i++)
            {
                int result = test.GetDifference(i);
                Assert.That(result, Is.EqualTo(100-i));
            }



        }
    }
}