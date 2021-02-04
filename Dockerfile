#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
RUN apt-get update && apt-get -y install make gcc zlib1g-dev # install dependencies for konto_check compilation
WORKDIR /src
COPY ["KontoCheckRestApi.csproj", ""]
RUN dotnet restore "./KontoCheckRestApi.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "KontoCheckRestApi.csproj" -c Release -o /app/build
RUN cd /app/build/konto_check && make libkonto_check # konto_check

FROM build AS publish
RUN dotnet publish "KontoCheckRestApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY --from=build /app/build/konto_check/libkonto_check.so /usr/local/lib/
RUN ldconfig /usr/local/lib # make konto_check library known
ENTRYPOINT ["dotnet", "KontoCheckRestApi.dll"]