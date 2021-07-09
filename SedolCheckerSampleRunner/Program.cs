using SedolChecker.Interfaces;
using SedolChecker;
using System;

namespace SedolCheckerSampleRunner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = "1234567";

            Console.WriteLine("InputString Test Value|IsValidSedol|IsUserDefined|ValidationDetails");
            ISedolValidator validator = new SedolChecker.SedolValidator();
            var returnValue = validator.ValidateSedol(input);


            Console.WriteLine(returnValue.ToString());

        }

       
    }
}
