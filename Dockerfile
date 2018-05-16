FROM microsoft/aspnetcore-build:2.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
RUN mkdir bowlingGame bowlingGameWebAPI
COPY bowlingGame/*.csproj ./bowlingGame
COPY bowlingGameWebAPI/*.csproj ./bowlingGameWebAPI
RUN cd bowlingGameWebAPI && dotnet restore

# Copy everything else and build
COPY bowlingGame ./bowlingGame/
COPY bowlingGameWebAPI ./bowlingGameWebAPI/
RUN cd bowlingGameWebAPI && dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/aspnetcore:2.0
WORKDIR /app
COPY --from=build-env /app/bowlingGameWebAPI/out .

ENTRYPOINT ["dotnet", "bowlingGameWebAPI.dll"]