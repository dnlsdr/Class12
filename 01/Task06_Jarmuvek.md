# Járművek, öröklés

## A feladat leírása

### Interfész

Készíts egy `IOkosRendszer` nevű interfészt, amely megkövetel egy `AllapotJelentes()` metódust.

### Absztrakt ősosztály

Készíts egy `Jarmu` absztrakt osztályt.

- Legyen egy `Azonosito` nevű, csak a konstruktorban beállítható szöveges tulajdonsága.
  - Gondolj arra, hogy a tulajdonságnál csak `get` legyen, `set` ne.
- Legyen egy absztrakt `Indulas()` metódusa, hiszen minden jármű másképpen indul.
- Legyen egy virtuális `Fekezes()` metódusa, amely alapértelmezetten kiírja:

  > A jármű normál módon lassít.

### Első gyerekosztály: `ElektromosAuto`

- Örököljön a `Jarmu` osztályból.
- Valósítsa meg az `IOkosRendszer` interfészt.
- Az indulás legyen hangtalan.
- A fékezést írja felül (`override`), és írja ki:

  > Fékezés: energia visszatáplálása az akkumulátorba!

### Második gyerekosztály: `OnvezetoKamion`

- Szintén örököljön a `Jarmu` osztályból.
- Valósítsa meg az `IOkosRendszer` interfészt.
- Az indulás legyen hangos.
- A fékezést ne írja felül; maradjon az ősosztály alapértelmezett fékezése.

## Főprogram

- Hozz létre egy járművekből álló listát.
- Helyezd bele az elektromos autót és az önvezető kamiont.
- Egyetlen ciklussal menj végig a járműveken.
- Minden járműnél:
  1. Indítsd el.
  2. Fékezz vele.
  3. Kérj tőle állapotjelentést. -> segítség ehhez: pattern matching -> if (jarmu is IOkosRendszer okosJarmu) -> okosJarmu.AllapotJelentes(); 
