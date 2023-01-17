# Code review
- usuniêto wszystkie nieu¿ywane usingi,

- z pliku `DataReader.cs` wyniesiono klasy: `ImportedObjectBase` oraz `ImportedObject` do folderu ImportedObjects,

- klasa `ImportedObject` otrzyma³a konstruktor, zmieniony zosta³ typ pola IsNullable na `bool`, a w nim wykorzystywana jest metoda `ImportedObjectBase.ModifyStringValue`, która odpowiada za modyfikacjê wartoœci string.
- `ImportedObjectBase` zmieni³a nazwê oraz otrzyma³a konstruktor,

- metodê `ImportAndPrintData` podzielono na 3 oddzielne metody, z których ka¿da odpowiada teraz za pojedyncz¹ funkcjonalnoœæ:
> 1. `DataProcessing` - przekszta³cenie danych oraz zapisanie do listy obiektów,
> 1. `AssignNumberOfChildren` - ustawienie odpowiedniej liczby pola `NumberOfChildren` dla ka¿dego z obiektów,
> 1. `PrintDatabasesTablesAndColumns`, 'PrintTablesAndColumns', `PrintTables` - tak jak wskazuj¹ nazwy funckcji, odpowiadaj¹ za wyœwietlanie odpowiedniego zestawu danych,

- zmieniono sposób wczytywania danych na `File.ReadAllLines`
- oczyszczanie oraz poprawianie danych dzieje siê teraz przy ich tworzeniu, w konstruktorach
- usystematyzowano równie¿ deklaracje zmiennych w klasach, 