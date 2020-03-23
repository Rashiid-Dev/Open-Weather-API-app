# Open Weather API app

> Created By Abdirashiid Jama

## About

this app allows you to make calls to the Open Weather API and get the latest forecast for your city and location

## To Run

### You will need:
- [Visual Studio](https://visualstudio.microsoft.com/downloads/)







#### and dependencies:

- [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/12.0.3?_src=template)
- [NUnit](https://www.nuget.org/packages/NUnit/3.12.0?_src=template)
- [NUnit3TestAdapter](https://www.nuget.org/packages/NUnit3TestAdapter/3.16.1?_src=template)
- [RestSharp](https://www.nuget.org/packages/RestSharp/106.10.1?_src=template)

### Getting Ready
1. Install Visual Studio 2019
2. Clone this repository
3. Open the solution and Install packages and dependencies in NuGet Package Manager


### How to use the program

- ServiceTest Folder 
- - WeatherLatestTests.cs - Contains tests that test the returned data
- WeatherLatestService folder - Contains all the code that makes calls to the API
- - DataHandling Folder 
- - - LatestWeatherModel.cs - Contains the model based up the JSON output
- - - OpenWeatherLatest.cs - Deserializes the response
- - HTTPManager Folder
- - - OpenWeatherCallManager.cs - Handles the calls made to the API
- - WeatherLatestForecastService.cs - Contains several methods that return the data
- app.config - containts in XML format variables that make up the URI
- AppConfigReader.cs - Binds the xml variables to C# variables

### Continue to develop this program
You can continue to develop this program by adding more methods to the WeatherLatestForecastService.cs to return more responses and add tests to the WeatherLatestTests.cs file to test those new methods

