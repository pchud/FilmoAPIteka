<a name="readme-top"></a>

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/pchud/FilmoAPIteka">
    <h3 align="center">FilmoAPIteka - Back-end</h3>
  </a>

  <p align="center">
    Przyk�adowy projekt API zrealizowany w technologii .NET Core.
    <br />
    <a href="https://github.com/pchud/FilmoAPIteka/blob/master/README.md"><strong>Przegl�d dokumentacji �</strong></a>
    <br />
    <br />
    <a href="https://filomoapiteka.azurewebsites.net/swagger/index.html">Zobacz demo (swagger)</a>
    �
    <a href="https://github.com/pchud/FilmoAPIteka/issues">Zg�o� b��d</a>
    �
    <a href="https://github.com/pchud/FilmoAPIteka/issues">Zg�o� now� funkcj�</a>
  </p>
</div>

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Spis tre�ci</summary>
  <ol>
    <li>
      <a href="#o-projekcie">O projekcie</a>
      <ul>
        <li><a href="#technologie">Technologie</a></li>
      </ul>
    </li>
    <li>
      <a href="#demo">Demo</a>    
      <ul>
        <li><a href="#link-do-aplikacji">Link do aplikacji</a></li>
      </ul>
    </li>
    <li>
      <a href="#instrukcja">Instrukcja</a>
      <ul>
        <li><a href="#wymagania-wstepne">Wymagania wst�pne</a></li>
      </ul>
      <ul>
        <li><a href="#instalacja">Instalacja</a></li>
      </ul>
    </li>
    <li>
      <a href="#uruchomienie">Uruchomienie</a>
      <ul>
        <li><a href="#tryb-developerski">Tryb developerski</a></li>
      </ul>
      <ul>
        <li><a href="#tryb-produkcyjny">Tryb produkcyjny</a></li>
      </ul>
    </li>
    <li>
      <a href="#lista-to-do">Lista To-Do</a>
    </li>
    <li>
      <a href="#kontakt">Kontakt</a>
    </li>
  </ol>
</details>

<!-- ABOUT THE PROJECT -->

## O Projekcie
Podstawowym celem projektu by�a realizacja prostej aplikacji webowej przy u�yciu frameworka Vue.js. Aplikacja pozwala zarz�dza� bibliotek� filmow�. (dodawa�, edytowa� i usuowa� filmy z biblioteki.)
<p align="right">[<a href="#readme-top">Powr�t na g�r�</a>]</p>

<!-- TECH STACK -->
### Technologie
Poni�ej lista u�ytych technologii, framework�w oraz bibliotek u�ytych w projekcie.
- .NET 5.0
- Entity Framework Core

<p align="right">[<a href="#readme-top">Powr�t na g�r�</a>]</p>

<!-- DEMO -->
## Demo
### Link do aplikacji
<p>Aplikacja zosta�a udost�pniona pod linkiem.</p>
<p> <strong>Demo (swagger):</strong> <a href="https://filomoapiteka.azurewebsites.net/swagger/index.html">zobacz</a></p>

<!-- GETTING STARTED -->
## Instrukcja
Poni�ej instrukcja zwi�zana z uruchomieniem i testowaniem aplikacji.

### Wymagania wst�pne
Do poprawnego uruchomienia projektu zalecane jest Visual Studio w wersji Community.

### Instalacja
Poni�aj opis instalacji projektu we w�asnym �rodowisku developerskim

1. Klonowanie repozytorium
   ```sh
   git clone https://github.com/pchud/FilmoAPIteka-Vue.git
   ```
2. Utworzenie pliku ustawie� aplikacji w aplikacji <strong>WebAPI</strong>: WebAPI/appsettings.json i uzupe�nienie go nast�puj�c� tre�ci�:
   ```json
    {
      "ConnectionStrings": {
        "LibraryCS": "< CONNECTION STRING > "
      },
      "Logging": {
        "LogLevel": {
          "Default": "Information",
          "Microsoft": "Warning",
          "Microsoft.Hosting.Lifetime": "Information"
        }
      },
      "AllowedHosts": "*"
    }
    ```
