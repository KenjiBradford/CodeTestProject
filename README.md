# CodeTestProject

The key files are:
- Interface.cs - the interface and an implementation of it
- Statup.cs - added the implementation to the services collection
- OffersController.cs - added the interface to the constructor for DI, and called the interface to return the records that match the search criteria (if there is a search string, otherwise returns all offers).
- Index.cshtml (Views/Offers) - Added form at top with a text box and submit button to accept filter criteria
- Program.cs & SeedData.cs - Where implement a build step that seeds the data

Specs:
MVC and OOP fundamentals
- Create an MVC web application
- Part I Create a class named "Offer" with two properties:OfferNameValidProductsCreate a method to return Offer data:  
Populate two Offer objects with OfferName and ValidProducts data - values should be assigned in code and meet the following requirements:  
Each Offer should have a different OfferNameEach Offer should have a different set of three strings for ValidProducts    
Return a list of Offers  
- Part II Render the Offer data in a viewCreate a textbox in the view to accept search criteriaCreate a button in the view that will trigger the comparison of the search criteria against any of the ValidProducts and display any Offer object containing at least one matching ValidProduct - Part III 
Create an Offer service that implements an interface that:Gets the sample Offer dataAccepts the search criteria and returns any Offers containing ValidProducts that match the search criteriaInject the service into your controller and use it to return the Offers     
