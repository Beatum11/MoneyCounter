# Finance manager app

In this project I dived a little more into:

- C# | ASP.NET Core MVC | .NET 6
- Dynamic objects
- Blazor
- Bootstrap | CSS
________________________

# Project overview

- Main Page
![Снимок экрана (56)](https://user-images.githubusercontent.com/106334144/184122763-da1b5594-f856-43ed-a5dd-f48609311e85.png)

The simplest design ever. 
You can check your limit, how much is spent and how much money is left.

Also, you can add a new Purchase. 
_________________________

- Settings Page
![Снимок экрана (55)](https://user-images.githubusercontent.com/106334144/184124984-21bc8aa3-8715-4c30-830d-5a71b81663f4.png)
You can add your limit, and it will dynamically change after returning to main page.
__________________________

- New Purchase Page

![Снимок экрана (57)](https://user-images.githubusercontent.com/106334144/184125866-418a3ec5-edf9-49a7-ac2c-00cd3bf2715e.png)
You can add a theme / category of your purchase + amount of money that you spend + date. 
___________________________

- Final look at Main Page
![Снимок экрана (59)](https://user-images.githubusercontent.com/106334144/184126250-8e7f9c51-5878-433a-a53d-d0b0fe7f6464.png)

It was quite difficult to synchronize the spend section with the actual spending. 
And I decided to use a simple List to store the data, because I use EF Core almost everywhere=)
