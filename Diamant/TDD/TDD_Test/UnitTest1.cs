using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;


namespace TDD_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Fizzbuzz_retourne_fizz_si_3_en_entrée()
        {
            //arrange
            var fizzbuzz = new PratiqueFizzBuzz();
            string resultatFizzbuzzz;

            //act
            resultatFizzbuzzz = fizzbuzz.FizzBuzz(3);

            //assert
            Assert.AreEqual("fizz", resultatFizzbuzzz);

        }


        [TestMethod]
        public void Fizzbuzz_retourne_buzz_si_5_en_entrée()
        {
            //arrange
            var fizzbuzz = new PratiqueFizzBuzz();
            string resultatFizzbuzzz;

            //act
            resultatFizzbuzzz = fizzbuzz.FizzBuzz(5);

            //assert
            Assert.AreEqual("buzz", resultatFizzbuzzz);
        }

        [TestMethod]
        public void Fizzbuzz_retourne_fizz_si_9_en_entrée()
        {
            //arrange
            var fizzbuzz = new PratiqueFizzBuzz();
            string resultatFizzbuzzz;

            //act
            resultatFizzbuzzz = fizzbuzz.FizzBuzz(9);

            //assert
            Assert.AreEqual("fizz", resultatFizzbuzzz);
        }
        
        [TestMethod]
        public void Fizzbuzz_retourne_buzz_si_10_en_entrée()
        {
            //arrange
            var fizzbuzz = new PratiqueFizzBuzz();
            string resultatFizzbuzzz;

            //act
            resultatFizzbuzzz = fizzbuzz.FizzBuzz(10);

            //assert
            Assert.AreEqual("buzz", resultatFizzbuzzz);
        }

        [TestMethod]
        public void Fizzbuzz_retourne_fizzbuzz_si_15_en_entrée()
        {
            //arrange
            var fizzbuzz = new PratiqueFizzBuzz();
            string resultatFizzbuzzz;

            //act
            resultatFizzbuzzz = fizzbuzz.FizzBuzz(15);

            //assert
            Assert.AreEqual("fizzbuzz", resultatFizzbuzzz);
        }
    }
}
