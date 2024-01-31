public static class Constant
{
    public static string firstName = "QA Test";
    public static string lastName = "TMA";
    public static string email = "qatest@yopmail.com";
    public static string phoneNumber = "(125) 255-5252";
    public static string businessName = "Data";
    public static string state = "Hawaii";
    public static string message = "Test input data";
   
    public static readonly List<string> AgencyList = [ "CCN-Enrolled, Not Serving Veterans", "CCN-Enrolled, Serving Veterans", "Not CCN-Enrolled", "Other" ];

    //Starter IPage message
    public const string mes_ContactMe = "I'd like to get setup with the VA or Paradigm";
    public const string mes_InvalidZipCpde = "Zip Code must be 5 digits";
    public const string mes_HelpText1 = "Discover VA Fee Schedules and Rates for your locality";
    public const string mes_HelpText2 = "Enter a 5-digit Zip Code to learn more about available Services and corresponding rates.";
    public const string mes_UnselectAuthorizationTypes = "Select one or more Authorization Types to see the available services.";
    public const string mes_NoServiceTypesAvailable = "There are no Service Types available for the selected Authorization Type and Zip Code. Select another Authorization Type or Zip Code.";
    //public const string mes_ClearZipCodeToBeInvalid = "Input a valid Zip Code to see the available services.";
    public const string mes_Thankyou = "Thank you! We will reach out to you soon!";
    public static readonly List<string> AuthorizationList = [ "Home Health Aide", 
        "In Home Respite","Skilled Home Health Care - Bundled", 
        "Skilled Home Health Care Expanded", "Community-Based Adult Health Care",
        "Community-Based Adult Health Care", "Caregiver Support Respite",
        "Skilled Home Health Care - Non Bundled"];

    //Initial values
    public static string ZipCode = "02886";
    public static string EmptyZipCode = " ";
    public static string InvalidZipCode = "1111";
    public static string ZipCodeHasUnvailableSerive = "11111";    
}