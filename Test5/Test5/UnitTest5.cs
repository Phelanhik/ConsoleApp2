using LearnDLL;


namespace Test5
{
    [TestFixture]
    public class Tests
    {


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