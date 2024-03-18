# ![Cinemate logo](https://github.com/LiekeValkBlink/Cinemate/blob/main/Cinemate.Web/wwwroot/images/cinemate-favicon.svg) Cinemate 

## Table of contents
* About
* Getting started
* Contact
* Contributors

## About
The app is a modern cinema reservation system built with Blazor, a .NET web framework. 
It allows users to browse available movies, select showtimes, reserve seats, and purchase tickets online. 
The system features interactive seat selection, dynamic pricing based on ticket type and additional amenities, and support for both regular and secret movie screenings. 

Admins have access to backend functionalities such as managing movie categories, screening schedules, and theater room configurations. 
With its user-friendly design and comprehensive features, the app provides a seamless cinema booking experience for both customers and administrators.

### Key features
* :movie_camera: Movie Selection: Users can browse through a variety of available movies, view details such as title, genre, duration, and ratings.
* :movie_camera: Showtime Selection: Users can select preferred showtimes for their chosen movies, including date and time.
* :movie_camera: Seat Reservation: Interactive seat selection interface allows users to choose their desired seats in the theater room.
* :movie_camera: Ticket Purchase: Seamless online ticket purchasing process, including secure payment options and receipt generation.
* :movie_camera: Admin Panel: Backend interface for administrators to manage movie categories, screening schedules, theater rooms, and user reservations.
* :movie_camera: Secret Movie Screenings: Special feature for secret movie screenings, with unique pricing and ticketing options.

### Tech stack
<p align="left"> 

<a href="https://azure.microsoft.com/en-in/" target="_blank" rel="noreferrer"> <img src="https://www.vectorlogo.zone/logos/microsoft_azure/microsoft_azure-icon.svg" alt="azure" width="40" height="40"/> </a> 
<a href="https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor" target="_blank" rel="noreferrer"> <img src="https://seeklogo.com/images/B/blazor-logo-B6B0844B72-seeklogo.com.png" alt="html5" width="40" height="40"/> </a> 
<a href="https://www.w3schools.com/cs/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" alt="csharp" width="40" height="40"/> </a> 
<a href="https://dotnet.microsoft.com/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/dot-net/dot-net-original-wordmark.svg" alt="dotnet" width="40" height="40"/> </a> 
</p>
<p align="left"> 
<a href="https://www.w3.org/html/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/html5/html5-original-wordmark.svg" alt="html5" width="40" height="40"/> </a> 
<a href="https://www.w3schools.com/css/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/css3/css3-original-wordmark.svg" alt="css3" width="40" height="40"/> </a>
<a href="https://getbootstrap.com" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/bootstrap/bootstrap-plain-wordmark.svg" alt="bootstrap" width="40" height="40"/> </a> 
<a href="https://www.figma.com/" target="_blank" rel="noreferrer"> <img src="https://www.vectorlogo.zone/logos/figma/figma-icon.svg" alt="figma" width="40" height="40"/> </a> 
</p>
<img src="https://www.vectorlogo.zone/logos/git-scm/git-scm-icon.svg" alt="git" width="40" height="40"/> </a> 
<a href="https://www.postgresql.org" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/postgresql/postgresql-original-wordmark.svg" alt="postgresql" width="40" height="40"/> </a> 


## Getting started

### Prerequisites
* Postgres database
* Git
* C# IDE (example: Rider / Visual Studio)

### Installation
1. Navigate to the desired directory and clone the repository
```bash
git clone https://github.com/JeroenP98/carhop.git
```

2. Start up your PostgreSQL database and run command
```postgresql
CREATE DATABASE cinemate;
```

3. In your IDE, delete any migration directory's at cinemate.api/migrations
4. In your terminal run the commands to refresh the seed data and fill the database
```bash
dotnet ef migrations add SeedData
dotnet ef database update
```
5. Your application should be good to go! Start both the .API and .WEB applications to get movie watching! :thumbsup:

## Contact :email:
We're continuously working to enhance your Cinemate experience. If you have any questions, encounter issues, or want to provide feedback, please feel free to reach out or create an issue in this repository.


## Contibutors :handshake:
<table>
  <tr>
    <td align="center"><a href="https://github.com/LiekeValkBlink"><img src="https://avatars.githubusercontent.com/u/126764966?v=4" width="100px;" alt="Jeroen Post"/><br /><sub><b>Lieke Valk</b></sub></a><br /></td>
    <td align="center"><a href="https://github.com/Janvanderwaal"><img src="https://avatars.githubusercontent.com/u/63095898?v=4" width="100px;" alt="Jan van der Waal"/><br /><sub><b>Jan van der Waal</b></sub></a><br /></td>
    <td align="center"><a href="https://github.com/CorbaDesign"><img src="https://avatars.githubusercontent.com/u/97983491?v=4" width="100px;" alt="Jan van der Waal"/><br /><sub><b>Corina Bakker</b></sub></a><br /></td>
    <td align="center"><a href="https://github.com/JeroenP98"><img src="https://avatars.githubusercontent.com/u/104794195?v=4" width="100px;" alt="Jan van der Waal"/><br /><sub><b>Jeroen Post</b></sub></a><br /></td>
    <td align="center"><a href="https://github.com/LordNuget"><img src="https://avatars.githubusercontent.com/u/67593584?v=4" width="100px;" alt="Jan van der Waal"/><br /><sub><b>Milan Toen</b></sub></a><br /></td>
    </tr>
</table>
