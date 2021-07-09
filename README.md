This is the documentation for SedolChecker Solution
Solution Include three Projects - library SedolChecker, Sample Console Application and Unit test
- Sedol Checker- Sedol Checker is a class library coded in .net core 3.1 LTE using Visual Studio 2019 Editor. 
- Please install .net core 3.1 related library to run the package
- Code can be deployed as a nuget package for other Application for reuse
- Run code as Run= Runner(var validator =new SedolValidator());  var returnValue = validator.ValidateSedol(input);
- return value is of type  ISedolValidationResult 
- return value To string is overide to return Concatenate string as InputString|IsValidSedol|IsUserDefined|ValidationDetails
- For sample run refer SedolCheckerSampleRunner
- Test project is Written using Nunit 


 