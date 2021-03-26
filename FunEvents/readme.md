ASP .NET Core

ASP .NET Core �r ett utvecklings-plattform som �r cross-platform, allts� funkar p� olika typer av enheter och operativsystem.
Det anv�nds till att skapa webbapplikationer gratis med inbyggd k�llkodsram. 
Man kan v�lja olika templates f�r olika anv�ndningsomr�den samt hur mycket kod man vill ha "gratis".

STARTUP �r en klass som finns i ett ASP .NET Core projekt som inneh�ller n�gra metoder som kallas p� n�r appen startas, 
efter att appens host byggts. I ConfigureServices metoden anv�nds service-parametern f�r att l�gga till services i appen, 
t.ex. l�gger den till razor pages, och man kan skapa en connection d�r till sin databas med hj�lp av din databas-context klass.
Configure metoden anv�nds f�r att svara p� appens http-requests.

WWWROOT mappen inneh�ller appens statiska filer, s� som css, javascript, bilder och scripts.

RAZOR-SPR�KET som anv�nds i ASP .NET Core �r en kombination av programspr�k (C# och HTML), n�r appen k�rs omvandlas koden till bara HTML. 
Symbolen @ anv�nds f�r att skriva C# kod i HTML koden. Man kan g�ra ett block av kod med hj�lp av {} eller f�r bara en variabel tex, skriva den direkt efter @.
Man kan ocks� l�gga till ett HTML-element som vanligt direkt inuti ett block av C# kod.

RAZOR PAGES
N�r man skapar en Razor Page f�r man b�de en .cshtml-fil (Content-page) och en .cshtml.cs-fil (Page-model), som �r connectade genom att content-page 
best�mmer vilken model som anv�nds genom "@model MyModel" n�st l�ngst upp i koden. 
Content-page �r html-delen av sidan, d�r razor-kod anv�nds f�r att skapa html-sidan. 
I Page-model skapar man sina propertys som man sedan kan komma �t i content page. 
Page-model best�mmer ocks� vad som ska h�nda n�r sidan laddas (onget.metod) samt n�r n�gonting postas (onpost-metod).


MVC

Model:
H�r skapas modell-klasser, med properties som sedan kan bindas till databasen. (En klass f�r varje tabell)

View:
Det som anv�ndaren ser, allts� UI (User interface) (som content-page i razor pages)

Controller:
Hanterar saker som h�nder i appen (actions), som metoderna i Page-model f�r razor pages

Allts�, anv�ndaren ser viewen som s�ger till controllern n�r n�got ska h�nda, d� uppdaterar controllern modellen,
som d� s�ger till viewen att n�got �ndrats, och d� h�mtar viewen den nya modell-datan och uppdaterar sig.



