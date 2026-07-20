# Steam Info Puller - C#

A C# application that retrieves Steam user information using the **Steam Web API**.

The application can collect information such as:

- Steam profile data
- Player name
- Avatar
- Online status
- Owned games
- Playtime information

The project is built with **C#**, **.NET**, and the official **Steam Web API**.

---

# Features

## Steam Profile Information

- Retrieve Steam user profile
- Get Steam ID
- Display username
- Get profile avatar
- Get online status


## Game Information

- Retrieve owned games
- Display game names
- Display playtime
- Calculate played hours


## API Integration

- Steam Web API integration
- HTTP requests
- JSON parsing
- Async programming


---

# Technologies

| Technology | Usage |
|---|---|
| C# | Programming language |
| .NET 8 | Application framework |
| Steam Web API | Data source |
| Newtonsoft.Json | JSON processing |
| HttpClient | API communication |
| Rider / Visual Studio | Development environment |

---

# Project Structure

```
SteamInfoPuller

│
├── Program.cs
│
├── SteamApiClient.cs
│
├── Models
│   ├── SteamPlayer.cs
│   └── SteamGame.cs
│
├── appsettings.json
│
└── README.md
```

---

# Requirements

Install:

- .NET SDK 8
- JetBrains Rider or Visual Studio
- Steam Account
- Steam Web API Key


Check .NET installation:

```bash
dotnet --version
```

---

# Create Project

Create a new console project:

```bash
dotnet new console -n SteamInfoPuller
```

Navigate into the project:

```bash
cd SteamInfoPuller
```

Install required package:

```bash
dotnet add package Newtonsoft.Json
```

---

# Steam API Key

A Steam Web API Key is required.

Create your API key:

```
https://steamcommunity.com/dev/apikey
```

Store your key:

`appsettings.json`

```json
{
  "SteamApiKey": "YOUR_API_KEY"
}
```

---

# Configuration

Example:

```json
{
  "SteamApiKey": "123456789ABCDE"
}
```

Never upload your API key publicly.

Recommended:

- Use environment variables
- Use user secrets
- Add appsettings.json to .gitignore

---

# Steam API Endpoints

## Player Information

Endpoint:

```
ISteamUser/GetPlayerSummaries
```

Returns:

- Steam ID
- Username
- Avatar
- Online status


Example:

```
GET

https://api.steampowered.com/ISteamUser/GetPlayerSummaries/v2/
```

---

## Owned Games

Endpoint:

```
IPlayerService/GetOwnedGames
```

Returns:

- Game list
- App IDs
- Playtime


Example:

```
GET

https://api.steampowered.com/IPlayerService/GetOwnedGames/v1/
```

---

# Usage

Start application:

```bash
dotnet run
```

Example output:

```
Name: Gamer123

Avatar:
https://avatars.steamstatic.com/example.jpg


Games:

Counter-Strike 2
850 Hours

Cyberpunk 2077
70 Hours

Minecraft
230 Hours
```

---

# Application Flow

```
User

 |

 |

Steam ID

 |

 |

SteamApiClient

 |

 |

Steam Web API

 |

 |

JSON Response

 |

 |

C# Models

 |

 |

Console Output
```

---

# Example Code Usage

```csharp
var steam =
new SteamApiClient(apiKey);


var player =
await steam.GetPlayer(steamId);


Console.WriteLine(
player.PersonaName);
```

---

# Models

## SteamPlayer

Contains:

```text
SteamId
PersonaName
AvatarFull
PersonaState
```

---

## SteamGame

Contains:

```text
AppId
Name
PlaytimeForever
```

---

# Development

Open project:

```
File
 -> Open
 -> SteamInfoPuller
```

Restore packages:

```bash
dotnet restore
```

Build:

```bash
dotnet build
```

Run:

```bash
dotnet run
```

---

# Useful Commands

Build:

```bash
dotnet build
```

Clean:

```bash
dotnet clean
```

Run tests:

```bash
dotnet test
```

Show information:

```bash
dotnet --info
```

---

# GitHub Setup

Initialize repository:

```bash
git init
```

Add files:

```bash
git add .
```

Commit:

```bash
git commit -m "Initial Steam Info Puller"
```

Add remote:

```bash
git remote add origin YOUR_REPOSITORY_URL
```

Push:

```bash
git push -u origin main
```

---

# Security

Recommended improvements:

- Do not publish API keys
- Use environment variables
- Validate Steam IDs
- Handle API errors
- Add request limits
- Store data securely

---

# Possible Future Features

## Dashboard

- ASP.NET Core Web Dashboard
- User login
- Steam profile pages


## Database

- MySQL integration
- Save player data
- Save game history


## Analytics

- Total playtime charts
- Most played games
- Activity statistics


## Integrations

- Discord Bot
- Twitch integration
- Steam notifications


## Advanced Features

- Achievement tracker
- Friend list viewer
- Inventory viewer
- Price calculator
- Multiple Steam accounts


---

# License

MIT License


---

# Author

Created as a learning project using:

- C#
- .NET
- Steam Web API
- JSON
- REST API Development
