using System.Collections.Generic;
namespace DocumentSystem.Models
{
    public class TextDocument : Document, IDocument, IEditable
    {
        public TextDocument(string name, string charset = null)
            : base(name)
        {
            this.Charset = charset;
        }

        public string Charset { get; private set; }

        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "charset")
            { this.Charset = value; }
            else
            { base.LoadProperty(key, value); }
        }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }

        public override void SaveAllProperties(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object>> output)
        {
            if (this.Charset != null)
                output.Add(new KeyValuePair<string, object>("charset", this.Charset));
            base.SaveAllProperties(output);
        }
    }
}
