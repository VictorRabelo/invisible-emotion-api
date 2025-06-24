# Invisible Emotion Detector

Invisible Emotion Detector is a Web API inspired by neutrino physics. It allows users to capture daily emotional inputs and reveals subtle patterns over time. The project follows Clean Architecture principles and uses ASP.NET Core 8 with Entity Framework Core and JWT authentication.

## Getting Started

### Prerequisites
* .NET 8 SDK

### Running Locally
```bash
# Restore dependencies
dotnet restore

# Run database migrations (if any)
dotnet ef database update --project src/Infrastructure --startup-project src/Api

# Start the API
dotnet run --project src/Api
```
The API will be available at `https://localhost:5001` by default.

## API Usage

### Register
`POST /api/auth/register`
```json
{
  "userName": "alice",
  "email": "alice@example.com",
  "password": "Pass123$"
}
```

### Login
`POST /api/auth/login`
```json
{
  "userName": "alice",
  "password": "Pass123$"
}
```
Response contains a JWT token:
```json
{
  "token": "{jwt}" 
}
```
Include this token in the `Authorization` header as `Bearer {jwt}` to access protected endpoints.

### Submit Emotion Input
`POST /api/emotion-inputs`
```json
{
  "emotion": "happy",
  "description": "Sunshine outside"
}
```

### Get Patterns
`GET /api/emotion-patterns`

### Get Insights
`GET /api/insights`

## Project Structure
```
src/
  Api/            # Presentation layer (controllers, Program.cs, Swagger)
  Application/    # DTOs, services and interfaces
  Domain/         # Core domain entities and interfaces
  Infrastructure/ # Persistence and repository implementations
```

## Authentication Details
The API uses JWT bearer tokens. On successful login, include the token in the `Authorization` header of subsequent requests. Swagger UI is configured to accept the token for testing.

## Technologies Used
* .NET 8 Web API
* Entity Framework Core with SQLite
* Swagger (Swashbuckle)
* JWT Authentication

## License
This project is licensed under the MIT License.
