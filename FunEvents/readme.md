ASP .NET Core

ASP .NET Core är ett utvecklings-plattform som är cross-platform, alltså funkar på olika typer av enheter och operativsystem.
Det används till att skapa webbapplikationer gratis med inbyggd källkodsram. 
Man kan välja olika templates för olika användningsområden samt hur mycket kod man vill ha "gratis".

STARTUP är en klass som finns i ett ASP .NET Core projekt som innehåller några metoder som kallas på när appen startas, 
efter att appens host byggts. I ConfigureServices metoden används service-parametern för att lägga till services i appen, 
t.ex. lägger den till razor pages, och man kan skapa en connection där till sin databas med hjälp av din databas-context klass.
Configure metoden används för att svara på appens http-requests.

WWWROOT mappen innehåller appens statiska filer, så som css, javascript, bilder och scripts.

RAZOR-SPRÅKET som används i ASP .NET Core är en kombination av programspråk (C# och HTML), när appen körs omvandlas koden till bara HTML. 
Symbolen @ används för att skriva C# kod i HTML koden. Man kan göra ett block av kod med hjälp av {} eller för bara en variabel tex, skriva den direkt efter @.
Man kan också lägga till ett HTML-element som vanligt direkt inuti ett block av C# kod.

RAZOR PAGES
När man skapar en Razor Page får man både en .cshtml-fil (Content-page) och en .cshtml.cs-fil (Page-model), som är connectade genom att content-page 
bestämmer vilken model som används genom "@model MyModel" näst längst upp i koden. 
Content-page är html-delen av sidan, där razor-kod används för att skapa html-sidan. 
I Page-model skapar man sina propertys som man sedan kan komma åt i content page. 
Page-model bestämmer också vad som ska hända när sidan laddas (onget.metod) samt när någonting postas (onpost-metod).


MVC

Model:
Här skapas modell-klasser, med properties som sedan kan bindas till databasen. (En klass för varje tabell)

View:
Det som användaren ser, alltså UI (User interface) (som content-page i razor pages)

Controller:
Hanterar saker som händer i appen (actions), som metoderna i Page-model för razor pages

Alltså, användaren ser viewen som säger till controllern när något ska hända, då uppdaterar controllern modellen,
som då säger till viewen att något ändrats, och då hämtar viewen den nya modell-datan och uppdaterar sig.



