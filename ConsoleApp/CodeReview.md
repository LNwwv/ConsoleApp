# Code review
- usuni�to wszystkie nieu�ywane usingi,

- z pliku `DataReader.cs` wyniesiono klasy: `ImportedObjectBase` oraz `ImportedObject` do folderu ImportedObjects,

- klasa `ImportedObject` otrzyma�a konstruktor, zmieniony zosta� typ pola IsNullable na `bool`, a w nim wykorzystywana jest metoda `ImportedObjectBase.ModifyStringValue`, kt�ra odpowiada za modyfikacj� warto�ci string.
- `ImportedObjectBase` zmieni�a nazw� oraz otrzyma�a konstruktor,

- metod� `ImportAndPrintData` podzielono na 3 oddzielne metody, z kt�rych ka�da odpowiada teraz za pojedyncz� funkcjonalno��:
> 1. `DataProcessing` - przekszta�cenie danych oraz zapisanie do listy obiekt�w,
> 1. `AssignNumberOfChildren` - ustawienie odpowiedniej liczby pola `NumberOfChildren` dla ka�dego z obiekt�w,
> 1. `PrintDatabasesTablesAndColumns`, 'PrintTablesAndColumns', `PrintTables` - tak jak wskazuj� nazwy funckcji, odpowiadaj� za wy�wietlanie odpowiedniego zestawu danych,

- zmieniono spos�b wczytywania danych na `File.ReadAllLines`
- oczyszczanie oraz poprawianie danych dzieje si� teraz przy ich tworzeniu, w konstruktorach
- usystematyzowano r�wnie� deklaracje zmiennych w klasach, 