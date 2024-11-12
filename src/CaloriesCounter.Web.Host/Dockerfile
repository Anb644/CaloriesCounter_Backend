FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/CaloriesCounter.Web.Host/CaloriesCounter.Web.Host.csproj", "src/CaloriesCounter.Web.Host/"]
COPY ["src/CaloriesCounter.Web.Core/CaloriesCounter.Web.Core.csproj", "src/CaloriesCounter.Web.Core/"]
COPY ["src/CaloriesCounter.Application/CaloriesCounter.Application.csproj", "src/CaloriesCounter.Application/"]
COPY ["src/CaloriesCounter.Core/CaloriesCounter.Core.csproj", "src/CaloriesCounter.Core/"]
COPY ["src/CaloriesCounter.EntityFrameworkCore/CaloriesCounter.EntityFrameworkCore.csproj", "src/CaloriesCounter.EntityFrameworkCore/"]
WORKDIR "/src/src/CaloriesCounter.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/CaloriesCounter.Web.Host", "src/CaloriesCounter.Web.Host"]
COPY ["src/CaloriesCounter.Web.Core", "src/CaloriesCounter.Web.Core"]
COPY ["src/CaloriesCounter.Application", "src/CaloriesCounter.Application"]
COPY ["src/CaloriesCounter.Core", "src/CaloriesCounter.Core"]
COPY ["src/CaloriesCounter.EntityFrameworkCore", "src/CaloriesCounter.EntityFrameworkCore"]
WORKDIR "/src/src/CaloriesCounter.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "CaloriesCounter.Web.Host.dll"]