3. Klucz LibraryCS nale�y powi�za� z odpowiednim �a�cuchem po��czenia (connection string) do uruchomione bazy danych.
4. Aplikacj� <strong>WebAPI</strong> nale�y ustawi� jako domy�ln�. (PPM > Set as startup project).
5. Nast�pnym krokiem jest zbudowanie rozwi�zania na podstawie projektu i upewnienie si� czy nie wyst�pi� b��d podczas jej generowania.
6. Kolejnym krokiem jest utworzenie tabeli w bazie danych, aby to zrealizowa� nale�y przej�� do <strong>Konsoli NuGet Package Managera</strong>, upewni� si�, �e domy�lny projekt ustawiony jest na <strong>src\WebAPI</strong> i wpisa� nast�puj�c� komend�:
    ```sh
    PM> Update-Database
    ```

   <p align="right">[<a href="#readme-top">Powr�t na g�r�</a>]</p>

<!-- RUN THE PROJECT -->
## Uruchomienie
### Tryb developerski
Uruchomienie aplikacji w trybie developerskim.

Mamy mo�liwo�� uruchomienia aplikacji w trybie <strong>IIS Express</strong> oraz <strong>aplikacyjnej</strong>.

Dla IIS Express port to 44369:
<a href="https://localhost:44369/swagger/index.html">localhost:44369</a></p>


Dla aplikacji port to 5001:
<a href="https://localhost:5001/swagger/index.html">localhost:5001</a></p>

### Tryb produkcyjny
Aplikacja jest przygotowana pod dzia�anie na wielu platformach. (.NET Core), ze wzgl�du na specyfik� zadania Swagger jest dost�pny r�wnie� w trybie produkcyjnym.
<p align="right">[<a href="#readme-top">Powr�t na g�r�</a>]</p>

<!-- TO-DO LIST -->

## Lista To-do
- [x] Doda� readme
- [ ] Doda� znacznik od ulubionych wpis�w.
- [ ] Podczas edycji pobranego filmu, zmieni� ExtID na "0" - oznaczaj�cy wpis lokalny.

Zobacz [otwarte zg�oszenia](https://github.com/pchud/FilmoAPIteka/issues), aby uzyska� pe�n� list� proponowanych funkcji (i znanych problem�w).
<p align="right">[<a href="#readme-top">Powr�t na g�r�</a>]</p>

<!-- CONTACT -->

## Kontakt

Piotr Chudalewski - [p.chudalewski@gmail.com](mailto:p.chudalewski@gmail.com)

Link projektu: [https://github.com/pchud/FilmoAPIteka](https://github.com/pchud/FilmoAPIteka)
<p align="right">[<a href="#readme-top">Powr�t na g�r�</a>]</p>

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->

[contributors-shield]: https://img.shields.io/github/contributors/pchud/FilmoAPIteka?style=for-the-badge
[contributors-url]: https://github.com/pchud/FilmoAPIteka/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/pchud/FilmoAPIteka.svg?style=for-the-badge
[forks-url]: https://github.com/pchud/FilmoAPIteka/network/members
[stars-shield]: https://img.shields.io/github/stars/pchud/FilmoAPIteka.svg?style=for-the-badge
[stars-url]: https://github.com/pchud/FilmoAPIteka/stargazers
[issues-shield]: https://img.shields.io/github/issues/pchud/FilmoAPIteka.svg?style=for-the-badge
[issues-url]: https://github.com/pchud/FilmoAPIteka/issues
[license-shield]: https://img.shields.io/github/license/pchud/FilmoAPIteka.svg?style=for-the-badge
[license-url]: https://github.com/pchud/FilmoAPIteka/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/piotr-chudalewski/
[product-screenshot]: images/screenshot.png

