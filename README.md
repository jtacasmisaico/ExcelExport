# ASP.NET 5 Excel Export

This repository contains sample code for implementing Excel Export in ASP.NET 5 using Open XML SDK.

* Modify the project.json file and include Open XML SDK reference.
```
"dependencies": {
  "Microsoft.AspNet.Diagnostics": "1.0.0-beta6",
  "Microsoft.AspNet.Mvc": "6.0.0-beta6",
  "Microsoft.AspNet.Server.IIS": "1.0.0-beta6",
  "Microsoft.AspNet.Server.WebListener": "1.0.0-beta6",
  "Microsoft.Framework.Logging.Console": "1.0.0-beta6",
  "DocumentFormat.OpenXml":"2.5.0"
},
"frameworks": {
   "dnx451": {
       "frameworkAssemblies": {
           "WindowsBase":"4.0.0"
       }
  }
}
```
* Implement the Excel export logic. You can find a Data table version in [SO](http://stackoverflow.com/a/11812551/38024)
* This repository contains generic one which supports normal POCO classes.
* For re-usability can create a ExcelFileResult class, which helps to return Excel files as output.
