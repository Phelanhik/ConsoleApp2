using LearnDLL;


namespace Test5
{
    [TestFixture]
    public class Tests
    {


        [Test]
        public void Test5()
        {
            // �������� ������������ �������� ������ ��� ��������� ������ ��� ������ ����������� ���������
            try
            {
                MainClass test = new MainClass(-1);
                Assert.Fail("��������� ����������, �� ��� �� ���� �������");
            }

            catch (Exception)
            {
                Assert.Pass();
            }

            try
            {
                MainClass test = new MainClass(256);
                Assert.Fail("��������� ����������, �� ��� �� ���� �������");
            }
            catch (Exception)
            {
                Assert.Pass();
            }
        }
    }
}