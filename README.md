# NPV Calculator

Calculate Net Present Value for given cashflows and series of rates base on the lower bound rate and lower bound rate and rate interval provided.

Calculating the net present values of the expected cashflows from two investments provides a way for projects to be compared with each other.

The phrase "present value" is about the fact that the value of money changes over time and so we need to be able to compare it across time. Note that future cashflows are often unknown in advance and so projects often need to be evaluated probabilistically.

Calculations
---
- Net Present Value 

### Prerequisite
---
- .Net Core 2.2
- .Net Framework 4.5 or later
- Asp.Net MVC 4 or later
- Visual Studio 2017 or later

Additional .Net Library 
---
- Financial.dll (Use to verify test results)

NUGet Packages
---
- Microst.VisualStudio.Web.CodeGeneration.Design 2.2.0
- BeginCollectionItemCore 1.0.8
- Mog 4.13.1
- AutoFixture.AutoMog 4.11.0
- XUnit.Runner.Console 2.4.0

JQuery Plugins
---
- jquery.canvasjs.min.js for Graph/Chart
- numeral.min.js
- jquery.npv.calculator.js custom JQuery plugins intended only for NPV Calculator

Optional Resource
---
- Postman for Desktop

Download and Running the solution
---
- clone repo
- Open the "NpvCalulatorSolution"
- In the "Solution Explorer", right click the solution file and select "Properties"
- In the "Pproperties Window", under "Startup Project" click the "Multiple startup projects"
- In the "Action" dropdown, Make sure to select from the "Start" for the "NpvCalulatorApp" and "NpvCalulatorApi" projects 
- Then click the "OK" button to save the changes.
- Press CTRL+F5 or control F5 to Run the "NpvCalulatorApp" and "NpvCalulatorApi"

Note: NpvCalculatorApi is configure to use port 9000 and NpvCalculatorApp is configure to use port 9001

xUnit Testing
---
- Navigate to the NpvCalculatorSolution\Unit Tests\NpvCalculator.Tests
- Once in the NpvCalculator.Tests folder Project folder, type "cmd" to open the command prompt
- In the command prompt, Type dotnet test NpvCalculator.Tests.csproj --loAgger "trx;LogFilename=testresults.trx" to run the test cases
- After the running the test checkout the test results file in the NpvCalculatorSolution\Unit Tests\NpvCalculator.Tests\TestResults
- Open the testresults.trx file in notepad.


Using Postman to test the API
---
- Download and Install the Postman Desktop app or use the Chrome Browser Extension
- Run the NpvCalculatorApi Project
- In Postman make a post request to the NpvCalculatorApi. 
  Use the Parameters below:
- Request Url : http://localhost:9001/api/npv/calculate
- Method : Postman
- Body Tab: Raw
- Json Data to post is provide below
NPV Jason Data (make changes if necessary)
{
	"lowerBoundRate"": 1,
	"upperBoundRate": 15,
	"rateIncrement": 0.25,
	"initialValue": 10000,
	"years": 10,
	"cashFlows": [
		{ "year": 1, "amount": 1000 },
		{ "year": 2, "amount": 1500 },
		{ "year": 3, "amount": 2000 },
		{ "year": 4, "amount": 2500 },
		{ "year": 5, "amount": 3000 },
		{ "year": 6, "amount": 3500 },
		{ "year": 7, "amount": 4000 },
		{ "year": 8, "amount": 4500 },
		{ "year": 9, "amount": 5000 },
		{ "year": 10,"amount": 5500 }
	],
	"npvResultItems": [],
	"messages": []
}  
  

