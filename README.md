# Dr.Sillystringz's Factory

#### Dr.Sillystringz's factory is a web application that helps keep track of engineers repairing machines and different machines that need engineers.
#### By Donovan Weber 

## Technologies Used

* C#
* .NET 5
* Entity Core Framework
* Markdown
* ASP.NET Core
* Razer
* Linq


## Description
This web application uses C# and other HTML helper methods to create a live website that a user can add engineers based on which machines need repairing and the ability to add machines with already added engineers.  A user can also delete, edit and view details of each added engineer and edit, delete and view details of each machine. 

## Setup/Installation Requirements

* Navigate to `https://github.com/DonovanWeber/Sillystringz-Factory.Solution`
* Click on the green "Code" button and copy the repository URL or click on the copy button
* Open the terminal on your desktop
* Once in the terminal, use it to navigate to your desktop folder
* Once inside your desktop folder, use the command `git clone https://github.com/DonovanWeber/Sillystringz-Factory.Solution`
* After cloning the project, navigate into it using the command `cd Sillystringz-Factory.Solution`
* Then run `cd Factory` and create an appsettings file by running `touch appsettings.json` in the terminal 
* Inside of the appsetting.json file add your database by writing in => `{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=donovan_weber;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
}
` add your password for mysql in the associated sections above
* Then run `cd Factory` and run `dotnet restore` inside of the testing directory to build out the objects folder
* Then  navigate to the same directory run `dotnet build`
* After you build the application go back into the terminal and run `dotnet run` to start the application 
* Copy and paste the first http://localhost:5000 and paste it into your browsers url to run



## Known Bugs
* No known bugs if any are found please 
contact me at [donovanweber03@gmail.com](mailto:donovanweber03@gmail.com) if any bugs are found.


## License

[MIT](https://choosealicense.com/licenses/mit/)