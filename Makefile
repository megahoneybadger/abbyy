cleanup:
	dotnet clean core/vantage.utils.core.csproj
	dotnet clean sandbox/vantage.utils.sandbox.csproj
	dotnet clean tests/vantage.utils.tests.csproj

restore:
	dotnet restore core/vantage.utils.core.csproj
	dotnet restore sandbox/vantage.utils.sandbox.csproj
	dotnet restore tests/vantage.utils.tests.csproj
	
build:
	dotnet build core/vantage.utils.core.csproj
	dotnet build sandbox/vantage.utils.sandbox.csproj
	dotnet build tests/vantage.utils.tests.csproj
	
test:
	dotnet test _bin/tests/abbyy.vantage.utils.tests.dll -v n
	
rebuild: cleanup restore build

run: 
	dotnet _bin/abbyy.vantage.utils.sandbox.dll
