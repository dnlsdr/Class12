#  A vállalat (munkatársak)

## A feladat leírása

### Alaposztály: `Alkalmazott`

Hozz létre egy `Alkalmazott` nevű absztrakt osztályt.

Egy cégnél nincs olyan ember, akinek a munkaköre csupán „alkalmazott” lenne, mindenkinek van konkrét pozíciója.

- Legyen egy `Nev` nevű tulajdonsága, amelyet csak a létrehozáskor, a konstruktorban lehessen megadni.
- A név később ne legyen módosítható.
- Legyen egy `Fizetes` nevű, egész szám típusú tulajdonsága.
- Legyen egy absztrakt `Dolgozik()` metódusa.

### Gyerekosztály 1: `Fejleszto`

Hozz létre egy `Fejleszto` osztályt, amely örököl az `Alkalmazott` osztályból.

- Kérjen be pluszban egy `KedvencNyelv` nevű szöveges adatot.
- Írd felül a `Dolgozik()` metódust.
- A metódus például az alábbi szöveget írhatja ki:

  > A fejlesztő C# kódot ír.

### Gyerekosztály 2: `Menedzser`

Hozz létre egy `Menedzser` osztályt, amely örököl az `Alkalmazott` osztályból.

- Kérjen be pluszban egy `CsapatLetszam` nevű, egész szám típusú adatot.
- Írd felül a `Dolgozik()` metódust.
- A metódus például az alábbi szöveget írhatja ki:

  > A menedzser 5 embert irányít.

## Főprogram

- Készíts egy listát az alkalmazottakból.
- Helyezz bele egy fejlesztőt és egy menedzsert.
- Egy ciklussal:
  1. Írasd ki az alkalmazottak nevét.
  2. Hívd meg a `Dolgozik()` metódusukat.
