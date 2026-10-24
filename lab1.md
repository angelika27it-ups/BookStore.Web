
ODP A1
Program.cs — konfiguruje usługi i potok żądań HTTP, w tym routing MVC.
Controllers/ — zawiera kontrolery obsługujące żądania HTTP.
Models/ — zawiera klasy danych i modele używane przez aplikację.
Views/ — zawiera widoki Razor, które generują HTML po stronie serwera.
wwwroot/ — publiczne pliki statyczne, np. CSS, JavaScript i obrazy.
appsettings.json — przechowuje konfigurację aplikacji.
Properties/launchSettings.json — zawiera profile uruchomieniowe, adresy i środowisko deweloperskie.

ODP B
Metoda pierwszego żądania: GET.
Kod statusu: zwykle 200 OK.
Content-Type: zależy od żądania; dla /Book/Hello będzie text/plain; charset=utf-8.
User-Agent: nagłówek opisujący przeglądarkę lub klienta wysyłającego żądanie.
Strona może wykonać więcej niż jedno żądanie, bo pobiera też pliki CSS, JavaScript, obrazy i inne zasoby.
Adres /abc: standardowo 404 Not Found.

PYTANIA KONT.
1. GET służy głównie do pobierania danych, a parametry często są w URL. POST przesyła dane w treści żądania.
2. 200 OK; 302 przekierowanie tymczasowe; 400 nieprawidłowe żądanie; 401 brak prawidłowego uwierzytelnienia; 403 dostęp zabroniony; 404 nie znaleziono zasobu; 405 niedozwolona metoda; 500 błąd serwera.
3. Model binding korzysta z routingu i reguł przypisywania wartości do parametrów. Atrybuty [FromQuery] i [FromBody] pozwalają wskazać źródło danych.
4. wwwroot jest przeznaczony do udostępniania plików statycznych. Pliki w Controllers zawierają kod serwerowy i nie są bezpośrednio udostępniane klientowi.


