# SeleniumHomework

I used the following combination for BDD testing:
|Type               | Name|
| ------------- | ------------- |
|IDE                | Visual Studio 2019|
|BDD Interpreter	   |    SpecFlow|
|Automation API	   |    WebDriver|
|Testing Framework  |	NUnit|
|Browser            |    Google Chrome 87.0.4280.88|
|WebDriver          |    ChromeDriver 87.0.4280.88|

I didn't implement POM.<br/>  
There are 5 features to be tested. 4 of them are working. "ContactUs" do not.<br/>  
8 tests passed. 2 tests didn't.<br/>
ContactUs: I made automatic filling with test info for all required fields (https://www.epam.com/about/who-we-are/contact) exept "HOW DID YOU HEAR ABOUT EPAM?". 
Here i have some troubles.<br/>

Here are all the packages i used 

|Id                                |  Versions                |                 ProjectName  |                                                                              
|--                                |  --------                |                 -----------  |                                                                              
|BoDi                             |   {1.4.1}                |                  Laba        |                                                                               
|Cucumber.Messages                |   {6.0.1}                |                  Laba        |                                                                              
|Gherkin                          |   {6.0.0}                |                  Laba        |                                                                             
|Google.Protobuf                  |   {3.7.0}                |                 Laba         |                                                                              
|NUnit                            |   {3.12.0}               |                  Laba        |                                                                              
|NUnit3TestAdapter                |   {3.17.0}               |                  Laba        |                                                                              
|Selenium.Support                 |   {3.141.0}              |                  Laba        |                                                                               
|Selenium.WebDriver               |   {3.141.0}              |                  Laba        |                                                                               
|SpecFlow                         |   {3.5.14}               |                  Laba        |                                                                               
|SpecFlow.NUnit                   |   {3.5.14}               |                  Laba        |                                                                               
|SpecFlow.Tools.MsBuild.Generation |   {3.5.14}               |                  Laba        |                                                                               
|System.Reflection.Emit            |  {4.3.0}                |                  Laba        |                                                                               
|System.Reflection.Emit.Lightweight | {4.3.0}                |                  Laba        |                                                                               
|System.Threading.Tasks.Extensions  | {4.4.0}                |                  Laba        |                                                                               
|System.ValueTuple                  | {4.4.0}                |                  Laba        |                                                                              
|Utf8Json                           | {1.3.7}                |                  Laba        |               

<br/>
Run my tests via VS2019: Test->Test Explorer<br/>
