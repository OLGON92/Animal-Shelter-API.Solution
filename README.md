<br>
<p align="center">
  <u><big>|| <b>Animal Shelter API</b> ||</big></u>
  <u><big> <b>By Oscar Gonzalez</b> </big></u>
</p>
<br>

------------------------------
### <u>Table of Contents</u>
* <a href="#🌐-about-the-project">About the Project</a>
    * <a href="#📖-description">Description</a>
    * <a href="#🦠-known-bugs">Known Bugs</a>
    * <a href="#🛠-built-with">Built With</a>
    <!-- * <a href="#🔍-preview">Preview</a> -->
* <a href="#🏁-getting-started">Getting Started</a>
    * <a href="#📋-prerequisites">Prerequisites</a>
    * <a href="#⚙️-setup-and-use">Setup and Use</a>
* <a href="#🛰️-api-documentation">API Documentation</a>
* <a href="#🤝-contributors">Auxiliary</a>
    * <a href="#🤝-contributors">Contributors</a>
    * <a href="#✉️-contact-and-support">Contact</a>
    * <a href="#⚖️-license">License</a>
------------------------------
## 🌐 About the Project

### 📖 Description
_This is an API that works as a way to create profiles for animals in an imaginary shelter. It has full CRUD capability, meaning that you can look at a list of animals, look for a specific animal, add an animal profile, edit an animal profile, and delete an animal profile. It utilizes versioning, and pagination. Each profile includes a name, species, description, age, and the date the profile was made. This is my thirteenth Epicodus project that is meant to show my knowledge of making an API using C#. Here is a [link](https://github.com/OLGON92/Animal-Shelter-API.Solution) to the repository._
### 🦠 Known Bugs
* _None found_
### 🛠 Built With
* _C#_
* _.NET6_
* _MySQLWorkbench_
* _SQL Database_
* _AspNetCore.Mvc_
* _Visual Studio Code_
* _Swagger_
* _Postman_

<!-- ### 🔍 Preview -->

------------------------------

## 🏁 Getting Started
* _Follow the steps below._
### 📋 Prerequisites

#### Install .NET Core
* _First, you will need to install .NET 6 if it isn't already on your machine_
* _Here is a link where you can download for your Mac, Windows, or Linux based machince: [link](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)_
* _Look in your downloads and open the file_
* _Follow the installation intructions_
* _To confirm the the installation was a success: on your command line in your terminal type "dotnet --version"_

#### Install dotnet script
* _Enter the command ``dotnet tool install -g dotnet-script`` in Terminal for macOS or PowerShell for Windows._

#### Install MySQL Workbench
* _Then you will need to install MySQL. Follow the instructions in here[link](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) to do so._

