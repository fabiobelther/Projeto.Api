# Projeto Api

This project is a .Net Core 3.1 implementation of Clean Arch with Domain Driven Design concepts.

The Clean Architecture provides a metodology to be used in coding, in order to facilitate code development, allowing a better maintenance, updates and less dependencies.
An important goal of Clean Architecture is to provide to developers a way to organize code encapsulating business logic, but keeps it separate from the delivery mechanism.  

## Project Structure

- Projeto.Api				- Solution 
  - Projeto.Api.Host			- Interface Adapters (Where are the Controllers )
  - Projeto.Api.Domain			- Enterprise Businesse Rules (Where are the Entities, Constraints and Interfaces)
  - Projeto.Api.Service			- Application Businesse Rules
  - Projeto.Api.Service.Test		- Unit Test for Application Businesse Rules
  - Projeto.Api.Service.IntegrationTest	- Integration Tests

## Getting Started

To clone this project you need to install [Git](https://git-scm.com).
To run this project you need to download [Visual Studio Code](https://code.visualstudio.com) or [Visual Studio 2019](https://visualstudio.microsoft.com/) and have instaled [.net core 3.1 SDK](https://dotnet.microsoft.com/download/dotnet-core) in your operating system.

### Cloning

Go to path and run the command on GitBash terminal

```powershell
git clone https://github.com/fabiobelther/Projeto.Api.git
```

### Running

Go to root of application and run the commands on GitBash terminal

```powershell
dotnet build;
```

```powershell
cd Projeto.API.Host; 
```

```powershell
dotnet run;
```

The main page should open automatically. If not, go to:
[Swagger - Projeto.Api](https://localhost:5001/swagger/index.html)


## Running the tests

in the root of apllication run the command:

```powershell
dotnet test
```

## Built With

* [.Net Core Framework](https://dotnet.microsoft.com/download/dotnet-core) - Free, cross-platform, open-source framework;
* [xUnit](https://xunit.net) - Tests
* [Clean Arch](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html) - Clean Architeture concepts

## Contributings

## Authors

* **Fabio Belther** - *Initial work* - [FabioBelther](https://github.com/fabiobelther/)

See also the list of [contributors](https://github.com/fabiobelther/Projeto.Api/contributors) who participated in this project.

