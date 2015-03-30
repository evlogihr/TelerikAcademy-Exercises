using System.Collections.Generic;
namespace DocumentSystem.Models
{
    public class VideoDocument : MultimediaDocument, IDocument
    {
        public VideoDocument(string name, string content = null, int size = 0, int length = 0, int frameRate = 0)
            : base(name, content, size, length)
        {
            this.FrameRate = frameRate;
        }

        public int FrameRate { get; private set; }

        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "framerate")
            { this.FrameRate = int.Parse(value); }
            else { base.LoadProperty(key, value); }
        }

        public override void SaveAllProperties(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object>> output)
        {
            if (this.FrameRate != 0)
                output.Add(new KeyValuePair<string, object>("framerate", this.FrameRate));
            base.SaveAllProperties(output);
        }
    }
}
