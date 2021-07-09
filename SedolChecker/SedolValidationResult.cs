using SedolChecker.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SedolChecker
{
    /// <summary>
    /// SEDOL Validation Result Concreate class 
    
    /// To string returns concatenate string as 
    /// </summary>
    public class SedolValidationResult : ISedolValidationResult
    {
        private readonly string _inputString;
        private readonly bool _isValidSedol;
        private readonly bool _isUserDefined;
        private readonly string _validationDetails;

        public SedolValidationResult(string inputString, bool isValidSedol, bool isUserDefined, string validationDetails)
        {
            _inputString = inputString;
            _isValidSedol = isValidSedol;
            _isUserDefined = isUserDefined;
            _validationDetails = validationDetails;
        }
        public string InputString => _inputString;
        public bool IsValidSedol => _isValidSedol;
        public bool IsUserDefined => _isUserDefined;
        public string ValidationDetails => _validationDetails;


        /// <summary>
        /// Override To String
        /// </summary>
        /// <value>
        /// InputString|IsValidSedol|IsUserDefined|ValidationDetails
        /// </value>
        public override string ToString()
        {
            string formatterResult = InputString switch
            {
                null => "Null",
                "" => "\"\"",
                _ => InputString,
            };
            formatterResult += "|" + IsValidSedol.ToString();

            formatterResult += "|" + IsUserDefined.ToString();

            formatterResult += "|" + (ValidationDetails ?? "Null");

            return formatterResult;
        }
    }
}
