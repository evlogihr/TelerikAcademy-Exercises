namespace HTMLRenderer.Models
{
    using System.Collections.Generic;
    using System.Text;

    using HTMLRenderer.Interfaces;

    public class Element : BaseElement, IElement, IBaseElement
    {
        private ICollection<IBaseElement> childElements;

        public Element(string name, string content = null)
            : base(name)
        {
            this.TextContent = content;
            this.childElements = new List<IBaseElement>();
        }

        public string TextContent { get; set; }

        public IEnumerable<IBaseElement> ChildElements
        {
            get { return this.childElements; }
        }

        public void AddElement(IBaseElement element)
        {
            this.childElements.Add(element);
        }

        public override void Render(StringBuilder output)
        {
            string format = "{1}{2}";
            if (!string.IsNullOrEmpty(Name))
            {
                format = "<{0}>" + format + "</{0}>";
            }

            output.AppendFormat(format,
                this.Name, this.HTMLEncode(this.TextContent), string.Join("", this.ChildElements));
        }

        private string HTMLEncode(string content)
        {
            if (!string.IsNullOrEmpty(content))
            {
                content = content
                    .Replace("&", "&amp;")
                    .Replace("<", "&lt;")
                    .Replace(">", "&gt;");
            }

            return content;
        }
    }
}