#### Install Postman
* _(Optional) [Download and install Postman](https://www.postman.com/downloads/)._

#### Code Editor
You will need a code editor to view or edit the code. My favorite, and recommended one is Visual Studio Code.
* _Click this [Link](https://code.visualstudio.com/download)_
* _Choose the the most applicable file to download for your OS_
* _Once downloaded, open the download to complete the setup_

### ⚙️ Setup and Use

  #### Cloning & Downloading
  * _Go to the repository here [link](https://github.com/OLGON92/Animal-Shelter-API.Solution)_
  * _Click "Clone or download" to reveal the HTTPS url ending with .git and the 'Download ZIP' option_
  * _Open up your system Terminal or GitBash, navigate to your desktop with the command: `cd Desktop`, or whichever location suits you best_
  * _Clone the repository to your desktop using: `git clone https://github.com/OLGON92/Animal-Shelter-API.Solution.git`_
  * _Enter the command `cd Animal-Shelter-API.Solution` to reach the project directory_
  * _Enter `code .` to open it up in Visual Studio Code_
  * _Alternatively you can just download it by clicking on "Download Zip" option from before_

  #### AppSettings
  * _Navigate to the 'Animal-Shelter-API.Solution' directory on your computer_
  * _Open it with `code .` and watch as it opens with Visual Studio Code_
  * _From here you will go to the "AnimalShelterApi" Directory_
  * _Create a new file called "appsettings.json"_
  * _In the appsettings.json file you will add the following code below_
  * _*Please note that your username and password is dependent on what you have set up in your MySQLWorkbench.*_
  * _*Also, do not include the brackets []*_
  ```
  {
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter_api;uid=[YourUserNameHere];pwd=[YourPasswordHere];"
    }
  }
  ```
  #### Database
  * _Navigate to 'Animal-Shelter-API.Solution' in your command line_
  * _From there navigate to 'AnimalShelterApi'_
  * _Run the command "dotnet build"_
   _Now you will need to create a migration; run the command "dotnet ef migrations add Initial"_
  * _Anytime you make a change to any of the models, you will have to enter this command "dotnet ef migrations add [ChangeInMigration]" . Please note that the brackets don't need to be there, and words in brackets are an example._
  * _After verifying that the changes are correct enter "dotnet ef database update". If you would like to remove a migration, enter "dotnet ef migrations remove"_
  * _Then run the command "dotnet watch run"_
  * _It should then open the development environment in your preferred web browser automatically_

  #### Launch the API
  * _Navigate to 'Animal-Shelter-API.Solution' in your command line_
  * _From there navigate to 'AnimalShelterApi'_
  * _Run the command `dotnet run` to have access to the API in Postman or browser_
------------------------------

## 🛰️ API Documentation
Explore the API endpoints in Postman or a browser.

### Using Swagger Documentation
* _After entering `dotnet run` in the 'AnimalShelterApi' you will then open your web browser_
* _Type this 'https://localhost:5001/swagger/index.html' in the browser or 'http://localhost:5000/swagger/index.html'

### Note on Versioning
* _There are two different version of this API_
* _If you are using swagger you can click on the top right rectangle that has a 'v1' to switch between the two versions_
* _If you are using Postman you will need to specify which version you are using in the URL_
* _Here are two examples 'https://localhost:5001/api/v1/Animals' and 'https://localhost:5001/api/v2/Animals'_

### Note on Pagination
* _Version 2 is the ONLY version that utilizes pagination_
* _By default it will show you 5 results per page_
* _You can navigate to page two by modifying the page number in the URL_
* _Here's an example 'https://localhost:5001/api/v2/Animals?pageNumber=1&pageSize=5'_
* _To see the default enter the URL like this 'https://localhost:5001/api/v2/Animals'_

..........................................................................................


### Endpoints
These are base URL's:
Base URL: `https://localhost:5000` or `https://localhost:5001`

#### HTTP Request Structure
This is the http request structure.
* Please note that this request structure is for API's that use versioning. For an API that doesn't use versioning you would make it look more like this '/api/{component}'
```
GET /api/{version}/{component}
POST /api/{version}/{component}
GET /api/{version}/{component}/{id}
PUT /api/{version}/{component}/{id}
DELETE /api/{version}/{component}/{id}
```

#### Example Query
```
https://localhost:5001/api/v2/Animals/2
```
#### Sample JSON Response
```
{
  "animalId": 2,
  "name": "Kobe",
  "species": "Dog",
  "description": "Small dog with short, black, brown, and orange fur.",
  "age": 12,
  "dateAdded": "2023-02-12T00:01:37.756"
}

```
..........................................................................................
### Animals
Here I will show you how to utilize GET for all animals, POST, GET for a specific animal, PUT, and DELETE
* Please note that when you 
#### HTTP Request
```
GET /api/v1/animals
POST /api/v1/animals
GET /api/v1/animals/{id}
PUT /api/v1/animals/{id}
DELETE /api/v1/animals/{id}
```

#### Example Query
```
https://localhost:5001/api/v1/Animals/1
```

#### Sample JSON Response
```
{
  "animalId": 1,
    "name": "Izze",
    "species": "Cat",
    "description": "Black and white cat",
    "age": 5,
    "dateAdded": "2023-02-10T20:09:07"
}
```

------------------------------

### 🤝 Contributors

| Author | GitHub | Email |
|--------|:------:|:-----:|
| [Oscar Gonzalez](https://www.linkedin.com/in/oscar-gonzalez-portland-oregon/) | [OLGON92](https://github.com/OLGON92) | [ogon318@gmail.com](mailto:ogon318@gmail.com) |

------------------------------

### ✉️ Contact and Support

If you have any feedback or concerns, please contact me.

<p>
  <a href="https://github.com/OLGON92/Animal-Shelter-API.Solution/issues">Report Bug</a>
  <a href="https://github.com/OLGON92/Animal-Shelter-API.Solution/issues">Request Feature</a>
</p>

------------------------------

### ⚖️ License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2023 Oscar Gonzalez. All Rights Reserved.

```
MIT License

Copyright (c) 2023 Oscar Gonzalez.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

------------------------------
<center><a href="#">Return to Top</a></center>