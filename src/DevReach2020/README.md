# DevReach 2020

Demonstrating the use of the GitHub Actions CI-CD, find the workflows in `.github/Workflows` folder.

## GitHub Actions

### Continuous Integration (aka CI)

| Branch        | Status |
|---------------|-----------|
| Default | ![CD (Xamarin.Forms All)](https://github.com/LanceMcCarthy/DevReachCompanion/workflows/CD%20(Xamarin.Forms%20All)/badge.svg) |
| `main` | ![CI (Xamarin.Forms All)](https://github.com/LanceMcCarthy/DevReachCompanion/workflows/CI%20(Xamarin.Forms%20All)/badge.svg?branch=main) |
| `v2020` | ![CI (Xamarin.Forms All)](https://github.com/LanceMcCarthy/DevReachCompanion/workflows/CI%20(Xamarin.Forms%20All)/badge.svg?branch=v2020) |

### Continuous Deployment (aka CD)

| CD Workflow     | Status |
|-----------------|--------|
| AppCenter       | todo  |
| iOS Release     | todo  |
| Android Release | todo  |
| Windows Release | todo  |


| Platform | GitHub Actions | AppCenter Prerelease | AppCenter Release |
|----------|----------------|----------------|-------------------|
| Android  | ![CD (Android)](https://github.com/LanceMcCarthy/DevReachCompanion/workflows/CD%20(Android)/badge.svg) | ![Android release AppCenter](https://build.appcenter.ms/v0.1/apps/ef428033-8891-4add-95f2-7fc4f54c9923/branches/appcenter/badge) | [![Build status](https://build.appcenter.ms/v0.1/apps/ef428033-8891-4add-95f2-7fc4f54c9923/branches/release-android/badge)](https://appcenter.ms) |
| iOS      | ![CD (iOS)](https://github.com/LanceMcCarthy/DevReachCompanion/workflows/CD%20(iOS)/badge.svg) | ![iOS Release AppCenter](https://build.appcenter.ms/v0.1/apps/a01fbcb4-c5b2-48d3-87fa-79ae2bf9a1b7/branches/appcenter/badge) | [![Build status](https://build.appcenter.ms/v0.1/apps/a01fbcb4-c5b2-48d3-87fa-79ae2bf9a1b7/branches/release-ios/badge)](https://appcenter.ms) |
| UWP      | ![CD (Windows)](https://github.com/LanceMcCarthy/DevReachCompanion/workflows/CD%20(Windows)/badge.svg) |  [![CD UWP AppCenter](https://build.appcenter.ms/v0.1/apps/0915d3ca-e6c5-4b9c-b932-3ab15d014a40/branches/appcenter/badge)](https://appcenter.ms) | n/a |

## AppCenter

**Builds**

| Platform | Preleases | Store |
|----------|----------------|-------------------|
| Android  | ![Android release AppCenter](https://build.appcenter.ms/v0.1/apps/ef428033-8891-4add-95f2-7fc4f54c9923/branches/appcenter/badge) | [![Build status](https://build.appcenter.ms/v0.1/apps/ef428033-8891-4add-95f2-7fc4f54c9923/branches/release-android/badge)](https://appcenter.ms) |
| iOS  | ![iOS Release AppCenter](https://build.appcenter.ms/v0.1/apps/a01fbcb4-c5b2-48d3-87fa-79ae2bf9a1b7/branches/appcenter/badge) | [![Build status](https://build.appcenter.ms/v0.1/apps/a01fbcb4-c5b2-48d3-87fa-79ae2bf9a1b7/branches/release-ios/badge)](https://appcenter.ms) |
| UWP |  [![CD UWP AppCenter](https://build.appcenter.ms/v0.1/apps/0915d3ca-e6c5-4b9c-b932-3ab15d014a40/branches/appcenter/badge)](https://appcenter.ms) | n/a |

**Distributions**

| Platform   | Beta Installation | Production Installation |
|------------|-----------| ---|------------|
| Android    |  [Install](install.appcenter.ms/users/lance-mccarthy-1uw5/apps/devreach-2020-android/distribution_groups/testers) | <a href='http://play.google.com/store/apps/details?id=com.LancelotSoftware.DevReachCompanion'><img alt='Get it on Google Play' src='https://play.google.com/intl/en_us/badges/static/images/badges/en_badge_web_generic.png' width='150'/></a>     |
| iOS        |  [Install](install.appcenter.ms/users/lance-mccarthy-1uw5/apps/devreach-2020-ios/distribution_groups/testers) | <a href='https://apps.apple.com/us/app/devreach-companion/id1483349010?ls=1'><img alt='Get it on App Store' src='https://linkmaker.itunes.apple.com/en-us/badge-lrg.svg?kind=iossoftware' width='150'/></a> |
| Windows | [Install](install.appcenter.ms/users/lance-mccarthy-1uw5/apps/devreach-2020-uwp/distribution_groups/testers) or  [**use AppInstaller (*highly recommended*)**](https://dvlup.blob.core.windows.net/general-app-files/Installers/DevReachCompanion/index.html) | <a href='//www.microsoft.com/store/apps/9MZNMK3MPV8R?cid=storebadge&ocid=badge'><img src='https://assets.windowsphone.com/85864462-9c82-451e-9355-a3d5f874397a/English_get-it-from-MS_InvariantCulture_Default.png' alt='Get it on Microsoft Store' width='150'/></a> |

## Previews

| Android  | iOS                                      | UWP      |
|----------|------------------------------------------|----------|
| <img src="https://user-images.githubusercontent.com/3520532/95248542-71052580-07e5-11eb-967b-bb68f29015f8.png" alt="drawing" height="400" /> | <img src="https://user-images.githubusercontent.com/3520532/95267655-c05a4e80-0803-11eb-980b-2c7c51dd2323.png" alt="drawing" height="400"/> | <img src="https://user-images.githubusercontent.com/3520532/95270221-1382d000-0809-11eb-9567-a6015cce6321.png" alt="drawing" height="400"/> |
