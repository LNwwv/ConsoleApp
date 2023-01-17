using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ConsoleApp.ImportedObjects;

namespace ConsoleApp.Services
{
    public class DataReaderService
    {
        private readonly List<ImportedObject> _importedObjects = new List<ImportedObject>();

        public void ImportAndPrintData(string fileName)
        {
            var importedLines = File.ReadAllLines(fileName);

            foreach (var importedLine in importedLines)
            {
                if (!string.IsNullOrEmpty(importedLine))
                {
                    var values = importedLine.Split(';');
                    var importedObject = new ImportedObject(values[0], values[1], values[2], values[3], values[4], values[5], values.ElementAtOrDefault(6) == "1");
                    _importedObjects.Add(importedObject);
                }
            }

            AssignNumberOfChildren();

            PrintDatabasesTablesAndColumns();
        }

        private void AssignNumberOfChildren()
        {
            var groupedImportedObjects = _importedObjects.GroupBy(x => new { x.ParentType, x.ParentName }).ToList();
            foreach (var group in groupedImportedObjects)
            {
                var parentObject = _importedObjects.FirstOrDefault(x =>
                    x.Type == group.Key.ParentType && x.Name == group.Key.ParentName);
                if (parentObject != null)
                {
                    parentObject.NumberOfChildren = group.Count();
                }
            }
        }

        private void PrintDatabasesTablesAndColumns()
        {
            foreach (var database in _importedObjects.Where(x => x.Type == "DATABASE"))
            {
                Console.WriteLine($"Database '{database.Name}' ({database.NumberOfChildren} tables)");
                PrintTablesAndColumns(database);
            }

            Console.ReadLine();
        }

        private void PrintTablesAndColumns(ImportedObject database)
        {
            foreach (var table in _importedObjects.Where(x => x.ParentType == database.Type && x.ParentName == database.Name))
            {
                Console.WriteLine($"\tTable '{table.Schema}.{table.Name}' ({table.NumberOfChildren} columns)");
                PrintTables(table);
            }
        }

        private void PrintTables(ImportedObject table)
        {
            foreach (var column in _importedObjects.Where(x => x.ParentType == table.Type && x.ParentName == table.Name))
            {
                Console.WriteLine($"\t\tColumn '{column.Name}' with {column.DataType} data type {(column.IsNullable == true ? "accepts nulls" : "with no nulls")}");
            }
        }
    }
}
