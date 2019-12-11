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
  {image here}
- Use the following local computer path and GitHub URL.
  - Repository Location = https://github.com/ExcelliMatrix/emFrameworkCore-Samples.git
  - Local Path = C:\Devel\GitHub\ExcelliMatrix\emFrameworkCore-Samples\

