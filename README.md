# Evaluarea nr. 2 pentru cursul Tehnici Avansate de Programare 2021 sesiunea de restanțe #

## Context ##
Sunteți proaspăt angajat la **Leii Grei** o firmă care își propune să revoluționeze piața bancară oferind un instrument de plată inteligent numit **Pușculița**.

Pentru a crește numărul de clienți, șeful de la **Leii Grei** vine cu o idee specială pentru o promoție de început de an academic: clienții (noi sau existenți) ale căror cifre din IBAN formează un palindrom vor primi un cadou în valoare de 512 RON.

Șeful, care nu prea are treabă cu programarea, vă trimite un e-mail cu următorul conținut:
> Salut,
>
> Te laudă colegii că scrii cod solid, extorsionezi metode și vorbești de bune practici precum TDD și alte acronime.
>
> Te rog să-mi extorsionezi o metodă solidă în TDD cu ajutorul căreia să putem identifica dacă cifrele unui IBAN sunt palindrom. Totodată, vreau să-mi explici cum trece codul sursă din lichid în solid și dacă mai are alte stări de agregare.
>
> Trec diseară pe la tine la birou să-mi arăți ce-ai făcut.

După ce ați citit de câteva ori e-mailul, vă dați seama că, de fapt, șeful vrea să creați o **metodă de extensiune** care **să determine dacă cifrele numărului IBAN sunt palindrom** iar *codul solid* se referă la **principiile SOLID** pe care le-ați menționat ieri într-o discuție cu colegul Marcel, alături de stilul **TDD** și bunele practici legate de istoricul codului-sursă.

Făcându-vă o notă să fiți mai atent în discuțiile viitoare cu Marcel, începeți să vă faceți o listă de acțiuni pentru a îndeplini sarcina primită:
- Să creați două biblioteci în limbajul `C#` (platforma `.net core`):
  - Una care să conțină o metodă de extensiune numită `IsPalindrome`,
  - A doua - un modul de teste pentru metoda `IsPalindrome` pentru a lucra în stilul TDD.
- Să creați un document în formatul `markdown` pentru a explica principiile SOLID deoarece explicațiile vor fi utilie și pentru alți colegi.


## Cerințe ##
  1. Faceți fork la acest proiect în contul propriu de Github.
  2. Clonați fork-ul pe calculatorul de luru.
  3. În clona din calculatorul de lucru creați un director cu numele utilizatorului vostru GitHub. Ex. `mkdir numeutilizator`, unde `numeutilizator` este numele de utilizator Github.
  4. În directorul `numeutilizator` creați alte două directoare: `docs` și `src`.
  5. În directorul `docs` creați un fișier `README.md` și explicați principiile **SOLID** respectând sintaxa markdown. Documentul final trebuie să aibă un titlu și câte o secțiune cu subtitlu și descriere pentru fiecare principiu descris.
  6. În directorul `src` creați o soluție `Visual Studio` nouă în care să implementați metoda `IsPalindrome` și testele pentru aceasta aplicând bunele practici discutate la curs și laboratoare.
  7. După ce ați completat cerințele sau la sfârșit sesiunii de evaluare:
	 - Trimiteți modificările pe fork-ul creat la început (`git push origin`),
	 - Din interfața web Github, creați un Pull-Request pentru a trimite modificările în acest proiect Github.

## Observații ##
  - Pentru cerințele de mai sus trebuie să lucrați exclusiv în timpul alocat sesiunii de evaluare. Pull-request-ul cu rezolvarea trebuie să fie inițiat înainte de sfârșitul sesiunii de evaluare.
  - Fiecare student va iniția *un singur pull-request*.
  - Pentru a genera valori IBAN folosiți [Random Iban Generator](http://www.randomiban.com/?country=Romania "Random Iban Generator").
  - Structura IBAN este descrisă în [Standard IBAN Format in Romania](https://bank.codes/iban/structure/romania/ "Standard IBAN Format in Romania"). **Pentru aplicația de față vom considera că numărul de cont este alcătuit doar din cifre**.
