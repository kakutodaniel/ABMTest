# ABM Data Project

## Solution

That solution has 4 projects as following:
`1. Parse Project`
* Console Application which, given the EDIFACT message text, parse out all `LOC` segments and populate an array with `2nd` and `3rd` element of each segment.
* The `Edifact class` is where is the business rule. To instantiate it you must input a parameter, the `message text`, which will be parsed.
* There is a method called `GetSecondAndThirdElements` receiving `2 parameters`. The first is the `delimiter (+)` and the second is the `segment name (loc)`  
* To check the result, it's necessary to debug and add a breakpoint on the method called.

`2. XML Project`
* Console Application which, given the XML Document, extract the `RefText` values for the `RefCodes` informed 
* The `ExtractValues class`is where is the business rule.  To instantiate it you must input a parameter, a valid `XML Document`, which will be parsed.
* There is a method called `ExtractTextFromCodes`receiving `1 parameter` which is an array with which `RefCodes` will be searched.
* The result will be shown on the screen.

`3. WebService Project`
* `Webservice` with a method called `CheckXML`which get a `XMLDocument` as parameter. That method will respond with a status code based on the following:  
1. If the XML document is given here is passed then return a status of ‘0’ – which means the document was structured correctly.
2. If the Declararation’s Command <> ‘DEFAULT’ then return ‘-1’ – which means invalid command specified.
3. If the SiteID <> ‘DUB’ then return ‘-2’ – invalid Site specified.
* To perform a test, it's necessary to use the `WebService Test Project`.

`4. WebService Test Project`
* Project which test the webservice above. 
* To be able to run the tests, it's necessary run the `Webservice Project`. First set the `Webservice project as Startup project` and then click `Ctrl+F5`to run the webservice in background.
*  Go back to the Test project and, in `Connected Services`, notice that there is a `ws folder`.  Click right button on the folder and then `Update Service Reference` (That will update the webservice).
* There is a class called `WebServiceTest` with 3 test scenarios . To execute, click right button inside a method and then `Debug Tests`.
* It's possible change the xml in the `_payload` variable. 


## Technologies Used

1. Visual Studio 2017
2. .NET Framework 4.6.1
3. Unit Test Project


## Author

Daniel Kakuto (kakutodaniel@hotmail.com)

