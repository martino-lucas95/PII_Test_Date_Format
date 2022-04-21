using NUnit.Framework;


namespace Tests
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
            // this.person = new Person("Lucas Martino", "1.234.567-8");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
            // const string expected = " ";
            // Assert.IsNotEmpty(expected, person.Name);
        }

        [Test]
        public void Test2()
        {
            // const string expected = "4.658.761-8";
            // Assert.IsNotNull(expected, person.ID);
        }
    }
}