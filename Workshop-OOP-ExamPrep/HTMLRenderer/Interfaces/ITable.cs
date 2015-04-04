namespace HTMLRenderer.Interfaces
{
    public interface ITable : IBaseElement, IElement
    {
        int Rows { get; }
        int Cols { get; }
        IElement this[int row, int col] { get; set; }
    }
}
