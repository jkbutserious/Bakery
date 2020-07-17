# Pierre's Bakery

#### C# TDD Weekly Project for Epicodus, 7.17.2020

#### By Jeff Kim

## Description

Pierre is a simple, hardworking man. He learned to make le pain (bread) and les patisseries from his father. As luck would have it, he has recently become engaged to the wealthy heirress of a well-known flour empire, which will cut his costs considerably, and he wants to pass the savings on to you, the customer!

This exercise is part of a take-home technical challenge that will demonstrate Jeff's skills in C# development. The end product is a console app that will allow users to input the number of bread and pastries they want and display the total price of their order, along with their discount savings.

## Specs

| Behavior    | Sample Input | Sample Output |
| :---------- | ----- | -----: |
| Program will prompt users to press the 'B' key to add a loaf of bread to their cart | 'B' | "1 loaves of bread" |
| Program will prompt users to press the 'P' key to add a pastry to their cart | 'P' | "1 pastry" |
| Program will calculate the price of an order based on the number of pastries and loaves of bread | 2, 3 | "Total: $16" |
| Program will apply discounts to orders for bread: buy 2 get 1 free | 3, 3 | Total: $16 |
| Program will apply discounts to orders for pastries: buy 1 for $2, or 3 for $5 | 3, 3 | $15 |

## Setup/Installation Requirements

Requirements:
* [.NET Core SDK 2.2](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer)

To use this program:

1. Open your preferred browser.
2. Navigate to https://github.com/jkbutserious/Bakery.Solution.git.
3. Click the **Code** button and click **Download ZIP** to clone the repository to your computer.
4. Open the Windows PowerShell console or the MacOS Terminal and use the 
    
    ```cd [YOUR DOWNLOAD FILEPATH]/Bakery.Solution/Bakery```
    
    command to navigate to the Bakery subdirectory.
5. Use the 

    ```dotnet restore```

    command to install the necessary packages on your computer.

6. Use the 

    ```dotnet run```

    command to run the program.

7. Read the instructions and press 'B' to add a loaf of bread to your cart, 'P' to add a pastry, and 'C' to checkout and see your discount and total price.

8. If you have any issues running this program, please reach out to the developer or troubleshoot at your own risk.

You will receive output in the form of a range of numbers and strings.

To contribute to this project:

1. Open your preferred browser.
2. Navigate to https://github.com/jkbutserious/Bakery.Solution.
3. Log into or sign up for your GitHub account.
4. Click the **Fork** button to copy the repository and all source code.
5. From your forked repository, you can download or clone the repository, by clicking the **Code** button.
  * To clone the repository in Visual Studio Code's terminal, use the command

    ```git clone https://github.com/jkbutserious/Bakery.Solution```
  * To clone the repository in GitHub Desktop, click the **Open in Desktop** option
  * To download the repository, click the **Download ZIP** option, save the archive to your computer, and extract it to the folder of your choice
6. Use your preferred code editor to edit Program.cs, BakedGood.cs, Bread.cs, or Pastry.cs. New classes should be added in the Models subdirectory and should use the ```Bakery.Models``` namespace. **Note**: the following files are C# project files and should not be edited:
  * Bakery.csproj
  * Bakery.Tests.csproj
7. Save any changes you make in your code editor and use your preferred git solution to commit your changes.
8. Push your changes to your forked repository.

## Known Bugs

**Initial Release**
* No known bugs

## Support and contact details

To report any issues with this page or to contribute to this project, contact Jeff Kim at kim2jy@hotmail.com.

## Technologies Used

This page was created using the following technologies:

* C# programming language
* .NET Core SDK 2.2
* Visual Studio Code

### License

Copyright © 2020 Jeffrey Kim

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.