# For more information about StoreBroker, visit https://github.com/Microsoft/StoreBroker
Set-ExecutionPolicy RemoteSigned -Force

# Prepare Authentication
$username = $env:PartnerCenterClientId
$password = ConvertTo-SecureString $env:PartnerCenterClientSecret -AsPlainText -Force
$appStoreId = $env:PartnerCenterStoreId
$tenantId = $env:PartnerCenterTenantId

# ********* Create temporary directory for submission artifacts *********
$currentPath = Get-Location
$sbTempFolderPath = New-Item -Type Directory -Force -Path (Join-Path -Path $currentPath -ChildPath 'SBTemp')

# ********* Install StoreBroker and import PowerShell Module *********
Set-PSRepository -Name "PSGallery" -InstallationPolicy Trusted
Install-Module -Name StoreBroker

# ********* Authenticate Store Broker *********
$cred = New-Object System.Management.Automation.PSCredential ($username, $password)
Set-StoreBrokerAuthentication -TenantId $tenantId -Credential $cred

# ********* Prepare Submission Package *********
$appxUploadFilePath = (Get-ChildItem -Recurse -Include *.appxupload -ErrorAction SilentlyContinue).fullname | Select-Object -First 1
$configFilePath = (Get-ChildItem -Recurse -Include SBConfig.json -ErrorAction SilentlyContinue).fullname | Select-Object -First 1
New-SubmissionPackage -ConfigPath $configFilePath -AppxPath $appxUploadFilePath -OutPath $sbTempFolderPath -OutName 'submission'

# ********* UPDATE & COMMIT SUBMISSION *********
$submissionDataPath = Join-Path -Path $sbTempFolderPath -ChildPath 'submission.json'
$submissionPackagePath = Join-Path -Path $sbTempFolderPath -ChildPath 'submission.zip'

Update-ApplicationSubmission -Verbose -ReplacePackages -AppId $appStoreId -SubmissionDataPath $submissionDataPath -PackagePath $submissionPackagePath -AutoCommit -Force -NoStatus