using System.Collections.Generic;
namespace DocumentSystem.Models
{
    public class ExcelDocument : OfficeDocument, IDocument, IOfficeDocument, IEncryptable
    {
        public ExcelDocument(string name, string content = null, int size = 0, string version = null, int numberOfColumns = 0, int numberOfRows = 0)
            : base(name, content, size, version)
        {
            this.NumberOfColumns = numberOfColumns;
            this.NumberOfRows = numberOfRows;
        }

        public int NumberOfColumns { get; private set; }

        public int NumberOfRows { get; private set; }

        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "rows")
            { this.NumberOfRows = int.Parse(value); }
            else if (key.ToLower() == "cols")
            { this.NumberOfColumns = int.Parse(value); }
            else
            { base.LoadProperty(key, value); }
        }

        public override void SaveAllProperties(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object>> output)
        {
            if (this.NumberOfColumns != 0)
                output.Add(new KeyValuePair<string, object>("cols", this.NumberOfColumns));

            if (this.NumberOfRows != 0)
                output.Add(new KeyValuePair<string, object>("rows", this.NumberOfRows));

            base.SaveAllProperties(output);
        }
    }
}
