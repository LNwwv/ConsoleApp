namespace ConsoleApp.ImportedObjects
{
    internal class ImportedObject : ImportedObjectBase
    {
        public string Name { get; set; }

        public string Schema { get; set; }

        public string ParentName { get; set; }

        public string ParentType { get; set; }

        public string DataType { get; set; }

        public bool IsNullable { get; set; }

        public int NumberOfChildren { get; set; }

        public ImportedObject(string type, string name, string schema, string parentName, string parentType, string dataType, bool isNullable) : base(type)
        {
            Name = ModifyStringValue(name);
            Schema = ModifyStringValue(schema);
            ParentName = ModifyStringValue(parentName);
            ParentType = ModifyStringValue(parentType);
            DataType = ModifyStringValue(dataType);
            IsNullable = isNullable;
        }
    }
}
