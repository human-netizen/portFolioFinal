# Portfolio Website

## Overview

This is a professional portfolio website built using ASP.NET Core MVC. The project showcases my skills, experience, and projects in a clean and interactive interface. The application features a responsive design, dynamic content loading from a database, and a contact form for visitor interactions.

## Features

- **Profile Section**: Personal introduction and social media links
- **About Me**: Detailed professional summary
- **Timeline**: Educational and career journey
- **Skills Showcase**: Visual representation of technical skills with progress bars
- **Projects Gallery**: Dynamic display of personal and professional projects
- **Contact Form**: Interactive form for visitors to send messages
- **Admin Panel**: Secure area for content management (projects and skills)
- **Responsive Design**: Mobile-friendly interface

## Technologies Used

### Backend
- **ASP.NET Core 8.0**: Modern, cross-platform framework for building web applications
- **Entity Framework Core**: ORM for database interactions
- **C#**: Primary programming language
- **SQL Server**: Database for storing portfolio data

### Frontend
- **HTML5/CSS3**: Markup and styling
- **Bootstrap**: Responsive design framework
- **JavaScript**: Client-side interactivity
- **Razor Views**: Server-side rendering

## Project Structure

```
PortFolioFInal.sln
README.md
LICENSE
PortFolioFInal/
├── Controllers/    Handle user requests and business logic
├── Models/         Data structures for projects, skills, categories, contact forms
├── Views/          Razor UI templates, organized by controller
├── Data/           EF Core database context and seed data
├── Migrations/     EF Core schema migrations
└── wwwroot/        Static files (CSS, JS, images, client libraries)
```

## Database Schema

The application uses the following data models:
- **Projects**: Portfolio projects with name, description, and links
- **Skills**: Technical abilities with proficiency levels
- **Categories**: Groupings used to organise projects
- **ContactModels**: Form submissions from visitors

## Installation and Setup

1. Clone the repository
2. Ensure the .NET 8.0 SDK is installed
3. Configure your database connection string. The default in `appsettings.json`
   points at SQL Server LocalDB and works as-is; override it if needed:
   ```
   cd PortFolioFInal
   dotnet user-secrets set "ConnectionStrings:DefaultConnection" "<your connection string>"
   ```
4. Set the admin panel credentials. These are read from configuration and are
   **not** committed to the repository; without them the admin login is disabled:
   ```
   dotnet user-secrets set "Admin:Username" "<your username>"
   dotnet user-secrets set "Admin:Password" "<your password>"
   ```
5. Run database migrations:
   ```
   dotnet ef database update
   ```
6. Run the application:
   ```
   dotnet run
   ```

## Future Enhancements

- Blog section to share technical articles
- Dark mode toggle
- Project filtering and search
- Integration with GitHub API to showcase repositories
- Performance optimizations

## Contact

Niloy Das
- LinkedIn: [Niloy Das](https://www.linkedin.com/in/niloy-das-58902624b/)
- GitHub: [human-netizen](https://github.com/human-netizen)


## License

Released under the MIT License. See [LICENSE](LICENSE).
