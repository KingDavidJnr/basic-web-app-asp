# Basic Web API Project

## Overview

This project is a Web API built using .NET to provide a robust backend for web applications. It leverages the power of ASP.NET Core for creating scalable and maintainable APIs.

## Getting Started

Follow these steps to set up and run the project locally.

1. **Clone the repository:**

    ```bash
    git clone https://github.com/KingDavidJnr/basic-web-app-api.git
    cd basic-web-app-api
    ```

2. **Create `appsettings.json`:**

    Copy the content from `appsettings.example.json` and save it as `appsettings.json`. Fill in the required configuration values.

3. **Install dependencies:**

    ```bash
    dotnet restore
    ```

4. **Build and run the project:**

    ```bash
    dotnet build
    dotnet run
    ```

Your Web API should now be accessible locally at [http://localhost:5000](http://localhost:5000).

## Configuration

### `appsettings.json`

Before running the application, ensure you have configured the `appsettings.json` file. Below is an example:

```json
{
  "AppSettings": {
    "ApiKey": "your-api-key",
    "DatabaseConnectionString": "your-database-connection-string"
  }
}
```

Replace `"your-api-key"` and `"your-database-connection-string"` with your actual API key and database connection string.

## Gitignore

Make sure to add and commit the `appsettings.json` file to your local repository. The `.gitignore` file is configured to ignore this file, as well as the `obj/` and `bin/` directories.

## Contributing

We welcome contributions to enhance the functionality and features of this Web API. To contribute:

1. Fork the repository.
2. Create a new branch for your feature: `git checkout -b feature-name`.
3. Make your changes and commit them: `git commit -m "Add your feature"`.
4. Push to your branch: `git push origin feature-name`.
5. Create a pull request.