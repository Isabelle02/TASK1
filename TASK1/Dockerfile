FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["TASK1/TASK1.csproj", "TASK1/"]
RUN dotnet restore "TASK1/TASK1.csproj"
COPY . .
WORKDIR "/src/TASK1"
RUN dotnet build "TASK1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TASK1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TASK1.dll"]
