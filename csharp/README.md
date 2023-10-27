# To run the project tests

```shell
dotnet test
```

# To be able to run the project:

## Install .NET 5+ (on Linux, macOS or Windows)

https://docs.microsoft.com/en-us/dotnet/core/install/

## Install NuGet (on Linux, macOS or Windows)

https://docs.microsoft.com/en-us/nuget/ 

Note: on Ubuntu just use:

```shell
sudo apt install nuget
``` 

## Install NUnit (on Linux, macOS or Windows)

Note: on Ubuntu just use:

```shell
sudo nuget install NUnit
``` 

 Please be aware that, depending on your installed NuGet package versions, you could need to specify a slightly older NUnit version appending `-Version 3.9` to the NUnit installation command above.

# To recreate the project in case of problems:

* Delete the `csharp` folder
* Recreate the `csharp` folder
* Enter the `csharp` folder
* Run `dotnet new sln`
* Create an `App` folder
* Enter the `App` folder
* Run `dotnet new classlib`
* Rename `Class1.cs` to `Class.cs`
* Write the following code into the `Class.cs` file
  
```
using System;

namespace Interview
{
    public class Class
    {
        public bool Method()
        {
            return true;
        }
    }
}
```

* Go back to parent folder (`csharp`)
* Run `dotnet sln add App/App.csproj`
* Create an `AppTests` folder
* Enter the `AppTests` folder
* Run `dotnet new nunit`
* Rename `UnitTest1.cs` to `TestClass.cs`
* Write the following code into the `TestClass.cs` file

```
using NUnit.Framework;
using Interview;

namespace Interview
{
    [TestFixture]
    public class TestClass
    {
        private Class classInstance;

        [SetUp]
        public void SetUp()
        {
            classInstance = new Class();
        }

        [Test]
        public void TestMethod()
        {
            var result = classInstance.Method();

            Assert.IsTrue(result);
        }
    }
}
```

* Run `dotnet add reference ../App/App.csproj`
* Go back to parent folder (`csharp`)
* Run `dotnet sln add ./AppTests/AppTests.csproj`
