# Code review
- usunięto wszystkie nieużywane usingi,

- z pliku `DataReader.cs` wyniesiono klasy: `ImportedObjectBase` oraz `ImportedObject` do folderu ImportedObjects,

- klasa `ImportedObject` otrzymała konstruktor, zmieniony został typ pola IsNullable na `bool`, a w nim wykorzystywana jest metoda `ImportedObjectBase.ModifyStringValue`, która odpowiada za modyfikację wartości string.

- `ImportedObjectBase` zmieniła nazwę oraz otrzymała konstruktor,

- metodę `ImportAndPrintData` podzielono na 3 oddzielne metody, z których każda odpowiada teraz za pojedynczą funkcjonalność:
> 1. `DataProcessing` - przekształcenie danych oraz zapisanie do listy obiektów,
> 1. `AssignNumberOfChildren` - ustawienie odpowiedniej liczby pola `NumberOfChildren` dla każdego z obiektów,
> 1. `PrintDatabasesTablesAndColumns`, 'PrintTablesAndColumns', `PrintTables` - tak jak wskazują nazwy funckcji, odpowiadają za wyświetlanie odpowiedniego zestawu danych,

- zmieniono sposób wczytywania danych na `File.ReadAllLines`

- oczyszczanie oraz poprawianie danych dzieje się teraz przy ich tworzeniu, w konstruktorach

- usystematyzowano również deklaracje zmiennych w klasach, 

- dodałem również krótkie README.md dla projektu
