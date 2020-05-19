# culinary-companion-grocerlink
This grocer link service of the culinary companion is one of main microservices used to power the whole system. 
In this portion a request is made to the get grocerlink endpoint for the name of a grocery. Then the system will 
look up the name of the that grocery item in the Mongo database to find it's unique identifier on amazon. It will then 
return that unique identifier.

Ideally if the item does not appear in the database it would kick off a new workflow that included adding the new
grocery item to the database. 

### Getting Started
Requirements: 
- Ensure you have .Net Core installed. --> https://dotnet.microsoft.com/download
- Also install the IDE of your choice, I highly recommend JetBrains Rider, or Visual Studio

Shouldn't be too much more to getting the software to run other than hitting the run button. Happy debugging!
