# HemsidaTomtar

projektet är en enkel ASP.NET Core MVC app som visar  Frontpage, personal och produkter för ”Tre Träiga Tomtar”. Appen använder mockade repositories för att skicka data till vyerna.


# Klona och installera i din konsol
```bash
git clone https://github.com/99alfons-stack/HemsidaTomtar.git
cd HemsidaTomtar
```


# Köra lokalt
Från projektroten:
```bash
dotnet run
dotnet watch 
```
(Använd Dotnet Watch för att slippa starta om projektet efter varje ändring!)

Applikationen startar på på din LocalHost Kolla terminalutskriften för exakt URL. Länken kan du koppiera och klista in i din sökrutan på din webbapplikation

# Projektstruktur 
- `Program.cs`  konfiguration av services
- `Controllers/`  MVC-kontrollers (Home, Staff, Product)
- `Models/`  modeller och mock-repositories
- `Views/`  Razor Views
- `wwwroot/`  statiska filer (CSS, JS, bilder)



