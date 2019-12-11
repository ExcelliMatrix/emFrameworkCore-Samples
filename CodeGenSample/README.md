# emFrameworkCore-Samples / CodeGenSample
CodeGenSample is a full three tiered architecture example used to demonstrate the use of T4 templates with the emFrameworkCode.CodeGen code generation framework.

## Overview
The three tiers demonstrated in this sample include
- Web-Tier
  A public facing web project that is an intermediary between the internet and the business functionality implemented within the App-Tier.
- App-Tier
  A architectural tier where business functinality is implemented behind a isolcation tier (the web-tier). This additional isolation layer provides for increased security, but complications applicaiton development; however the T4/CodeGen templates makes for a much lighter implementation for the developer.
- Data-Tier
  A true data-tier implemented used SQL Server LocalDB.

Notes:
- Reflection provides for the implementation of amazingly rich applications; with some impact to application performance.
- Design-time generated code provides for some positive performance benefits, but reducing run-time flexability.
- This CodeGenSample focuses on the benefits of design-time code generation as a alternative solution.

## Setup
The following will walk you through the process of getting this sample running on your local development workstation in addition to providing you with information about what is needed compile and run the sample.

### Requirements
- Visual Studio 2019 v16.4.0+ (.Net Core 3.1+)
  Tested with the following:
    - Visual Studio 2019 "Community Edition"
    - Visual Studio 2019 "Professional Edition"
  - Installed Visual Studio Workloads (minimum):
    - ASP .NET and web development
    - Data storage and processing
    - .NET Core cross-platform development

- LocalDB

### Cloning the Repository
- Launch Visual Studio 2019
- Select the "Clone" option
  ![Image 01](https://github.com/ExcelliMatrix/emFrameworkCore-Samples/blob/master/CodeGenSample/images/Setup-VS01.png)
- Use the following local computer path and GitHub URL.
  ![Image 02](https://github.com/ExcelliMatrix/emFrameworkCore-Samples/blob/master/CodeGenSample/images/Setup-VS02.png)
  - Repository Location = https://github.com/ExcelliMatrix/emFrameworkCore-Samples.git
  - Local Path = C:\Devel\GitHub\ExcelliMatrix\emFrameworkCore-Samples\
- Switch Views and Select "CodeGenSample.sln"
  ![Image 03](https://github.com/ExcelliMatrix/emFrameworkCore-Samples/blob/master/CodeGenSample/images/Setup-VS03.png)
  ![Image 04](https://github.com/ExcelliMatrix/emFrameworkCore-Samples/blob/master/CodeGenSample/images/Setup-VS04.png)
- Rebuild Solution
  ![Image 05](https://github.com/ExcelliMatrix/emFrameworkCore-Samples/blob/master/CodeGenSample/images/Setup-VS05.png)
- Confirm all project build successfully
  ![Image 06](https://github.com/ExcelliMatrix/emFrameworkCore-Samples/blob/master/CodeGenSample/images/Setup-VS06.png)
- Change the startup settings for the solution.
  ![Image 07](https://github.com/ExcelliMatrix/emFrameworkCore-Samples/blob/master/CodeGenSample/images/Setup-VS07.png)
- Make the "CodeGenSample.App" and "CodeGenSample.Web" the first two projects and set them to "Start"
  ![Image 08](https://github.com/ExcelliMatrix/emFrameworkCore-Samples/blob/master/CodeGenSample/images/Setup-VS08.png)
- Start the application
  ![Image 09](https://github.com/ExcelliMatrix/emFrameworkCore-Samples/blob/master/CodeGenSample/images/Setup-VS09.png)
  *Note:* The initial execution of the application will create the LocalDB database with some basic data. As a result the first time the application is run will take a bit longer.
- You should see two browser windows.
  ![Image 10](https://github.com/ExcelliMatrix/emFrameworkCore-Samples/blob/master/CodeGenSample/images/Setup-VS10.png)

## Code Generation
The process of code generation, using emFrameworkCode.CodeGen is based on T4 templates executing within a Visual Studio contexts and thereby being aware of the solutions and projects loaded into Visual Studio. By default when a T4 template is changed/saved Visual Studio will prompt you to execute the template; DO NOT execute this way. It will not cause issues, but will result in execution errors.

To execute a T4 template designed to make use of the emFrameworkCore.CodeGen library perform the following:
1. Save your solution (Ctrl-S). If prompted as follows select the "Cancel" option.

2. Right click on the T4 template you wish to execute.
3. Select ""
