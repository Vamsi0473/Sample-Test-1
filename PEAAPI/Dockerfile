FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["PEAAPI/PEAAPI.csproj", "PEAAPI/"]
RUN dotnet restore "PEAAPI/PEAAPI.csproj"
COPY . .
WORKDIR "/src/PEAAPI"
RUN dotnet build "PEAAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "PEAAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "PEAAPI.dll"]