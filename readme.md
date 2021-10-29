# Animal Shelter Api/MVC

## by Charlie Weber

Small application to store and retrieve Animal information for a fictional shelter

## Technologies Used
* C#
* HTMl/CSS
* ASP.NET Core MVC
* MySQL
* Entity Framework Core v 5.0
* Swagger
* Postman

## Description
This api database contains information on animals in a local shlter. Users are able to add, edit, view, and delete data entries through Either the Swagger UI or the MVC Client.

### Prerequisites


**Install .NET Core**
  * Mac:Install [here](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-2.2.106-macos-x64-installer)
  * Windows: Install [here](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-2.2.203-windows-x64-installer)




## Setup and Use


**Cloning/Obtaining API File**
1. Navigate to the [AnimalShelterAPI](https://github.com/CharWeber/AnimalShelterApi)
2. Clone or download the repo - follow [these~instructions](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository) if this is your first time.
3. Open up your system Terminal or CMD prompt application in the directory you wish to host the project
4. Clone the repository using this command within the project directory


        $ git clone https://github.com/CharWeber/AnimalShelterApi

**AppSettings**

1. Create new file appsettings.json in AnimalShelterApi/Shelter
2. Add the following code to the new appsettings.json, replacing the YOUR_PASSWORD_HERE with your mySQL password

```
{  
  "Logging": {  
    "LogLevel": {  
      "Default": "Information",  
      "Microsoft": "Warning",  
      "Microsoft.Hosting.Lifetime": "Information"  
    }  
  },  
  "AllowedHosts": "*",  
  "ConnectionStrings": { 
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=root;pwd=epicodus;", 
    "ConnStr": "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SarathlalDB;Integrated Security=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"  
  }
} 
```
**Database Setup**

1. In terminal, navigate into AnimalShelter/Shelter and run

        $ dotnet restore
2. run this command to build database

        $ dotnet ef database update
 




**Launch API in Server**
1. In AniamlShelterAAPI/Shelter, run this command to open the api in your browser

        $ dotnet run

## 🛰️ API Documentation
Explore the API endpoints in Postman or a browser using the Swagger UI. 

### Using Swagger Documentation 
To explore the API with Swagger, launch the project using `dotnet run` with the Terminal or Powershell, and input the following URL into your browser: `http://localhost:5000/swagger`

..........................................................................................

### Endpoints
Base URL: `http://localhost:5000`

#### HTTP Request Structure
```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```

#### Example Query
```
https//localhost:5000/api/Animals/1
```

### Animals
Access information about the listed Animals

#### HTTP Request
```
GET /api/Animals
POST /api/Animals
GET /api/Animals/{id}
PUT /api/Review/{id}
DELETE /api/Review/{id}
```

#### Path Parameters

| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| species | string | none | false | Return matches by species.


#### Example Query
```
http://localhost:5001/api/Animals/?species=cat
```

#### Sample JSON Response
```
[
  {
    "animalId": 1,
    "name": "Catface Meowmers",
    "species": "cat",
    "age": 1,
    "gender": "male"
  }
]
```

## MVC Shelter Client
Base URL: http://localhost:5003

To Utilize the MVC Client you must have the Shelter project running on its Base URL

1. In terminal, navigate into SillyStringFactory.Solution/Factory/ and enter the command below to install necessary packages

        $ dotnet restore
2. enter this command to build the program

       $ dotnet build

3. enter the command below to view program in your browser

        $ dotnet run

4. navigate to the Base URL in your browser

        http://localhost:5003



### Known Bugs

* The edit route in the MVC doesn't seem to find the correct route. I'm not sure how to define the method route to put in the edit form. The API functions fine when calling the endpoint in swagger and postman so the issue is in the MVC

------------------------------

### 🤝 Contributors

| Author | GitHub | Email |
|--------|:------:|:-----:|
| [Charles T Weber](https://www.linkedin.com/in/charles-t-weber/) | [CharWeber](https://github.com/CharWeber) |  [charlestweber@gmail.com](mailto:charlesweber@gmail.com) |


------------------------------