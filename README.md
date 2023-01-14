# Todo API
This is a simple to-do web API built using Azure, ASP.NET Core, and PostgreSQL. The API allows users to create, read, update, and delete to-do items.

## Getting Started
1. Clone the repository
```bash
git clone https://github.com/[YOUR_USERNAME]/todo-api.git
```

2. Navigate to the project directory
```bash
cd todo-api
```

3. Restore the necessary packages
```bash
dotnet restore
```

4. Update the connection string in appsettings.json to connect to your PostgreSQL database in Azure.

5. Run the API

```bash
dotnet run
```
6. The API will be running on https://localhost:5001 by default, you can use this url to test the API.

## Installing NuGet packages
This project uses [Npgsql](https://www.npgsql.org/) and [Dapper](https://dapper-tutorial.net/) NuGet packages. If you don't have these packages installed, you can install them by running the following command in the Package Manager Console:

```bash
PM> Install-Package Npgsql -Version [version]
PM> Install-Package Dapper -Version [version]
```
Make sure to replace [version] with the desired version number.

Alternatively, you can install the packages using the dotnet command-line interface by running the following command in the project directory:

```bash
dotnet add package Npgsql -v [version]
dotnet add package Dapper -v [version]
```

Also, you can consider adding the versions of those packages that you are using in your project.

### API Endpoints
* GET /: Retrieve a list of all to-do items
* GET /{id}: Retrieve a specific to-do item by id
* POST /: Create a new to-do item
* PUT /: Update a specific to-do item by id
* DELETE /{id}: Delete a specific to-do item by id

### Built With
* [Azure](https://azure.microsoft.com/en-us/) - Cloud platform used for hosting and database
* [Asp.Net Core](https://dotnet.microsoft.com/en-us/apps/aspnet) - Web framework
* [PostgreSQL](https://www.postgresql.org/) - Database
* [Npgsql](https://www.npgsql.org/) - ADO.NET provider for PostgreSQL
* [Dapper](https://dapper-tutorial.net/) - Simple object mapper for .NET

### Deployment
This API is deployed to Azure at https://todoapi20230114063602.azurewebsites.net/.

### Postman
You can send request or retrieve response from [Postman](https://www.postman.com/).

1. Download and install Postman

2. Download the To do API Requests.postman_collection.json file from the root directory of your project.

3. In Postman, click on the "Import" button in the top left corner.

4. In the "Import File" modal, select the "Choose Files" button and select the To do API Requests.postman_collection.json file you downloaded in step 2.

5. The "Todo API" collection will now be imported into your Postman workspace. You can find it in the "Collections" tab on the left sidebar.

6. Click on the "Todo API" collection to expand it and view the available endpoints.

7. Click on an endpoint to open the request, and then click on the "Send" button to execute the request.

8. Check the response and verify that it matches the expected result.

Alternatively, you can send your custom requests by using the endpoints I mentioned before.

### Author
* [Kenan Cum](https://linkedin.com/in/kenancum/)

### License
* [Mozilla Public License Version 2.0](https://www.mozilla.org/en-US/MPL/2.0/)
