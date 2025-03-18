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
                Assert.That(result, Is.EqualTo(100 - i));
            }
        }

        [Test]
        public void Test2()
        {
            // Проверка функциональности метода по значению, большему 255
            MainClass test = new MainClass(25);
            int result = test.GetDifference(256);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Test3()
        {
            // Проверка функциональности метода по значению, меньшему 0
            MainClass test = new MainClass(75);
            int result = test.GetDifference(-1);
            Assert.That(result, Is.EqualTo(255));
        }

        [Test]
        public void Test4()
        {
            // Проверка правильности создания класса при попадании в интервал от 0 до 255
            MainClass test = new MainClass(100);
        }

        [Test]
        public void Test5()
        {
            // Проверка правильности создания класса при значениях меньше или больше допустимого интервала
            try
            {
                MainClass test = new MainClass(-1);
                Assert.Fail("Ожидалось исключение, но оно не было вызвано");
            }

            catch (Exception)
            {
                Assert.Pass();
            }
            try
            {
                MainClass test = new MainClass(256);
                Assert.Fail("Ожидалось исключение, но оно не было вызвано");
            }
            catch (Exception)
            {
                Assert.Pass();
            }
        }
    }
}