Backend Test C# NUnit ExtentReports HttpClient Template Project

Overview

This project is a template for automating API testing using NUnit, HttpClient, and ExtentReports for generating detailed reports. The project is designed for .NET 8.0 and provides a structure for writing modular, scalable, and easily maintainable tests. The template uses NUnit as the testing framework, ExtentReports for reporting, and HttpClient for interacting with APIs.

Overview

This project template provides a framework to test backend APIs using C#. It integrates:

NUnit: Unit testing framework.

HttpClient: For sending HTTP requests and receiving responses from a web service.

ExtentReports: For generating customizable and detailed test reports.

Models: Objects representing the structure of data used in API requests and responses.


BackEnd_Tests/

│

├── Base/

│   └── TestSettings.cs       # Convert JSON data

├── Hooks/

│   └── Hook.cs               # Global setup/teardown for tests and ExtentReports management

│

├── Models/

│   └── ExampleModel.cs       # Example model class for API responses and requests

│

├── Util/

│   └── HttpClientExemples.cs # Contains HttpClient logic for API calls

│

├── Tests/

│   └── ExampleTests.cs       # Sample test class using NUnit and HttpClient

│

├── TestResults/              # Directory to store test reports and other outputs

│

├── appSettings.json/         # Data about Url used in project

│

└── BackEnd_Tests.csproj      # Project configuration and dependencies


Project Configuration

The project is pre-configured with all necessary dependencies in the .csproj file. Here's a breakdown of the key NuGet packages:


<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>

    <TargetFramework>net8.0</TargetFramework>
    
    <RootNamespace>BackEnd_Tests</RootNamespace>
    
    <ImplicitUsings>enable</ImplicitUsings>
    
    <Nullable>enable</Nullable>
    
    <IsPackable>false</IsPackable>
    
    <IsTestProject>true</IsTestProject>
  
  </PropertyGroup>
  <ItemGroup>
  
    <PackageReference Include="coverlet.collector" Version="6.0.0" />
    
    <PackageReference Include="ExtentReports" Version="4.1.0" />
    
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.8.0" />
    
    <PackageReference Include="NUnit" Version="3.14.0" />
    
    <PackageReference Include="NUnit.Analyzers" Version="3.9.0" />
    
    <PackageReference Include="NUnit3TestAdapter" Version="4.5.0" />
    
    <PackageReference Include="System.Configuration.ConfigurationManager" Version="8.0.0" />
  
  </ItemGroup>

  <ItemGroup>
  
    <Using Include="NUnit.Framework" />
  
  </ItemGroup>
</Project>

Conclusion

This template project sets up the foundation for API test automation using C#, NUnit, and HttpClient. ExtentReports provides a way to generate detailed and visually rich reports, making it easier to track test progress and results. The modular design ensures that the project is easy to maintain and scale.
