namespace SedolChecker
{
    public static class AppConfig
    {

        internal const string RegexPattern = "^([A-Z0-9]{6})\\d$";
        internal const int DigitStartAssci = 48; // ASCII CODE OF 0 is 48
        internal const int AlphaStartAssci = 65; // ASCII CODE OF A is 65
        internal const int MngAlphaStart = 10;  //(0-9 for Number , 10-35 for A-Z)
        internal const int SedolSize = 7;  //(0-9 for Number , 10-35 for A-Z)
        internal const int UserDefinedChar = 9;
        internal const int UserDefinedCharIndex = 0;


        internal const string InvalidInput = "Input string was not 7-characters long";
        internal const string InvalidChar = "SEDOL contains invalid characters";
        internal const string InvalidCheckSum = "Checksum digit does not agree with the rest of the input";

        internal static int[] SedolWeight = { 1, 3, 1, 7, 3, 9, 1 };// No of elements should be equal to SedolSize

        



    }
}
