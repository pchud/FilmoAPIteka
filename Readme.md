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
    Przyk³adowy projekt API zrealizowany w technologii .NET Core.
    <br />
    <a href="https://github.com/pchud/FilmoAPIteka/blob/master/README.md"><strong>Przegl¹d dokumentacji »</strong></a>
    <br />
    <br />
    <a href="https://filomoapiteka.azurewebsites.net/swagger/index.html">Zobacz demo (swagger)</a>
    ·
    <a href="https://github.com/pchud/FilmoAPIteka/issues">Zg³oœ b³¹d</a>
    ·
    <a href="https://github.com/pchud/FilmoAPIteka/issues">Zg³oœ now¹ funkcjê</a>
  </p>
</div>

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Spis treœci</summary>
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
        <li><a href="#wymagania-wstepne">Wymagania wstêpne</a></li>
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
Podstawowym celem projektu by³a realizacja prostej aplikacji webowej przy u¿yciu frameworka Vue.js. Aplikacja pozwala zarz¹dzaæ bibliotek¹ filmow¹. (dodawaæ, edytowaæ i usuowaæ filmy z biblioteki.)
<p align="right">[<a href="#readme-top">Powrót na górê</a>]</p>

<!-- TECH STACK -->
### Technologie
Poni¿ej lista u¿ytych technologii, frameworków oraz bibliotek u¿ytych w projekcie.
- .NET 5.0
- Entity Framework Core

<p align="right">[<a href="#readme-top">Powrót na górê</a>]</p>

<!-- DEMO -->
## Demo
### Link do aplikacji
<p>Aplikacja zosta³a udostêpniona pod linkiem.</p>
<p> <strong>Demo (swagger):</strong> <a href="https://filomoapiteka.azurewebsites.net/swagger/index.html">zobacz</a></p>

<!-- GETTING STARTED -->
## Instrukcja
Poni¿ej instrukcja zwi¹zana z uruchomieniem i testowaniem aplikacji.

### Wymagania wstêpne
Do poprawnego uruchomienia projektu zalecane jest Visual Studio w wersji Community.

### Instalacja
Poni¿aj opis instalacji projektu we w³asnym œrodowisku developerskim

1. Klonowanie repozytorium
   ```sh
   git clone https://github.com/pchud/FilmoAPIteka-Vue.git
   ```
2. Utworzenie pliku ustawieñ aplikacji w aplikacji <strong>WebAPI</strong>: WebAPI/appsettings.json i uzupe³nienie go nastêpuj¹c¹ treœci¹:
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
3. Klucz LibraryCS nale¿y powi¹zaæ z odpowiednim ³añcuchem po³¹czenia (connection string) do uruchomione bazy danych.
4. Aplikacjê <strong>WebAPI</strong> nale¿y ustawiæ jako domyœln¹. (PPM > Set as startup project).
5. Nastêpnym krokiem jest zbudowanie rozwi¹zania na podstawie projektu i upewnienie siê czy nie wyst¹pi³ b³¹d podczas jej generowania.
6. Kolejnym krokiem jest utworzenie tabeli w bazie danych, aby to zrealizowaæ nale¿y przejœæ do <strong>Konsoli NuGet Package Managera</strong>, upewniæ siê, ¿e domyœlny projekt ustawiony jest na <strong>src\WebAPI</strong> i wpisaæ nastêpuj¹c¹ komendê:
    ```sh
    PM> Update-Database
    ```

   <p align="right">[<a href="#readme-top">Powrót na górê</a>]</p>

<!-- RUN THE PROJECT -->
## Uruchomienie
### Tryb developerski
Uruchomienie aplikacji w trybie developerskim.

Mamy mo¿liwoœæ uruchomienia aplikacji w trybie <strong>IIS Express</strong> oraz <strong>aplikacyjnej</strong>.

Dla IIS Express port to 44369:
<a href="https://localhost:44369/swagger/index.html">localhost:44369</a></p>


Dla aplikacji port to 5001:
<a href="https://localhost:5001/swagger/index.html">localhost:5001</a></p>

### Tryb produkcyjny
Aplikacja jest przygotowana pod dzia³anie na wielu platformach. (.NET Core), ze wzglêdu na specyfikê zadania Swagger jest dostêpny równie¿ w trybie produkcyjnym.
<p align="right">[<a href="#readme-top">Powrót na górê</a>]</p>

<!-- TO-DO LIST -->

## Lista To-do
- [x] Dodaæ readme
- [ ] Dodaæ znacznik od ulubionych wpisów.
- [ ] Podczas edycji pobranego filmu, zmieniæ ExtID na "0" - oznaczaj¹cy wpis lokalny.

Zobacz [otwarte zg³oszenia](https://github.com/pchud/FilmoAPIteka/issues), aby uzyskaæ pe³n¹ listê proponowanych funkcji (i znanych problemów).
<p align="right">[<a href="#readme-top">Powrót na górê</a>]</p>

<!-- CONTACT -->

## Kontakt

Piotr Chudalewski - [p.chudalewski@gmail.com](mailto:p.chudalewski@gmail.com)

Link projektu: [https://github.com/pchud/FilmoAPIteka](https://github.com/pchud/FilmoAPIteka)
<p align="right">[<a href="#readme-top">Powrót na górê</a>]</p>

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

