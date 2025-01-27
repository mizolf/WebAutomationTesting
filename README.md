# Web Automation Testing

This repository contains an automated web testing project developed as part of the Methods and Techniques for Software Testing course.

## Description

The project demonstrates the use of Selenium WebDriver for automating browser interactions, testing web applications, and ensuring software quality through systematic testing techniques.
It utilizes the C# programming language using NUnit testing framework and the Selenium WebDriver framework to automate testing scenarios for the website nabava.net.

The testing focuses on navigating through the website, interacting with dynamic elements, and validating key functionalities to ensure the site behaves as expected under various conditions.

## Getting Started

### Requirements
To run this project, ensure you have the following installed on your system:

* Visual Studio Code IDE
* C# programming language
* NUnit Framework: Installed via NuGet
* Selenium WebDriver: Installed via NuGet
* Browser: Google Chrome
* .NET SDK: Version 9.0 (or higher)
* ChromeDriver: Latest stable version matching your Google Chrome browser version

### Installing

1. Clone the Repository: 
```
git clone https://github.com/mizolf/WebAutomationTesting.git
cd WebAutomationTesting
```

2. Install NuGet Package Manager via VSCode Marketplace
   
3. Install required dependencies
* NUnit framework (3.13.3) 
* Selenium WebDriver (4.6.0)
* Selenium Support(4.6.0)
* Nunit3 Test Adapter (4.3.1)
* DotNetSeleniumExtras.WaitHelpers (3.11.0)

### Executing program

How to run the program

* Open project in VS Code
* In the terminal, navigate to the appropriate folder where the project is located and run:
```
dotnet test
```

### Test cases

* Login to page nabava.net
* Put an item in wishlist
* Navigate products price history
* Write comment on specific product
* Add and remove notification for product

## Authors

Mislav Češnik
