# Megoldás:

## Osztály létrehozása
- Kétféle mód közül bármelyik:
  - ctrl + .
  - Adjunk hozzá egy osztályt
- 5 tulajdonság
  - public get
  - private set
- 1 konstruktor
  - 1 paraméter --> string
  - Például: "Acsalapu;levél;6;8"
  - ;-el vannak elválasztva
  - 4 darab adat --> 5 tulajdonság?
  - átadott, fájlból beolvasott sort:
    - ;-ő mentén tagoljuk
    - [0] --> nev
    - [1] --> resz
    - [2] --> kezd
    - [3] --> veg
    - Időtartam: számolás (lásd következő pont)
- 5-ik tulajdonság --> időtartam
    - konstruktorban számoljuk
    - számolása: vég - kezdet ha vég > kezdet
    - vég > kezdet --> vég - kezdet + 1
    - Egyébként --> 12 - vég + kezdet + 1
 
## Adatok beolvasása és eltárolása:
- listában tároljuk az ubjektum példányokat
- olvassuk be:
  - System.IO
  - Streamreader
  - while ciklus --> !file.EndOfStream
  - cikluson belül listához hozzáadunk egy új objektom példány(peolvasott sor a paraméter)

## 1.feladat:
- Hány növény van?
  - lista.Count()

## 2.feladat:
- Milyen gyűjthető részek vannak?
- Hány darab van ezekből?
- adatszerk.: dictionary<string, int>
  - foreach "novenyek"
  - ha Resz nem kulcs --> akkor adjuk hozzá nullával
  - foreach "novenyek"
  - ha a Resz = Key akkor a Value-t növeljük 1-el

## 3.feladar:
- Maximum keresés az időtartam lapján
  - maximum változó=0
  - foreach "novenyek"
  - ha max < idotartam --> max = idotartam
- növények amelyek a legtöbb ideig szedtek
  - foreach "novenyek"
  - kiírnia ha időtartam = max

## 4.feladat:
- Időtartam átlag számítás
  - sum=0
  - atlag valt
  - foreach
  - sum+=Idotartam
  - atlag=sum/count
