# SteamInfoPuller

![License](https://img.shields.io/badge/license-MIT-blue)
![Platform](https://img.shields.io/badge/platform-Windows-lightgrey)
![Language](https://img.shields.io/badge/language-C%23-purple)
![Framework](https://img.shields.io/badge/framework-WPF%20.NET-blue)

# Übersicht

**SteamInfoPuller** ist eine C#-Anwendung zum Abrufen, Analysieren und Anzeigen von Steam- und CS2-Profilinformationen.

Das Projekt kombiniert einen Steam-Daten-Puller mit einer modernen WPF-Oberfläche im Steam/CS2-Stil.

Neben normalen Steam-Profilinformationen bietet die Anwendung ein CS2-Analyse-Dashboard mit:

- VAC Status
- Game Ban Prüfung
- CS2 Spielzeit
- Competitive Rank
- Premier Rating
- FACEIT Statistiken
- Leetify Performance
- Match History
- K/D Analyse
- Spieler Watchlist

---

# Features

## Steam Profil

- SteamID64 Unterstützung
- Benutzername anzeigen
- Profilbild laden
- Steam-Profil-Link anzeigen
- Steam-Level Anzeige
- Online-Status
- Accountinformationen

---

# Spielebibliothek

- Alle Spiele eines Profils laden
- Spielname anzeigen
- Steam AppID Unterstützung
- Spielzeit erfassen
- Sortierung nach Spielzeit vorbereiten

---

# CS2 Profile Analyzer

## Sicherheit

- VAC Ban Prüfung
- Game Ban Prüfung
- Ban Status Anzeige
- Risikoanalyse für Profile

Beispiel:

```
VAC Status:
✓ Clean

Game Ban:
✓ Keine Bans
```

---

# CS2 Statistiken

## Competitive Rank

Anzeige des aktuellen CS2 Ranks:

- Silver
- Gold Nova
- Master Guardian
- Legendary Eagle
- Supreme
- Global Elite

---

## Premier Rating

Anzeige des CS2 Premier Ratings mit farblicher Darstellung:

| Rating | Farbe |
|-|-|
| 0 - 5000 | Grau |
| 5000 - 10000 | Blau |
| 10000 - 15000 | Violett |
| 15000 - 20000 | Pink |
| 20000+ | Orange/Rot |

Beispiel:

```
Premier Rating

18500
★★★★★
```

---

# FACEIT Integration

Unterstützung für FACEIT Profilinformationen:

- FACEIT Level
- FACEIT Elo
- Spielername
- Performance-Daten


Beispiel:

```
FACEIT

Level 10

ELO:
2200
```

---

# Leetify Integration

Performance Analyse:

- Leetify Score
- Aim Score
- Utility Score
- Positioning Score
- Performance Tracking


Beispiel:

```
Leetify

Score: 92

Aim:
88

Utility:
76

Positioning:
85
```

---

# Match History

CS2 Match Analyse:

- Letzte Spiele
- Map Anzeige
- Win/Loss Status
- Kills
- Deaths
- Assists
- K/D Berechnung


Beispiel:

```
Last Matches

Mirage
WIN
28 / 14
KD 2.0


Inferno
LOSS
17 / 20
KD 0.85
```

---

# Watchlist System

Profile können zur Beobachtung gespeichert werden.

Features:

- SteamID speichern
- Spielername speichern
- Notizen
- Risiko-Level
- Prüfdatum
- Erneute Analyse


Beispiel:

```
Watchlist

Player123

Risk:
Medium

Grund:
Ungewöhnliche Statistik
```

---

# Benutzeroberfläche

- Moderne WPF GUI
- Steam Dark Theme
- CS2 Dashboard
- Profilkarten
- Statistik-Karten
- Farbige Rank-Anzeige
- MVVM Architektur
- Responsive Layout

---

# Projektstruktur

```
SteamInfoPuller
│
├── Core
│   ├── SteamApi.cs
│   ├── SteamInfoPuller.cs
│   ├── CS2ProfileChecker.cs
│   ├── RiskAnalyzer.cs
│   ├── FaceitApi.cs
│   └── LeetifyApi.cs
│
├── Models
│   ├── SteamUser.cs
│   ├── SteamGame.cs
│   ├── CS2Profile.cs
│   ├── CS2Match.cs
│   ├── WatchlistEntry.cs
│   └── RiskReport.cs
│
├── ViewModels
│   ├── MainViewModel.cs
│   └── CS2ViewModel.cs
│
├── GUI
│   ├── MainWindow.xaml
│   ├── CS2AnalyzerWindow.xaml
│   ├── WatchlistWindow.xaml
│   │
│   └── Styles
│       └── SteamTheme.xaml
│
├── App.xaml
├── App.xaml.cs
│
└── changes.xml
```

---

# Voraussetzungen

- Windows 10/11
- .NET 8 oder höher
- Visual Studio 2022
- Steam Web API Key
- FACEIT API Key (optional)
- Leetify API Zugriff (optional)

---

# Installation

## Repository klonen

```bash
git clone https://github.com/alizedev/steaminfopuller.git
```

---

## Abhängigkeiten installieren

Projekt in Visual Studio öffnen:

```
Build → Restore NuGet Packages
```

---

# Steam API Key

Steam API Key erstellen:

```
https://steamcommunity.com/dev/apikey
```

Danach Key in der Anwendung konfigurieren.

---

# Verwendung

1. Anwendung starten

2. SteamID64 eingeben

Beispiel:

```
76561198000000000
```

3. Auf **Laden** klicken

4. Steam Profil wird analysiert

5. CS2 Dashboard zeigt Statistiken

---

# Architektur

```
GUI
 |
 v
ViewModel
 |
 v
Core Services
 |
 +---- Steam API
 |
 +---- FACEIT API
 |
 +---- Leetify API
 |
 v
Models
```

---

# Technologie

| Bereich | Technologie |
|-|-|
| Sprache | C# |
| GUI | WPF |
| Pattern | MVVM |
| Framework | .NET 8 |
| Steam Daten | Steam Web API |
| Format | JSON |
| Plattform | Windows |

---

# Changelog

Siehe:

```
changes.xml
```

Aktuelle Version:

```
0.2.0
```

---

# Screenshots

CS2 Dashboard Screenshot folgt.

Geplant:

- Steam Profil Ansicht
- CS2 Analyzer
- FACEIT Anzeige
- Premier Rank Farben
- Watchlist Dashboard

---

# Lizenz

Dieses Projekt steht unter der MIT Lizenz.

---

# Credits

Steam Daten werden über die offizielle Steam Web API geladen.

FACEIT und Leetify Daten benötigen eigene API-Zugriffe.

Steam ist eine Marke der Valve Corporation.
```