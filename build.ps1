cd ..
C:\Users\coden\scoop\apps\dotnet-sdk\current\dotnet.exe new sln -o TTDAssignment\
cd TTDAssignment
C:\Users\coden\scoop\apps\dotnet-sdk\current\dotnet.exe new console -o TTDAssignment
C:\Users\coden\scoop\apps\dotnet-sdk\current\dotnet.exe new xunit -o TTDAssignment.Tests
C:\Users\coden\scoop\apps\dotnet-sdk\current\dotnet.exe sln add .\TTDAssignment\
C:\Users\coden\scoop\apps\dotnet-sdk\current\dotnet.exe sln add .\TTDAssignment.Tests\
cd .\TTDAssignment.Tests\
C:\Users\coden\scoop\apps\dotnet-sdk\current\dotnet.exe add reference ..\TTDAssignment\
