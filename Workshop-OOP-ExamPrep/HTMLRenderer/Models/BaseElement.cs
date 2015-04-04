namespace HTMLRenderer.Models
{
    using System.Collections.Generic;
    using System.Text;

    using HTMLRenderer.Interfaces;

    public abstract class BaseElement : IBaseElement
    {
        public BaseElement(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public abstract void Render(StringBuilder output);

        public override string ToString()
        {
            var sb = new StringBuilder();
            this.Render(sb);

            return sb.ToString();
        }
    }
}
