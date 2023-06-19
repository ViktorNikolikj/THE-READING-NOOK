# Set the base image to use for the Docker image
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

# Set the working directory in the container
WORKDIR /app

# Copy the project files to the working directory
COPY . .

# Restore the dependencies
RUN dotnet restore

# Build the application
RUN dotnet build -c Release --no-restore

# Publish the application
RUN dotnet publish -c Release -o /app/publish --no-restore

# Set the runtime base image
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime

# Set the working directory in the container
WORKDIR /app

# Copy the published application from the build stage
COPY --from=build /app/publish .

# Expose the port that the application listens on
EXPOSE 80

# Set the entry point for the container
ENTRYPOINT ["dotnet", "ProektISWeb.dll"]
