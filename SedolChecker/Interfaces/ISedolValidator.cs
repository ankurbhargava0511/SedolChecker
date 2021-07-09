

namespace SedolChecker.Interfaces
{

    /// <summary>
    /// Interface representing SEDOL validator.
    /// </summary>
    public interface ISedolValidator
    {
        /// <summary>
        /// Validates the SEDOL.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>Instance of validation result.</returns>
        public ISedolValidationResult ValidateSedol(string input);
    }
}
