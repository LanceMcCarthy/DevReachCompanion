# Progress DevReach

This repository holds my projects for each DevReach conference. Nested inside src folder, you will find the relevant year, open that year and you'll also find the README with the details for that year's project.

* [**DevReach 2020 Projects**](https://github.com/LanceMcCarthy/DevReachCompanion/tree/main/src/DevReach2020)
* [**DevReach 2019 Projects**](https://github.com/LanceMcCarthy/DevReachCompanion/tree/main/src/DevReach2019)

# DevReach 2020

Demonstrating the use of the GitHub Actions CI-CD, find the workflows in `.github/workflows` folder.

## GitHub Actions

### Continuous Integration

| Default  | `main` branch | `v2020` branch |
|----------|------|----------|
| ![CD (Xamarin.Forms All)](https://github.com/LanceMcCarthy/DevReachCompanion/workflows/CD%20(Xamarin.Forms%20All)/badge.svg) | ![CI (Xamarin.Forms All)](https://github.com/LanceMcCarthy/DevReachCompanion/workflows/CI%20(Xamarin.Forms%20All)/badge.svg?branch=main) | ![CI (Xamarin.Forms All)](https://github.com/LanceMcCarthy/DevReachCompanion/workflows/CI%20(Xamarin.Forms%20All)/badge.svg?branch=v2020) |

### Continuous Deployment

| Workflow | Status |
|----------|--------|
| AppCenter       | ![CD (AppCenter)](https://github.com/LanceMcCarthy/DevReachCompanion/workflows/CD%20(AppCenter)/badge.svg) |
| iOS Release     | ![CD (iOS)](https://github.com/LanceMcCarthy/DevReachCompanion/workflows/CD%20(iOS)/badge.svg) |
| Android Release | ![CD (Android)](https://github.com/LanceMcCarthy/DevReachCompanion/workflows/CD%20(Android)/badge.svg) |
| Windows Release | ![CD (Windows)](https://github.com/LanceMcCarthy/DevReachCompanion/workflows/CD%20(Windows)/badge.svg) |

## AppCenter

**Builds**

| Platform | Preleases | Store |
|----------|----------------|-------------------|
| Android  | ![Android release AppCenter](https://build.appcenter.ms/v0.1/apps/ef428033-8891-4add-95f2-7fc4f54c9923/branches/appcenter/badge) | [![Build status](https://build.appcenter.ms/v0.1/apps/ef428033-8891-4add-95f2-7fc4f54c9923/branches/release-android/badge)](https://appcenter.ms) |
| iOS  | ![iOS Release AppCenter](https://build.appcenter.ms/v0.1/apps/a01fbcb4-c5b2-48d3-87fa-79ae2bf9a1b7/branches/appcenter/badge) | [![Build status](https://build.appcenter.ms/v0.1/apps/a01fbcb4-c5b2-48d3-87fa-79ae2bf9a1b7/branches/release-ios/badge)](https://appcenter.ms) |
| UWP |  [![CD UWP AppCenter](https://build.appcenter.ms/v0.1/apps/0915d3ca-e6c5-4b9c-b932-3ab15d014a40/branches/appcenter/badge)](https://appcenter.ms) | n/a |

**Distributions**

| Platform   | Beta Installation | Production Installation |
|------------|-----------|------------|
| Android    |  [Install from AppCenter](install.appcenter.ms/users/lance-mccarthy-1uw5/apps/devreach-2020-android/distribution_groups/testers) | <a href='http://play.google.com/store/apps/details?id=com.LancelotSoftware.DevReachCompanion'><img alt='Get it on Google Play' src='.images/StoreBadges/GooglePlayBadge.png' width='150'/></a>     |
| iOS        |  [Install from AppCenter](install.appcenter.ms/users/lance-mccarthy-1uw5/apps/devreach-2020-ios/distribution_groups/testers) | <a href='https://apps.apple.com/us/app/devreach-companion/id1483349010?ls=1'><img alt='Get it on App Store' src='.images/StoreBadges/AppleAppStoreBadge.svg' width='150'/></a> |
| Windows | [Install from AppCenter](install.appcenter.ms/users/lance-mccarthy-1uw5/apps/devreach-2020-uwp/distribution_groups/testers) or  [**use AppInstaller** (*recommended*)](https://dvlup.blob.core.windows.net/general-app-files/Installers/DevReachCompanion/index.html) | <a href='//www.microsoft.com/store/apps/9MZNMK3MPV8R?cid=storebadge&ocid=badge'><img src='.images/StoreBadges/MsftStoreBadge_Large.png' alt='Get it on Microsoft Store' width='150'/></a> |

## Previews

| Android  | iOS                                      | Windows      |
|----------|------------------------------------------|----------|
| <img src=".images/Screenshots/Android_Home.png" alt="drawing" height="400" /> | <img src=".images/Screenshots/iOS_Home.png" alt="drawing" height="400"/> | <img src=".images/Screenshots/Windows_Home.png" alt="drawing" height="400"/> |

## Project Summary

### DevReach 2020

For 2020, I am demonstrating the use of GitHub Actions CI-CD workflows! You will find the source code in [**src\DevReach2020**](https://github.com/LanceMcCarthy/DevReachCompanion/tree/main/src/DevReach2020) folder and see `.github/Workflows` folder for the workflows.

### DevReach 2019

In the [**src\DevReach2019**](https://github.com/LanceMcCarthy/DevReachCompanion/tree/main/src/DevReach2019) folder, you will find a **Xamarin.Forms** solution, with an **ASP.NET Core 3.1** project, all leveraging **Azure DevOps** to build and release all four applications.

You'll not only find links to the DevOps build and releases, but also links to the production applications in their respective app Stores.
