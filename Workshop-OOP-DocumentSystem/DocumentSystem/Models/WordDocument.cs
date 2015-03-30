using System.Collections.Generic;
namespace DocumentSystem.Models
{
    public class WordDocument : OfficeDocument, IDocument, IOfficeDocument, IEncryptable, IEditable
    {
        public WordDocument(string name = null, string content = null, int size = 0, string version = null, int numberOfCharacters = 0)
            : base(name, content, size, version)
        {
            this.NumberOfCharacters = numberOfCharacters;
        }

        public int NumberOfCharacters { get; private set; }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }

        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "chars")
            { this.NumberOfCharacters = int.Parse(value); }
            else
            { base.LoadProperty(key, value); }
        }

        public override void SaveAllProperties(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object>> output)
        {
            if (this.NumberOfCharacters != 0)
                output.Add(new KeyValuePair<string, object>("chars", this.NumberOfCharacters));
            base.SaveAllProperties(output);
        }
    }
}
