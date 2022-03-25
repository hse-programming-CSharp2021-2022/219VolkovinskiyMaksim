FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Task02/Task02.csproj", "Task02/"]
RUN dotnet restore "Task02/Task02.csproj"
COPY . .
WORKDIR "/src/Task02"
RUN dotnet build "Task02.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task02.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task02.dll"]
