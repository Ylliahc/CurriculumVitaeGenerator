dotnet build -t:Build -p:Configuration=Debug -f net8.0-windows10.0.19041.0 -p:WindowsPackageType=None -p:CustomAfterMicrosoftCSharpTargets="c:\Users\Yllia\.vscode\extensions\ms-dotnettools.dotnet-maui-0.6.19-win32-x64\dist\resources\Custom.After.Microsoft.CSharp.targets" -p:_DeletePriConfigXml=True C:\src\CurriculumVitaeGenerator\src\NativeApp\CurriculumVitaeGenerator.NativeApp.csproj 