FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY BlazorApp1.csproj .
RUN dotnet restore BlazorApp1.csproj
COPY . .
RUN dotnet build BlazorApp1.csproj -c Release -o /app/build

FROM build AS publish
RUN dotnet publish BlazorApp1.csproj -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .
COPY nginx.conf /etc/nginx/nginx.conf