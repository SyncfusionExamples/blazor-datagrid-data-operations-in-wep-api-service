# Blazor DataGrid - Data Operations in Web API Service

## Overview

This sample demonstrates how to perform data operations in a Web API service and display the processed results in the Syncfusion Blazor DataGrid. Instead of executing sorting, filtering, paging, and related operations on the client side, the requests are handled in the server layer and the resulting data is returned to the grid. The application uses Entity Framework Core and SQL Server to retrieve data from the Northwind database and provides a practical reference implementation for building scalable server-side data processing solutions with Syncfusion Blazor DataGrid.

## Key Features

- Demonstrates server-side DataGrid data processing using a Web API service.
- Uses Entity Framework Core to retrieve and process database records.
- Uses an `OrderContext` database context configured through `UseSqlServer`.
- Retrieves data from a SQL Server database based on incoming DataGrid requests.
- Performs data operations such as filtering, sorting, paging, and query processing in the Web API layer.
- Reduces client-side processing by moving DataGrid operations to the server.
- Demonstrates integration between Syncfusion Blazor DataGrid and ASP.NET Core Web API services.
- Uses a Northwind database (`NORTHWIND.MDF`) as the sample data source.
- Provides a reference architecture for enterprise applications that require server-driven data operations.
- Illustrates database-backed DataGrid implementations using Entity Framework Core and SQL Server.

## Prerequisites

- Visual Studio 2022 or Visual Studio Code
- .NET SDK compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone or download the repository.
2. Open the solution file located in the `DataOperationInWebAPI` project folder.
3. Restore all NuGet packages.
4. Update the path of `NORTHWIND.MDF` in `DataOperationInWebAPI/Data/OrderContext.cs` based on your local environment.
5. Set the `DataOperationInWebAPI` project as the startup project if required.
6. Build the solution.
7. Run the application using `Ctrl+F5`.

**Visual Studio Code**

1. Open the repository folder in Visual Studio Code.
2. Open the integrated terminal.
3. Navigate to the application directory.

```bash
cd DataOperationInWebAPI
dotnet restore
dotnet run
```

4. Update the `NORTHWIND.MDF` path in `Data/OrderContext.cs` before running the application.
5. Open the local URL displayed in the terminal after the application starts.

## Project Structure

- `DataOperationInWebAPI/Data/OrderContext.cs` — contains the Entity Framework Core database context that configures SQL Server connectivity through `UseSqlServer` and accesses the `Orders` dataset.
- `DataOperationInWebAPI/Controllers/` — hosts the Web API endpoints responsible for processing DataGrid requests and returning processed data. 
- `DataOperationInWebAPI/Pages/` — contains the Blazor page that renders the Syncfusion Blazor DataGrid and consumes the Web API service.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- For feature documentation, see the Syncfusion Blazor DataGrid Web API Adaptor documentation: https://help.syncfusion.com/grid-sdk/blazor/data-grid/connecting-to-adaptors/web-api-adaptor

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.