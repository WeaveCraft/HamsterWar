# HamsterWar

School Project REST API with Blazor Web.



Inledning

Bakgrund

Din uppgift är att bygga en fullstack lösning för kommande virala sensationen, webbplatsen HAMSTERWARS.
Webbplatsen är en spinoff på Kittenwar, en hemsida där matcher mellan två kattungar (bilder) slumpas fram
och besökarna röstar på den de finner gulligast. Poäng ska räknas, listor ska sammanställas.
Uppgiften är uppdelad i två delar: backend och frontend. Del 1 handlar om att bygga ett API. I del 2 ska du
bygga en frontend till API:et med Blazor Web Assembly. Båda delarna skall publiceras online på Microsoft
Azure.

Mål med uppgiften

Efter projektet ska du:
1. Kunna effektivt skapa webbappar med Blazor
2. Kunna komplettera frontend webbappar med en backend-applikation
3. Kunna bygga ett REST API och använda det från en frontend
4. Kunna publicera hela din app med Azure
5. Förstå hur ett REST API fungerar
6. Förstå hur man använder Git för att versionshantera ett projekt
7. Förstå HTTP statuskoder
8. 
Detta är för att du ska kunna arbeta med modern utveckling efter utbildningen, och snabbt kunna sätta dig in
i hur olika företag arbetar med teknikerna.

Del 1: Hamster Wars Backend

Specifikation

Godkänt-nivå
Projektdagbok
En projektdagbok skall föras, där du skriver några rader varje dag om vad du har gjort. Eventuella problem
och lösningar, andra tankar kring arbetet. Dagboken ka ha formen av en Word-fil eller ett markdowndokument (liknande README.md).
Datamodell
Ett hamster-objekt skall innehålla följande egenskaper. Du får lägga till fler om du behöver, men inte ta bort
några.
Egenskap Datatyp Värde
Id Int Id för hamstern
Name String Hamsterns namn
Age Int Hamsterns ålder i hela år
FavFood String Hamsterns favoritmat
Loves String Hamsterns favoritaktivitet
ImgName String Namn på bildfilen för hamstern
Wins Int Antal vinster
Losses Int Antal förluster
Games Int Antal matcher totalt
Hamstrarna skall sparas i en SQL-databas. Ni skall använda Entity Framework för dataåtkomst. Dataåtkomst
skall ske via ett eget klassbibliotek.
Bilder på hamstrarna skall ligga i en statisk mapp under wwwroot, förslagsvis /images. Lägg hamsterbilder i
en egen (under-) mapp, så att de kan hanteras separat från övriga bilder på sidan.
API-resurser
Alla API-resurser ska returnera en HTTP statuskod och eventuella data i JSON-format:
• 200 (OK) - Om servern lyckats med att göra det som resursen motsvarar.
• 400 (bad request) - Om begäran är felaktigt gjord, så att servern inte kan fortsätta. Exempel: POST
/hamsters skickar med ett objekt som inte är ett hamster-objekt.
• 404 (not found) - Om resursen eller objektet som efterfrågas inte finns. Exempel: id motsvarar inte
något dokument i databasen. GET /hamsters/felaktigt-id
• 500 (internal server error) - Om ett fel inträffar på servern. Använd try-catch för att fånga det.
Metod Resurs Body Respons

GET /hamsters - Array med alla hamsterobjekt
GET /hamsters/random - Ett slumpat hamsterobjekt
GET /hamsters/id - Hamsterobjekt med ett specifikt id. 404
om inget objekt med detta id finns.

Metod Resurs Body Respons
POST /hamsters Hamster-objekt utan id
(ska skapas av
databasen)
Ett objekt med id för det nya objekt som
skapats i databasen: {id: ”123”}
PUT /hamsters/id Ett objekt med
ändringar: {wins: 10,
games: 12}
Bara statuskod
DELETE /hamsters/id - Bara statuskod
Övriga krav
• Databasen skall skapas och fyllas på med testdata vid programstart
• Om det behövs några manuella ändringar, till exempel justering av connection string, skall detta
anges i en README-fil. På lärarens dator börjar alla connection-strängar med
(localhost)\MSSQLLocalDb.
Väl Godkänt-nivå
Datamodell
Appen ska spara resultatet av genomförda matcher i databasen, i matchobjekt enligt nedan.
Egenskap Datatyp Värde
Id Int Id för hamstern
Name String Hamsterns namn
Age Int Hamsterns ålder i hela år
FavFood String Hamsterns favoritmat
Loves String Hamsterns favoritaktivitet
ImgName String Namn på bildfilen för hamstern
Wins Int Antal vinster
Losses Int Antal förluster
Games Int Antal matcher totalt
Nya API-resurser
Metod Resurs Body Respons
GET /matches - Array med alla matchobjekt
GET /matches/id - Matchobjekt med ett specifikt id.
POST /matches Match-objekt utan id (ska
skapas av databasen)
Ett objekt med id för det nya objekt som
skapats i databasen: {id: "123"}
DELETE /matches/id - Bara statuskod
GET /matchWinners/id - Array med matchobjekt för alla matcher,
som hamstern med id har vunnit.
Statuskod 404 om id inte matchar en
hamster som vunnit någon match.
GET /winners - En array av hamsterobjekt för de 5 som
vunnit flest matcher
GET /losers - En array av hamsterobjekt för de 5 som
förlorat flest matcher.


Level ups
Resurser som är bra träning, men inte nödvändiga för högsta betyg.
1. GET /defeated/hamsterId - array med id för alla hamstrar den valda hamstern har besegrat
2. GET /score/challenger/defender - två hamster-id som parameter. Respons ska vara ett
objekt { challengerWins, defenderWins } med antal vinster för respektive hamster, när de
har mött varandra.
3. GET /fewMatches - returnerar en array med id för de hamstrar som spelat minst antal matcher.
Arrayen ska ha minst ett element.
4. GET /manyMatches - returnerar en array med id för de hamstrar som spelat flest antal matcher.
Arrayen ska ha minst ett element.
5. Implementera en komplett Onion Architecture för din lösning, med designmönster som Repository,
Services osv. Använd gärna strukturen i boken Ultimate ASP.NET Core Web API som förlaga.
