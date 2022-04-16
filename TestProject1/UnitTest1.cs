using NUnit.Framework;
using DummyApp;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1([Values(1,2,4)]int input)
        {
            //arrange
            // call method for processing
            // act
            string output = FizzBuzzer.Getvalue(input);


            //asert
            Assert.AreEqual(input.ToString(), output);

        }

        [Test]
        public void Test3()
        {
            //arrange
            int input = 3;
            // call method for processing
            // act
            string output = FizzBuzzer.Getvalue(input);


            //asert
            Assert.AreEqual("Fizz", output);

        }


        [Test]
        public void Test5()
        {
            //arrange
            int input = 5;
            // call method for processing
            // act
            string output = FizzBuzzer.Getvalue(input);


            //asert
            Assert.AreEqual("Fuzz", output);

        }



        [Test]
        public void Test3_5()
        {
            //arrange
            int input = 15;
            // call method for processing
            // act
            string output = FizzBuzzer.Getvalue(input);


            //asert
            Assert.AreEqual("FizzFuzz", output);

        }
    }
}