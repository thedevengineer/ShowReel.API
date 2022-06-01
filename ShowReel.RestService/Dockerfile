#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ShowReel.RestService/ShowReel.RestService.csproj", "ShowReel.RestService/"]
COPY ["ShowReel.Infrastructure/ShowReel.Infrastructure.csproj", "ShowReel.Infrastructure/"]
COPY ["ShowReel.Core/ShowReel.Core.csproj", "ShowReel.Core/"]
COPY ["ShowReel.Application/ShowReel.Application.csproj", "ShowReel.Application/"]
RUN dotnet restore "ShowReel.RestService/ShowReel.RestService.csproj"
COPY . .
WORKDIR "/src/ShowReel.RestService"
RUN dotnet build "ShowReel.RestService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ShowReel.RestService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ShowReel.RestService.dll"]