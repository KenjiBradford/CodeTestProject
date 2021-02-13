# CodeTestProject

The key files are:
- Interface.cs - the interface and an implementation of it
- Statup.cs - added the implementation to the services collection
- OffersController.cs - added the interface to the constructor for DI, and called the interface to return the records that match the search criteria (if there is a search string, otherwise returns all offers).
- Index.cshtml (Views/Offers) - Added form at top with a text box and submit button to accept filter criteria
- Program.cs & SeedData.cs - Where implement a build step that seeds the data
