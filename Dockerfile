FROM  mcr.microsoft.com/dotnet/sdk:5.0 AS backend-build

# build backend
WORKDIR /src

COPY ["core/vantage.utils.core.csproj", "core/"]
COPY ["sandbox/vantage.utils.sandbox.csproj", "sandbox/"]

RUN dotnet restore "core/vantage.utils.core.csproj"
RUN dotnet restore "sandbox/vantage.utils.sandbox.csproj"

COPY ["core", "core"]
COPY ["sandbox", "sandbox"]

RUN dotnet publish -c Release "sandbox/vantage.utils.sandbox.csproj"  -o /app/bin


FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app

COPY --from=backend-build /app/bin  /bin

WORKDIR "/bin"
ENTRYPOINT ["dotnet", "abbyy.vantage.utils.sandbox.dll"]

