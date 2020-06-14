# Sonar Cloud

[Exercise - Scan the project locally by using SonarCloud](https://docs.microsoft.com/en-us/learn/modules/scan-for-vulnerabilities/3-set-up-environment)

## Prerequestits:

Install [Java SDK](https://www.oracle.com/java/technologies/javase-jdk14-downloads.html)

Set Java_Home Environment Variable in an elevated Powershell Console

```
setx Java_Home "C:\Program Files\Java\jdk-14.0.1" /m
Get-ChildItem Env:
```

Fork Source from `https://github.com/MicrosoftDocs/mslearn-tailspin-spacegame-web`

```bash
git fetch upstream security-scan
git checkout -b security-scan upstream/security-scan
```
