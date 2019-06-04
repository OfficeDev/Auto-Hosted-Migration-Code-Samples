[ARCHIVED] Auto-Hosted-Migration-Code-Samples
==================================

**Note:** This repo is archived and no longer actively maintained. Security vulnerabilities may exist in the project, or its dependencies. If you plan to reuse or run any code from this repo, be sure to perform appropriate security checks on the code or dependencies first. Do not use this project as the starting point of a production Office Add-in. Always start your production code by using the Office/SharePoint development workload in Visual Studio, or the [Yeoman generator for Office Add-ins](https://github.com/OfficeDev/generator-office), and follow security best practices as you develop the add-in.

Code Sample that shows a Auto Hosted Project migrated to a Provider Hosted Project.

The sample includes two Visual Studio 2013 solutions. Both solutions use a Azure SQL Database and Azure web site for the RemoteWeb of the app built using the cloud app model (CAM). They demonstrate how to take an existing autohosted app and migrate to a provider-hosted app using the guidance published in the white paper [MSDN - How to: Convert an autohosted app for SharePoint to a provider-hosted app](http://msdn.microsoft.com/EN-US/library/office/dn722449(v=office.15).aspx).

##CustomerManagerAH
This solution contains a working SharePoint autohosted app that can be deployed to Office 365.

##CustomerManagerPH
This solution is a copy of the *CustomerManagerAH* solution except it has been modified using the above mentioned white paper.


This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information, see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.
