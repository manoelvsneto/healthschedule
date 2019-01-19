FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Health.Schedule.WebApi/Health.Schedule.WebApi.csproj", "Health.Schedule.WebApi/"]
RUN dotnet restore "Health.Schedule.WebApi/Health.Schedule.WebApi.csproj"
COPY . .
WORKDIR "/src/Health.Schedule.WebApi"
RUN dotnet build "Health.Schedule.WebApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Health.Schedule.WebApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Health.Schedule.WebApi.dll"]