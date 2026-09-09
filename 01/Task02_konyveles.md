## A következő funkciókat kell megvalósítani

- Üdvözöld a felhasználót egy üdvözlő üzenettel. Például: „Üdvözlünk a Könyvelési Rendszer 1.0-ban.”
- A rendszernek rendelkeznie kell egy folyószámlával és egy prémiumszámlával.
- A folyószámlának legyen egy azonosítója (`int`) és egy egyenlege (`decimal`).
- Folyószámla létrehozásakor lehessen megadni a kezdő egyenleget.
- Folyószámla létrehozása után bármikor lehessen pénzt befizetni rá.
- Lehessen kamatot számítani a folyószámla aktuális egyenlege és egy megadott kamatláb alapján.
- Bármikor lehessen kiíratni a folyószámla azonosítóját és aktuális egyenlegét.
- A prémiumszámla ugyanúgy működjön, mint a folyószámla.
- Az egyetlen különbség, hogy a prémiumszámla a felhasználó által megadott kamatlábon felül további 1% kamatot kap.
- Bármikor lehessen pénzt átutalni egyik számláról a másikra.

## A program végrehajtási sorrendje

1. Írd ki az üdvözlő üzenetet.
2. Hozz létre egy `100`-as azonosítójú folyószámlát `0` kezdő egyenleggel.
3. Hozz létre egy `200`-as azonosítójú prémiumszámlát `0` kezdő egyenleggel.
4. Írd ki mindkét számla egyenlegét.
5. Fizess be `2000`-et a folyószámlára.
6. Fizess be `6000`-et a prémiumszámlára.
7. Írd ki mindkét számla egyenlegét.
8. Utalj át `2000`-et a prémiumszámláról a folyószámlára.
9. Írd ki mindkét számla egyenlegét.
10. Számítsd ki mindkét számla kamatát `3%`-os kamatláb alapján.
11. Írd ki mindkét számla kamatát.
12. Írd ki mindkét számla egyenlegét a kamat hozzáadása után.

## Opcionális funkciók – haladó nehézség

A rögzített programfolyamat helyett kérj be adatokat a felhasználótól a bankszámlák megnyitásához és kezeléséhez.

**Tipp:** Használj menüt, amelyben a felhasználó kiválaszthat egy műveletet, majd ezt követően kérd be a szükséges adatokat.

## A program várt kimenete

```text
Üdvözlünk a Könyvelési Rendszer 1.0-ban.
A(z) „100” azonosítójú számla egyenlege: 0
A(z) „200” azonosítójú számla egyenlege: 0
A(z) „100” azonosítójú számla egyenlege: 2000
A(z) „200” azonosítójú számla egyenlege: 6000
A(z) „100” azonosítójú számla egyenlege: 4000
A(z) „200” azonosítójú számla egyenlege: 4000
Az 1. számla kamata: 120,00
A 2. számla kamata: 160,00
A(z) „100” azonosítójú számla egyenlege: 4120,00
A(z) „200” azonosítójú számla egyenlege: 4160,00
```
## Tippek

Először próbáld meg a kihívást a tippek megtekintése nélkül megoldani. Ha elakadsz, vagy nem tudod, hogyan kezdj hozzá, olvass el egy tippet a listából, majd próbáld folytatni a projektet.

Ha ismét elakadsz, nézd meg a következő tippet. 
- Hozz létre egy osztályt a folyószámla számára.
- Hozz létre egy osztályt a prémiumszámla számára.
- Használj öröklődést, hogy ne kelljen ugyanazt a kódot lemásolni a folyószámla osztályából a prémiumszámla osztályába.
- Írj felül egy metódust, hogy specializáld a prémiumszámla kamatszámítását.
- Egy másik osztályban valósíts meg egy statikus metódust a pénzátutalás funkciójához.
- A folyószámla osztályában hozz létre egy kiíró metódust, amely megkönnyíti a számla azonosítójának és aktuális egyenlegének megjelenítését.
- Az egyenleg típusaként használj `decimal` típust, a számlaazonosítóhoz pedig `int` típust.
