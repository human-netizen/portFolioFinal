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

- **Models**: Define data structure for projects, skills, contact forms
- **Views**: UI templates organized by controller
- **Controllers**: Handle user requests and business logic
- **Data**: Database context and migrations
- **wwwroot**: Static files (CSS, JS, images)

## Database Schema

The application uses the following data models:
- **Projects**: Portfolio projects with name, description, and links
- **Skills**: Technical abilities with proficiency levels
- **Contact**: Form submissions from visitors

## Installation and Setup

1. Clone the repository
2. Ensure .NET 8.0 SDK is installed
3. Configure your database connection string in `appsettings.json`
4. Run database migrations:
   ```
   dotnet ef database update
   ```
5. Run the application:
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
- Email: [Your Email Address]

---

© 2025 Niloy Das. All Rights Reserved.