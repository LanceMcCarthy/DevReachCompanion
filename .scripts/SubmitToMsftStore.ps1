Set-ExecutionPolicy RemoteSigned -Force

# Prepare materials from previous steps and runner environment variables src\DevReach2020\DevReach2020.Forms\UWP
$appxUploadFilePath = "D:\a\DevReachCompanion\DevReachCompanion\src\DevReach2020\DevReach2020.Forms\UWP\AppPackages\Store\DevReach2020.Forms.UWP_" + $env:APP_VERSION + "_" + $env:AppxBundlePlatforms + "_bundle.appxupload"
$username = $env:PartnerCenterClientId
$password = ConvertTo-SecureString $env:PartnerCenterClientSecret -AsPlainText -Force
$appStoreId = $env:PartnerCenterStoreId
$tenantId = $env:PartnerCenterTenantId

# ********* Create temporary directory for submission artifacts *********
$sbTempFolderPath = New-Item -Type Directory -Force -Path (Join-Path -Path 'D:\a\DevReachCompanion\DevReachCompanion\' -ChildPath 'SBTemp')

# ********* Install StoreBroker and import PowerShell Module *********
Set-PSRepository -Name "PSGallery" -InstallationPolicy Trusted
Install-Module -Name StoreBroker

# ********* Authenticate Store Broker *********
$cred = New-Object System.Management.Automation.PSCredential ($username, $password)
Set-StoreBrokerAuthentication -TenantId $tenantId -Credential $cred

# ********* Prepare Submission Package *********
$configFilePath = 'D:\a\DevReachCompanion\DevReachCompanion\.scripts\SBConfig.json'
New-SubmissionPackage -ConfigPath $configFilePath -AppxPath $appxUploadFilePath -OutPath $sbTempFolderPath -OutName 'submission'

# ********* UPDATE & COMMIT SUBMISSION *********
$submissionDataPath = Join-Path -Path $sbTempFolderPath -ChildPath 'submission.json'
$submissionPackagePath = Join-Path -Path $sbTempFolderPath -ChildPath 'submission.zip'

Update-ApplicationSubmission -Verbose -ReplacePackages -AppId $appStoreId -SubmissionDataPath $submissionDataPath -PackagePath $submissionPackagePath -AutoCommit -Force -NoStatus