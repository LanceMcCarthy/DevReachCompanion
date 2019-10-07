# DevReachCompanion
A repo containing the DevReachCompanion app, REST API code and DevOps YAML used for 'One Dev Powerhouse' talk at DevReach 2019.

## DevOps

#### Build Pipelines

| Master   | Dev      |
|----------|----------|
| [![Master](https://dev.azure.com/lance/DevReach%20Companion/_apis/build/status/Complete%20YAML%20Build?branchName=master)](https://dev.azure.com/lance/DevReach%20Companion/_build/latest?definitionId=37&branchName=master) | [![Dev](https://dev.azure.com/lance/DevReach%20Companion/_apis/build/status/Complete%20YAML%20Build?branchName=dev)](https://dev.azure.com/lance/DevReach%20Companion/_build/latest?definitionId=37&branchName=dev) |

#### Release Pipelines


| Platform                | AppCenter              |  Beta  | Production |
|-------------------------|------------------------|--------|------------|
| Android | ![AppCenter Android](https://vsrm.dev.azure.com/lance/_apis/public/Release/badge/7dd01a63-05a2-436b-b30a-3a2ddc2327bb/2/4) | ![Google Play Beta](https://vsrm.dev.azure.com/lance/_apis/public/Release/badge/7dd01a63-05a2-436b-b30a-3a2ddc2327bb/2/8) | ![Promote Beta to Production](https://vsrm.dev.azure.com/lance/_apis/public/Release/badge/7dd01a63-05a2-436b-b30a-3a2ddc2327bb/2/10) |
| iOS | ![AppCenter iOS](https://vsrm.dev.azure.com/lance/_apis/public/Release/badge/7dd01a63-05a2-436b-b30a-3a2ddc2327bb/2/2) | ![TestFlight](https://vsrm.dev.azure.com/lance/_apis/public/Release/badge/7dd01a63-05a2-436b-b30a-3a2ddc2327bb/2/13) | ![AppStore](https://vsrm.dev.azure.com/lance/_apis/public/Release/badge/7dd01a63-05a2-436b-b30a-3a2ddc2327bb/2/14) |
| UWP | ![DevCenter Beta Flight](https://vsrm.dev.azure.com/lance/_apis/public/Release/badge/7dd01a63-05a2-436b-b30a-3a2ddc2327bb/2/5) | ![DevCenter Beta](https://vsrm.dev.azure.com/lance/_apis/public/Release/badge/7dd01a63-05a2-436b-b30a-3a2ddc2327bb/2/11) | ![DevCenter Release](https://vsrm.dev.azure.com/lance/_apis/public/Release/badge/7dd01a63-05a2-436b-b30a-3a2ddc2327bb/2/12) |
| Web API | n/a | n/a | ![Azure App Service](https://vsrm.dev.azure.com/lance/_apis/public/Release/badge/7dd01a63-05a2-436b-b30a-3a2ddc2327bb/2/6) |
| GitHub                  | n/a | n/a | ![GitHub](https://vsrm.dev.azure.com/lance/_apis/public/Release/badge/7dd01a63-05a2-436b-b30a-3a2ddc2327bb/2/7) |

## Solution Structure

There are 7 projects in the solution:

* **Web API**
  * ASP.NET Web API
  * Unit Tests
* **Xamarin.Forms**
  * UWP
  * Xamarin.iOS
  * Xamarin.Android
  * .NET Standard Class Library
  * Unit Tests

If you plan on building and deploying this, visit the ApiKeys.cs class in order to insert your Azure account information.
