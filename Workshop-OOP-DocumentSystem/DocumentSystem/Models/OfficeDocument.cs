using System.Collections.Generic;
namespace DocumentSystem.Models
{
    public abstract class OfficeDocument : EncryptableDocument, IDocument, IOfficeDocument, IEncryptable
    {
        public OfficeDocument(string name, string content = null, int size = 0, string version = null)
            : base(name, content, size)
        {
            this.Version = version;
        }

        public string Version { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "version")
            { this.Version = value; }
            else
            { base.LoadProperty(key, value); }
        }

        public override void SaveAllProperties(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object>> output)
        {
            if (this.Version != null)
                output.Add(new KeyValuePair<string, object>("version", this.Version));
            base.SaveAllProperties(output);
        }
    }
}
