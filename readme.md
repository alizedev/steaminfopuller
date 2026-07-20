# SteamInfoPuller

![License](https://img.shields.io/badge/license-MIT-blue)
![Platform](https://img.shields.io/badge/platform-Windows-lightgrey)
![Language](https://img.shields.io/badge/language-C%23-purple)
![Framework](https://img.shields.io/badge/framework-WPF%20.NET-blue)

## Übersicht

**SteamInfoPuller** ist eine C#-Anwendung zum Abrufen und Anzeigen von Steam-Profilinformationen.

Das Projekt kombiniert einen Steam-Daten-Puller mit einer modernen WPF-Oberfläche im Steam-Stil.

Die Anwendung lädt Steam-Benutzerdaten, Spieleinformationen und stellt diese übersichtlich in einer grafischen Oberfläche dar.

---

## Features

### Steam Profil

- SteamID64 Unterstützung
- Benutzername anzeigen
- Profilbild laden
- Steam-Profil-Link anzeigen
- Steam-Level Anzeige
- Online-Status

### Spielebibliothek

- Alle Spiele eines Profils laden
- Spielname anzeigen
- Spielzeit erfassen
- Sortierung vorbereiten
- Steam AppID Unterstützung

### Benutzeroberfläche

- Moderne WPF GUI
- Steam Dark Theme
- Profilübersicht
- Spiele-Tabelle
- MVVM-Struktur

### Geplant

- [ ] Achievements anzeigen
- [ ] Spielcover laden
- [ ] Export als JSON
- [ ] Export als CSV
- [ ] Mehrere Steam-Profile speichern
- [ ] Automatische Aktualisierung
- [ ] Tray-Icon

---

# Projektstruktur

```
SteamInfoPuller
│
├── Core
│   ├── SteamApi.cs
│   └── SteamInfoPuller.cs
│
├── Models
│   ├── SteamUser.cs
│   └── SteamGame.cs
│
├── ViewModels
│   └── MainViewModel.cs
│
├── GUI
│   ├── MainWindow.xaml
│   ├── MainWindow.xaml.cs
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

---

# Installation

## Repository klonen

```bash
git clone https://github.com/alizedev/steaminfopuller.git
```

---

## Abhängigkeiten installieren

Projekt in Visual Studio öffnen und NuGet-Pakete wiederherstellen:

```
Build → Restore NuGet Packages
```

---

# Steam API Key

Für private Profildaten wird ein Steam API Key benötigt.

Erstellen kannst du diesen hier:

```
https://steamcommunity.com/dev/apikey
```

Danach den Key in der Anwendung konfigurieren.

---

# Verwendung

1. Anwendung starten

2. SteamID64 eingeben

Beispiel:

```
76561198000000000
```

3. Auf **Laden** klicken

4. Steam-Daten werden geladen und angezeigt

---

# Architektur

Das Projekt ist in mehrere Ebenen getrennt:

```
GUI
 |
 v
ViewModel
 |
 v
SteamInfoPuller
 |
 v
SteamApi
 |
 v
Steam Web API
```

## Komponenten

### SteamApi.cs

Verantwortlich für:

- HTTP-Anfragen
- Steam API Kommunikation
- JSON Verarbeitung


### SteamInfoPuller.cs

Verantwortlich für:

- Zusammenführen der Daten
- Erstellen eines vollständigen SteamProfils


### SteamUser.cs

Speichert:

- SteamID
- Username
- Avatar
- Level
- Spieleliste


### SteamGame.cs

Speichert:

- AppID
- Name
- Spielzeit
- weitere Spieldaten


---

# Technologie

| Bereich | Technologie |
|-|-|
| Sprache | C# |
| GUI | WPF |
| Pattern | MVVM |
| API | Steam Web API |
| Datenformat | JSON |
| Plattform | Windows |

---

# Changelog

Siehe:

```
changes.xml
```

Aktuelle Version:

```
0.1.0
```

---

# Screenshots

Folgen nach Fertigstellung der GUI.

---

# Lizenz

Dieses Projekt steht unter der MIT Lizenz.

---

# Credits

Steam Daten werden über die offizielle Steam Web API geladen.

Steam ist eine Marke der Valve Corporation.
```