using System;
namespace ConsoleApp.ImportedObjects
{
    public class ImportedObjectBaseClass
    {
        public string Type { get; set; }

        public ImportedObjectBaseClass(string type)
        {
            Type = ModifyStringValue(type);
        }

        internal string ModifyStringValue(string value)
        {
            return value.Trim().Replace(" ", "").Replace(Environment.NewLine, "").ToUpper();
        }
    }
}
