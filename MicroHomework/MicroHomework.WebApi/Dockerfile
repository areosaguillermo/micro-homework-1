FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MicroHomework.WebApi/MicroHomework.WebApi.csproj", "MicroHomework.WebApi/"]
RUN dotnet restore "MicroHomework.WebApi/MicroHomework.WebApi.csproj"
COPY . .
WORKDIR "/src/MicroHomework.WebApi"
RUN dotnet build "MicroHomework.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroHomework.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroHomework.WebApi.dll"]
