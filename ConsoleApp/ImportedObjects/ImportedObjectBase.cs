using System;
namespace ConsoleApp.ImportedObjects
{
    public class ImportedObjectBase
    {
        public string Type { get; set; }

        public ImportedObjectBase(string type)
        {
            Type = ModifyStringValue(type);
        }

        internal string ModifyStringValue(string value)
        {
            return value.Trim().Replace(" ", "").Replace(Environment.NewLine, "").ToUpper();
        }
    }
}
