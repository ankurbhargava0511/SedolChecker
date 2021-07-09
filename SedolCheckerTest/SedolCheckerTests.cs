using NUnit.Framework;
using SedolChecker;

namespace SedolCheckerTests
{

    public class SedolCheckerTests
    {
        [Test]
        public void SedolCheckerNullStringTest()
        {
            string input = null;
            string result = "Null|False|False|Input string was not 7-characters long";
            SedolValidator validator = new SedolValidator();
            Assert.AreEqual(validator.ValidateSedol(input).ToString(), result);

        }


        [Test]
        public void SedolCheckerEmptyStringTest()
        {
            string input = string.Empty;
            string result = "\"\"|False|False|Input string was not 7-characters long";
            SedolValidator validator = new SedolValidator();
            Assert.AreEqual(validator.ValidateSedol(input).ToString(), result);

        }

        [Test]
        public void SedolCheckerStringLengthLessTest()
        {
            string input = "12";
            string result = "12|False|False|Input string was not 7-characters long";
            SedolValidator validator = new SedolValidator();
            Assert.AreEqual(validator.ValidateSedol(input).ToString(), result);
        }

        [Test]
        public void SedolCheckerStringLengthMoreTest()
        {
            string input = "123456789";
            string result = "123456789|False|False|Input string was not 7-characters long";
            SedolValidator validator = new SedolValidator();
            Assert.AreEqual(validator.ValidateSedol(input).ToString(), result);


        }

        [Test]
        public void InvalidChecksumNonUserDefinedSEDOLTest()
        {


            string input = "1234567";
            string result = "1234567|False|False|Checksum digit does not agree with the rest of the input";
            SedolValidator validator = new SedolValidator();
            Assert.AreEqual(validator.ValidateSedol(input).ToString(), result);
        }

        [Test]
        public void ValidNonUserdefineSEDOLNumericTest()
        {

            string input = "0709954";
            string result = "0709954|True|False|Null";
            SedolValidator validator = new SedolValidator();
            Assert.AreEqual(validator.ValidateSedol(input).ToString(), result);

        }

        [Test]
        public void ValidNonUserDefineSEDOLAlphaNumericTest()
        {

            string input = "B0YBKJ7";
            string result = "B0YBKJ7|True|False|Null";
            SedolValidator validator = new SedolValidator();
            Assert.AreEqual(validator.ValidateSedol(input).ToString(), result);

        }


        [Test]
        public void InvalidCheckSumUserDefinedSEDOLNumericTest()
        {




            string input = "9123451";
            string result = "9123451|False|True|Checksum digit does not agree with the rest of the input";
            SedolValidator validator = new SedolValidator();
            Assert.AreEqual(validator.ValidateSedol(input).ToString(), result);
        }
        [Test]
        public void InvalidCheckSumUserDefinedSEDOLAlphaNumericTest()
        {
            string input = "9ABCDE8";
            string result = "9ABCDE8|False|True|Checksum digit does not agree with the rest of the input";
            SedolValidator validator = new SedolValidator();
            Assert.AreEqual(validator.ValidateSedol(input).ToString(), result);

        }

        [Test]
        public void InvaidCharactersFoundNumericTest()
        {

            string input = "9123_51";
            string result = "9123_51|False|False|SEDOL contains invalid characters";
            SedolValidator validator = new SedolValidator();
            Assert.AreEqual(validator.ValidateSedol(input).ToString(), result);


        }
        [Test]
        public void InvaidCharactersFoundAlphaNumericTest()
        {
            string input = "VA.CDE8";
            string result = "VA.CDE8|False|False|SEDOL contains invalid characters";
            SedolValidator validator = new SedolValidator();
            Assert.AreEqual(validator.ValidateSedol(input).ToString(), result);


        }

        [Test]
        public void InvaidCharactersLastCharacterIsNotDigit()
        {

            
            string input = "ABCDEFG";
            string result = "ABCDEFG|False|False|SEDOL contains invalid characters";
            SedolValidator validator = new SedolValidator();
            Assert.AreEqual(validator.ValidateSedol(input).ToString(), result);


        }

        [Test]
        public void ValidUserDefinedSEDOLNumericTest()
        {

            string input = "9123458";
            string result = "9123458|True|True|Null";
            SedolValidator validator = new SedolValidator();
            Assert.AreEqual(validator.ValidateSedol(input).ToString(), result);

        }
        [Test]
        public void ValidUserDefinedSEDOLAlphaNumericTest()
        {

            string input = "9ABCDE1";
            string result = "9ABCDE1|True|True|Null";
            SedolValidator validator = new SedolValidator();
            Assert.AreEqual(validator.ValidateSedol(input).ToString(), result);


        }

    }
}
