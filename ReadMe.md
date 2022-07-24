# Pierre's Bakery

### Arthur Edward Ortiz

## Assignment Description Description

## Stage One

Create a C# console application for a bakery that includes the following functionality:

* There should be two classes: one for Bread and one for Pastry.

* When the user runs the application, they should receive a prompt with a welcome message along with the cost for both Bread and Pastry.

* A user should be able to specify how many loaves of Bread and how many Pastrys they'd like.

* The application will return the total cost of the order.

Pierre offers the following deals:

Bread: Buy 2, get 1 free (every 3rd loaf of bread is free.). A single loaf costs $5, two loaves costs $10, and three loaves cost $10.
Pastry: Buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10.
All functionality for the models should be tested.

## Stage Two
Pierre was so pleased with your console app for his bakery that he wants to hire you for a new project. This time, he would like you to build him an MVC application to help him track the vendors that purchase baked goods from him and the orders belonging to those vendors.

For example, Pierre might supply croissants to a vendor called "Suzie's Cafe" once a week. Pierre may want to create a new Vendor to represent the cafe and add new Orders to it to help keep track of his expanding business relationships.

Use Razor to display information on each page.

* Create a Vendor class. This class should include properties for the vendor's name, a description of the vendor, a List of Orders belonging to the vendor, and any other properties you would like to include.
* Create an Order class. This class should include properties for the title, the description, the price, the date, and any other properties you would like to include.
* The homepage of the app at the root path (localhost:5000/) should be a splash page welcoming Pierre and providing him with a link to a Vendors page.
* The vendors page should contain a link to a page presenting Pierre with a form he can fill out to create a new Vendor. After the form is submitted, the new Vendor object should be saved into a static List and Pierre should be routed back to the homepage.
* Pierre should be able to click a Vendor's name and go to a new page that will display all of that Vendor's orders.
* Pierre should be provided with a link to a page presenting him with a form to create a new Order for a particular Vendor. Hint: The route for this page might look something like: "/vendors/1/orders/new".


## Technologies Used

* C sharp
* Dotnet 
* MSTest
* Razor

## Setup//Install

1.) Clone repository to your local computer. 
2.) Open project directory. 
3.) type `donet restore` into the terminal and hit enter.
4.) type `dotnet build` into the terminal and hit enter.
5.) tyoe `dotnet run` into the terminal to run the program

## Known Bugs

* negative number can be entered but will return 0$. 

 ## License 

 Copyright (c) July 2, 2022 Arthur Edward Ortiz,  MIT
