using SedolChecker.Interfaces;
using System;
using System.Text.RegularExpressions;

namespace SedolChecker
{
    public class SedolValidator : ISedolValidator
    {
        private static readonly Regex Pattern = new Regex(AppConfig.RegexPattern, RegexOptions.Compiled);

        /// <summary>
        /// Validates the SEDOL.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>Instance of ISedolValidationResult result.</returns>
        public ISedolValidationResult ValidateSedol(string input)
        {
            if (string.IsNullOrWhiteSpace(input) || input.Length != AppConfig.SedolSize)
                return new SedolValidationResult(input, false, false, AppConfig.InvalidInput);
           
            if (!Pattern.IsMatch(input))
                return new SedolValidationResult(input, false, false, AppConfig.InvalidChar);

            //TODO if weight and string size need to be configurable validate if sedolsize equal to SedolWeight Grid

            var isUserDefine = IsUserDefined(input);

            var isvalid = IsCheckSumValid(input);

            return new SedolValidationResult(input, isvalid, isUserDefine, !isvalid ? AppConfig.InvalidCheckSum : null);

        }

        private bool IsCheckSumValid(string input)
        {
            var sum = 0;
            for (int i = 0; i < input.Length; i++)
                if (!Char.IsDigit(input[i]))
                    sum += (((int)input[i] - AppConfig.AlphaStartAssci + AppConfig.MngAlphaStart) * AppConfig.SedolWeight[i]);
                else
                    sum += (((int)input[i] - AppConfig.DigitStartAssci) * AppConfig.SedolWeight[i]);
            return sum % 10 == 0;
        }

        private bool IsUserDefined(string input)
        {
            return (
                Char.IsDigit(input[AppConfig.UserDefinedCharIndex]) && 
                ((int)input[AppConfig.UserDefinedCharIndex] - AppConfig.DigitStartAssci) == AppConfig.UserDefinedChar);
        }


    }


}
