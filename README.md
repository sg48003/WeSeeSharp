# WeSeeSharp
Selekcijski zadatak COMBIS hackathona

Zadatak je napravljen u Visual Studio 2017, baza napravljena po principu Entity Framework Code First i napunjena s podacima članova tima.

Ako naiđete na error "localhost refused to connect. Search Google for localhost 51284", rješenje je na ovoj stranici http://stackoverflow.com/questions/37352603/localhost-refused-to-connect-error-in-visual-studio.
Sazetak rješenja:

    -Go to your project folder and open .vs folder (keep your check hidden item-box checked as this folder may be hidden sometimes)

    -in .vs folder - open config

    -see that applicationhost config file there? Delete that thing.(Do not worry it will regenerate automatically once you recompile the project.)

Restart Visual Studio i trebalo bi biti sve u redu.

Nadam se da će to biti dovoljno dobro s obzirom na vremenski rok i obveze pojedinih članova tima za ovaj selekcijski zadatak.
